using System;
using System.Collections.Generic;

namespace FirstApp
{
    class Folder
    {
        public string Name { get; set; }

        public Folder(string name)
        {
            Name = name;
        }
        public List<string> Files { get; set; } = new List<string>();

        public void AddFile(string name)
        {
            if (!Files.Contains(name))
                Files.Add(name);
        }
    }
}
