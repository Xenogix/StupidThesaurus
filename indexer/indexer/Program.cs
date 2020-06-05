using System;
using System.Collections.Generic;
using System.IO;

namespace indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager manager = new FileManager();
            while (true)
            {
                List<IndexedFile> list = manager.GetAllFilesFromFolder(Console.ReadLine(), true);
                Console.WriteLine("\n\n\n{0} fichiers indexés.", list.Count);
            }
        }
    }
    public class IndexedFile
    {
        FileManager.FileType filType;
        string filDirectory;
        string filName;
        

        public IndexedFile(FileManager.FileType filType, string filDirectory, string filName)
        {
            this.filType = filType;
            this.filDirectory = filDirectory;
            this.filName = filName;
            Console.WriteLine(filType + ", " + filDirectory + ", " + filName);
        }
    }
    public class FileManager
    {
        public enum FileType
        {
            Readable = 1,
            Unreadable = 2,
            Directory = 3
        }
        public List<IndexedFile> GetAllFilesFromFolder(string root, bool searchSubfolders)
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
                    string[] filesInCurrent = System.IO.Directory.GetFiles(currentFolder, ".", System.IO.SearchOption.TopDirectoryOnly);
                    
                    foreach (var item in filesInCurrent)
                    {
                        string extension = null;
                        string fileName = item.Split("\\")[item.Split("\\").Length - 1];
                        if(item.Contains("."))
                        {
                            extension = item.Split('.')[1];
                        }
                        Console.WriteLine(item);
                        if( extension== "txt" || extension == "csv" || extension == "pdf" || extension == "png" || extension == "jpg" || extension == "docx")
                        {
                            files.Add(new IndexedFile(FileType.Readable, item, fileName));
                        }
                        else if (extension==null)
                        {
                            files.Add(new IndexedFile(FileType.Directory, item, fileName));
                        }
                        else
                        {
                            files.Add(new IndexedFile(FileType.Unreadable, item, fileName));
                        }
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
                catch
                {
                    // Do Nothing
                }
            }
            return files;
        }
    }
}
