using System;
using System.Collections.Generic;

namespace FirstApp
{
    class Folder
    {
        public List<string> Files { get; set; } = new List<string>();

        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public void FolderAdd(string FolderName)
        {
            Folders.Add(FolderName, new Folder());
            Console.WriteLine("Папка создана.");
        }
    }
}
