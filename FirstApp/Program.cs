using System;
using System.Collections.Generic;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder folder = new Folder("НоваяПапка");
            folder.AddFile("Документ1");
        }
        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public void FolderAdd(string FolderName)
        {
            Folders.Add(FolderName, new Folder(FolderName));
            Console.WriteLine("Папка создана.");
        }
    }
}

