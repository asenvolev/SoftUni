using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoftFirstPart
{
    public static class IOManager
    {
        
        public static void TraverseDirectory(int depth)
        {
            OutputWriter.WriteEmptyLine();
            int initialIdentation = SessionData.CurrentPath.Split('\\').Length;
            var subFolders = new Queue<string>();
            subFolders.Enqueue(SessionData.CurrentPath);
            while (subFolders.Count!=0)
            {
                string currentPath = subFolders.Dequeue();
                int identation = currentPath.Split('\\').Length - initialIdentation;
                string nameFormat = string.Format($"{new string('-', identation)}{currentPath}");

                if (depth - identation < 0)
                {
                    break;
                }

                OutputWriter.WriteMessageOnNewLine(nameFormat);

                try
                {
                    foreach (var file in Directory.GetFiles(currentPath))
                    {
                        int indexOfLastFlash = file.LastIndexOf("\\");
                        string fileName = file.Substring(indexOfLastFlash);
                        OutputWriter.WriteMessageOnNewLine(new string('-', indexOfLastFlash) + fileName);
                    }

                    foreach (var directoryPath in Directory.GetDirectories(currentPath))
                    {
                        subFolders.Enqueue(directoryPath);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnauthorizedAccessException);
                }
                
            }
        }

        public static void CreateDirectoryInCurrentFolder(string name)
        {
            string path = SessionData.CurrentPath + "\\" + name;
            try
            {
                Directory.CreateDirectory(path);
            }
            catch (ArgumentException)
            {
                OutputWriter.DisplayException(ExceptionMessages.ForbiddenSymbolsContainedInName);
            }
        }
        public static void ChangeCurrentDirectoryRelative(string relativePath)
        {
            if (relativePath == "..")
            {
                try
                {
                    string currentPath = SessionData.CurrentPath;
                    int indexOfSlash = currentPath.LastIndexOf("\\");
                    string newPath = currentPath.Substring(0, indexOfSlash);
                    SessionData.CurrentPath = newPath;
                }
                catch (ArgumentOutOfRangeException)
                {
                    OutputWriter.DisplayException(ExceptionMessages.UnableToGoHigherInPartitionHierarchy);
                }
            }
            else
            {
                string currentPath = SessionData.CurrentPath;
                currentPath += "\\" + relativePath;
                ChangeCurrentDirectoryAbsolute(currentPath);
            }
        }

        public static void ChangeCurrentDirectoryAbsolute(string absolutePath)
        {
            if (!Directory.Exists(absolutePath))
            {
                OutputWriter.DisplayException(ExceptionMessages.InvalidPath);
            }
            else
            {
                SessionData.CurrentPath = absolutePath;
            }
        }
    }
}
