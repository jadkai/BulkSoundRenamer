namespace BulkSoundRenamer
{
  partial class MainWindow
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.filesTextBox = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.sourceTextBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.destTextBox = new System.Windows.Forms.TextBox();
      this.goButton = new System.Windows.Forms.Button();
      this.moveCheckbox = new System.Windows.Forms.CheckBox();
      this.resultsTextBox = new System.Windows.Forms.TextBox();
      this.dryRunCheckbox = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.baseDirTextBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // filesTextBox
      // 
      this.filesTextBox.Location = new System.Drawing.Point(12, 33);
      this.filesTextBox.Multiline = true;
      this.filesTextBox.Name = "filesTextBox";
      this.filesTextBox.Size = new System.Drawing.Size(776, 311);
      this.filesTextBox.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(269, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Enter files to rename (odd lines source, even lines dest):";
      // 
      // sourceTextBox
      // 
      this.sourceTextBox.Location = new System.Drawing.Point(12, 413);
      this.sourceTextBox.Name = "sourceTextBox";
      this.sourceTextBox.Size = new System.Drawing.Size(307, 20);
      this.sourceTextBox.TabIndex = 2;
      this.sourceTextBox.Text = "Skyblivion.esm";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(9, 397);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Source";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(9, 439);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(60, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Destination";
      // 
      // destTextBox
      // 
      this.destTextBox.Location = new System.Drawing.Point(12, 455);
      this.destTextBox.Name = "destTextBox";
      this.destTextBox.Size = new System.Drawing.Size(307, 20);
      this.destTextBox.TabIndex = 4;
      this.destTextBox.Text = "Skyblivion.esm";
      // 
      // goButton
      // 
      this.goButton.Location = new System.Drawing.Point(12, 481);
      this.goButton.Name = "goButton";
      this.goButton.Size = new System.Drawing.Size(251, 90);
      this.goButton.TabIndex = 6;
      this.goButton.Text = "Go";
      this.goButton.UseVisualStyleBackColor = true;
      this.goButton.Click += new System.EventHandler(this.goButton_Click);
      // 
      // moveCheckbox
      // 
      this.moveCheckbox.AutoSize = true;
      this.moveCheckbox.Location = new System.Drawing.Point(660, 350);
      this.moveCheckbox.Name = "moveCheckbox";
      this.moveCheckbox.Size = new System.Drawing.Size(128, 17);
      this.moveCheckbox.TabIndex = 7;
      this.moveCheckbox.Text = "Move instead of copy";
      this.moveCheckbox.UseVisualStyleBackColor = true;
      // 
      // resultsTextBox
      // 
      this.resultsTextBox.Location = new System.Drawing.Point(325, 373);
      this.resultsTextBox.Multiline = true;
      this.resultsTextBox.Name = "resultsTextBox";
      this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.resultsTextBox.Size = new System.Drawing.Size(463, 198);
      this.resultsTextBox.TabIndex = 8;
      // 
      // dryRunCheckbox
      // 
      this.dryRunCheckbox.AutoSize = true;
      this.dryRunCheckbox.Location = new System.Drawing.Point(325, 350);
      this.dryRunCheckbox.Name = "dryRunCheckbox";
      this.dryRunCheckbox.Size = new System.Drawing.Size(60, 17);
      this.dryRunCheckbox.TabIndex = 9;
      this.dryRunCheckbox.Text = "Dry run";
      this.dryRunCheckbox.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(9, 358);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(108, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "Voices base directory";
      // 
      // baseDirTextBox
      // 
      this.baseDirTextBox.Location = new System.Drawing.Point(12, 374);
      this.baseDirTextBox.Name = "baseDirTextBox";
      this.baseDirTextBox.Size = new System.Drawing.Size(307, 20);
      this.baseDirTextBox.TabIndex = 11;
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 580);
      this.Controls.Add(this.baseDirTextBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.dryRunCheckbox);
      this.Controls.Add(this.resultsTextBox);
      this.Controls.Add(this.moveCheckbox);
      this.Controls.Add(this.goButton);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.destTextBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.sourceTextBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.filesTextBox);
      this.Name = "MainWindow";
      this.Text = "Bulk sound renamer";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.TextBox filesTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox destTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.CheckBox moveCheckbox;
        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.CheckBox dryRunCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox baseDirTextBox;
    }
}

