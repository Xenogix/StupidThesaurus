﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesaurusAdministrator
{
    public class FileManager
    {
        public enum FileType
        {
            Readable = 1,
            Unreadable = 2,
            Directory = 3
        }
        public List<IndexedFile> GetAllFilesFromFolder(string root, bool searchSubfolders, AdminConsole console)
        {
            List<IndexedFile> list = new List<IndexedFile>();
            Queue<string> folders = new Queue<string>();
            List<IndexedFile> files = new List<IndexedFile>();
            folders.Enqueue(root);

            while (folders.Count != 0)
            {
                string currentFolder = folders.Dequeue();

                try
                {
                    files.Add(new IndexedFile(FileType.Directory, currentFolder, currentFolder.Substring(currentFolder.LastIndexOf("\\") + 1, currentFolder.Length - currentFolder.LastIndexOf("\\") - 1)));
                }
                catch { }

                try
                {
                    string[] filesInCurrent = System.IO.Directory.GetFiles(currentFolder, ".", System.IO.SearchOption.TopDirectoryOnly);

                    foreach (var item in filesInCurrent)
                    {
                        string extension = null;
                        string fileName = item.Split('\\')[item.Split('\\').Length - 1];
                        if (item.Contains("."))
                        {
                            extension = item.Split('.')[1];
                        }
                        Console.WriteLine(item);
                        if (extension == "txt" || extension == "csv" || extension == "pdf" || extension == "png" || extension == "jpg" || extension == "docx")
                        {
                            files.Add(new IndexedFile(FileType.Readable, item, fileName));
                        }
                        else if (extension == null)
                        {
                            files.Add(new IndexedFile(FileType.Directory, item, fileName));
                        }
                        else
                        {
                            files.Add(new IndexedFile(FileType.Unreadable, item, fileName));
                        }

                        console.Write(files.Last().filName + " " + files.Last().filType);
                    }
                }
                catch
                {

                }
                try
                {
                    if (searchSubfolders)
                    {
                        string[] foldersInCurrent = System.IO.Directory.GetDirectories(currentFolder, ".", System.IO.SearchOption.TopDirectoryOnly);
                        foreach (string _current in foldersInCurrent)
                        {
                            folders.Enqueue(_current);
                        }
                    }
                }
                catch {}
            }
            return files;
        }
    }
}
