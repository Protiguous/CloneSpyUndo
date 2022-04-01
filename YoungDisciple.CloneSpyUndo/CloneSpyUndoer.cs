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

    public static string LogFileName {
      get {
        return Path.Combine(Environment.CurrentDirectory, "log.txt");
      }
    }

    public void UndoFolder(string path, bool includeSubfolders) {
      try {
        var searchOption = includeSubfolders ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
        foreach (var fileName in Directory.EnumerateFiles(path, "*.lnk", searchOption))
          UndoFile(fileName);
      } finally {
        File.AppendAllText(LogFileName, log.ToString());
      }
    }

    public void UndoFolder(string path) {
    }

    private void UndoFile(string fileName) {
      var lk = GetLnkFile(fileName);
      if (lk == null || lk.Name != "Created by CloneSpy") return;
      var destinationFile = Path.Combine(Path.GetDirectoryName(fileName), Path.GetFileNameWithoutExtension(fileName));
      if (!File.Exists(destinationFile)) {
        var sourceFile = MakeSourceFileName(lk);
        log.Append($"{DateTime.Now:s}  Copy {sourceFile} => {destinationFile}");
        File.Copy(sourceFile, destinationFile);
        log.AppendLine("   (success)");
      }
      log.Append($"{DateTime.Now:s}  Delete {fileName}");
      File.Delete(fileName);
      log.AppendLine("   (success)");
    }

    private LnkFile GetLnkFile(string fileName) {
      try {
        return Lnk.Lnk.LoadFile(fileName);
      } catch (Exception ex) {
        log.AppendLine($"{DateTime.Now:s}  Error parsing {fileName}: {ex.Message}");
        return null;
      }
    }


    private string MakeSourceFileName(LnkFile lk) {
      if (string.IsNullOrEmpty(lk.LocalPath))
        return Path.Combine(lk.NetworkShareInfo.NetworkShareName, lk.CommonPath);
      else return Path.Combine(lk.LocalPath, lk.CommonPath);
    }
  }
}
