namespace YoungDisciple.CloneSpyUndo
{
  partial class Form1
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
      this.button1 = new System.Windows.Forms.Button();
      this.FolderPath = new System.Windows.Forms.TextBox();
      this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
      this.button2 = new System.Windows.Forms.Button();
      this.IncludeSubfolders = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(626, 31);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(104, 23);
      this.button1.TabIndex = 0;
      this.button1.Text = "Process Folder";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // FolderPath
      // 
      this.FolderPath.Location = new System.Drawing.Point(19, 33);
      this.FolderPath.Name = "FolderPath";
      this.FolderPath.Size = new System.Drawing.Size(553, 20);
      this.FolderPath.TabIndex = 1;
      this.FolderPath.Text = "G:\\layout\\_Archive\\2018Q3\\";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(579, 30);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(25, 23);
      this.button2.TabIndex = 2;
      this.button2.Text = "...";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Button2_Click);
      // 
      // IncludeSubfolders
      // 
      this.IncludeSubfolders.AutoSize = true;
      this.IncludeSubfolders.Checked = true;
      this.IncludeSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
      this.IncludeSubfolders.Location = new System.Drawing.Point(19, 65);
      this.IncludeSubfolders.Name = "IncludeSubfolders";
      this.IncludeSubfolders.Size = new System.Drawing.Size(114, 17);
      this.IncludeSubfolders.TabIndex = 3;
      this.IncludeSubfolders.Text = "Include Subfolders";
      this.IncludeSubfolders.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(773, 95);
      this.Controls.Add(this.IncludeSubfolders);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.FolderPath);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "CloneSpy Undo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox FolderPath;
    private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.CheckBox IncludeSubfolders;
  }
}

