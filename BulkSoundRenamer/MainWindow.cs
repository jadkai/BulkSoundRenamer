using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BulkSoundRenamer
{
  public partial class MainWindow : Form
  {
    private List<string> VoiceTypes = new List<string>
    {
      "TES4FemaleArgonian",
      "TES4FemaleDarkSeducer",
      "TES4FemaleGoldenSaint",
      "TES4FemaleHighElf",
      "TES4FemaleImperial",
      "TES4FemaleNord",
      "TES4FemaleRedguard",
      "TES4MaleArgonian",
      "TES4MaleBreton",
      "TES4MaleDarkSeducer",
      "TES4MaleDremora",
      "TES4MaleGoldenSaint",
      "TES4MaleHighElf",
      "TES4MaleImperial",
      "TES4MaleNord",
      "TES4MaleRedguard",
      "TES4MaleSheogorath"
    };

    public MainWindow()
    {
      InitializeComponent();

      var skyrimBaseDir = GetSteamSkyrimLocation();

      if (skyrimBaseDir == null)
      {
        MessageBox.Show("Couldn't get Skyrim installation directory");
      }
      else
      {
        baseDirTextBox.Text = skyrimBaseDir += "\\Data\\Sound\\Voice";
      }
    }

    private void goButton_Click(object sender, EventArgs e)
    {
      var source = sourceTextBox.Text.Trim();
      var dest = destTextBox.Text.Trim();
      var filesRaw = filesTextBox.Text.Trim();

      if (source.Length == 0)
      {
        MessageBox.Show("Must enter a source");
        return;
      }

      if (dest.Length == 0)
      {
        MessageBox.Show("Must enter a destination");
        return;
      }

      if (filesRaw.Length == 0)
      {
        MessageBox.Show("Must enter some files");
        return;
      }

      var files = new List<(string sourceFile, string destFile)>();

      using (var reader = new StringReader(filesRaw))
      {
        bool oddLine = true;
        string curLine = string.Empty;
        string firstLine = null;

        while ((curLine = reader.ReadLine()) != null)
        {
          curLine = curLine.Trim();

          if (string.IsNullOrEmpty(curLine)) continue;

          if (oddLine)
          {
            firstLine = curLine;
            oddLine = false;
          }
          else
          {
            files.Add((firstLine, curLine));
            oddLine = true;
          }
        }

        if (!oddLine)
        {
          MessageBox.Show("Mismatched lines");
          return;
        }
      }

      var baseDir = baseDirTextBox.Text;

      if (string.IsNullOrEmpty(baseDir))
      {
        MessageBox.Show("Base voice directory is required");
        baseDirTextBox.Focus();
        return;
      }

      if (!baseDir.EndsWith("\\"))
      {
        baseDir += "\\";
      }

      bool isMove = moveCheckbox.Checked;
      bool isDryRun = dryRunCheckbox.Checked;
      var results = new StringBuilder();

      foreach (var pair in files)
      {
        foreach (var voiceType in VoiceTypes)
        {
          var sourcePath = $"{baseDir}{source}\\{voiceType}\\{pair.sourceFile}";
          var destPath = $"{baseDir}{dest}\\{voiceType}\\{pair.destFile}";

          if (isDryRun)
          {
            results.AppendFormat(
              "Would {0} {1} to {2}{3}",
              isMove ? "move" : "copy",
              sourcePath,
              destPath,
              Environment.NewLine);

            continue;
          }

          if (File.Exists(sourcePath))
          {
            if (File.Exists(destPath))
            {
              var result = MessageBox.Show(
                $"{destPath} already exists. Overwrite?",
                "WARNING",
                MessageBoxButtons.YesNo);

              if (result != DialogResult.Yes)
              {
                results.AppendFormat(
                  "{0} already existed and was not overwritten{1}",
                  destPath,
                  Environment.NewLine);

                continue;
              }
            }

            try
            {
              if (isMove)
              {
                File.Move(sourcePath, destPath);

                results.AppendFormat(
                  "Moved {0} to {1}{2}",
                  sourcePath,
                  destPath,
                  Environment.NewLine);
              }
              else
              {
                File.Copy(sourcePath, destPath, true);

                results.AppendFormat(
                  "Copied {0} to {1}{2}",
                  sourcePath,
                  destPath,
                  Environment.NewLine);
              }
            }
            catch (Exception ex)
            {
              results.AppendFormat(
                "Exception attempting to {0} {1} to {2}: {3}{4}",
                isMove ? "move" : "copy",
                sourcePath,
                destPath,
                ex.Message,
                Environment.NewLine);
            }
          }
        }
      }

      resultsTextBox.Text = results.ToString();
    }

    private string GetSteamSkyrimLocation()
    {
      try
      {
        var steamInstallPath = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Valve\\Steam", "InstallPath", null);

        if (steamInstallPath == null)
        {
          return null;
        }

        return steamInstallPath + @"\steamapps\common\Skyrim Special Edition";
      }
      catch (Exception ex)
      {
        MessageBox.Show("Unable to find Skyrim path automatically.\n\n" + ex.ToString());
        return null;
      }
    }
  }
}
