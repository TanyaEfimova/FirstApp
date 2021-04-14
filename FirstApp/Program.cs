using System;
using System.IO;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        public static FileInfo configFile = new FileInfo(@"SystemConfig.txt");
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives.Where(d => d.DriveType == DriveType.Fixed))
            {
                DirectoryInfo root = drive.RootDirectory;
                var folders = root.GetDirectories();

                Console.WriteLine($"Сканируем диск {drive.Name}...");

                using (StreamWriter sw = configFile.AppendText())
                {
                    WriteDriveInfo(sw, drive);
                    WriteFileInfo(sw, root);
                    WriteFolderInfo(sw, folders);
                }

                Console.WriteLine("Завершено");
                Console.WriteLine("_______________");
            }
        }


        public static void WriteDriveInfo(StreamWriter sw, DriveInfo di)
        {
            sw.WriteLine($"Название: {di.Name}");
            sw.WriteLine($"Тип: {di.DriveType}");
            if (di.IsReady)
            {
                sw.WriteLine($"Объем: {di.TotalSize}");
                sw.WriteLine($"Свободно: {di.TotalFreeSpace}");
                sw.WriteLine($"Метка: {di.VolumeLabel}");
            }
        }

        public static void WriteFolderInfo(StreamWriter sw, DirectoryInfo[] folders)
        {
            sw.WriteLine("Папки:");
            foreach (var folder in folders)
            {
                sw.WriteLine(folder.Name);
            }
        }

        public static void WriteFileInfo(StreamWriter sw, DirectoryInfo rootFolder)
        {
            sw.WriteLine("Файлы:");
            foreach (var file in rootFolder.GetFiles())
            {
                sw.WriteLine(file.Name + $" - {file.Length} байт");
            }
        }








    }
}
