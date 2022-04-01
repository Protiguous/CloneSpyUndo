using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoungDisciple.CloneSpyUndo
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e) {
      if (string.IsNullOrEmpty(FolderPath.Text)) SelectFolder();
      if (string.IsNullOrEmpty(FolderPath.Text)) return;
      var cs = new CloneSpyUndoer();
      cs.UndoFolder(FolderPath.Text, IncludeSubfolders.Checked);
    }

    private void Button2_Click(object sender, EventArgs e) {
      SelectFolder();
    }

    private void SelectFolder() {
      folderBrowserDialog1.ShowDialog();
      FolderPath.Text = folderBrowserDialog1.SelectedPath;
    }
  }
}
