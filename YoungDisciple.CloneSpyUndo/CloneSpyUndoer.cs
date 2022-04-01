using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lnk;

namespace YoungDisciple.CloneSpyUndo {
  internal class CloneSpyUndoer {
    private readonly StringBuilder log = new StringBuilder();

    public void UndoFolder(string path, bool includeSubfolders) {
      try {
        var searchOption = includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
        foreach (var fileName in Directory.EnumerateFiles(path, "*.lnk", searchOption))
          UndoFile(fileName);
      }
      finally {
        var logFileName = Path.Combine(Environment.CurrentDirectory, "log.txt");
        File.AppendAllText(logFileName, log.ToString());
      }
    }

    public void UndoFolder(string path) {
    }

    private void UndoFile(string fileName) {
      var lk = Lnk.Lnk.LoadFile(fileName);
      if (lk.Name == "Created by CloneSpy") {
        var destinationFile = Path.Combine(Path.GetFullPath(fileName), Path.GetFileNameWithoutExtension(fileName));
        if (!File.Exists(destinationFile)) {
          var sourceFile = MakeSourceFileName(lk);
          log.Append($"{DateTime.Now:s}  Copy {sourceFile} => {destinationFile}");
          File.Copy(sourceFile, destinationFile);
          log.AppendLine("   (success)");
        }
        log.Append($"Delete {fileName}");
        File.Delete(fileName);
        log.AppendLine("   (success)");
      }
    }

    private string MakeSourceFileName(LnkFile lk) {
      if (string.IsNullOrEmpty(lk.LocalPath))
        return Path.Combine(lk.NetworkShareInfo.NetworkShareName, lk.CommonPath);
      else return Path.Combine(lk.LocalPath, lk.CommonPath);
    }
  }
}
