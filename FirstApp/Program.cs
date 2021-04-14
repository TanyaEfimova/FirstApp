using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // получим системные диски
            DriveInfo[] drives = DriveInfo.GetDrives();

            Console.WriteLine("Диски:");
            // Пробежимся по дискам и выведем их свойства
            foreach (DriveInfo drive in drives.Where(d => d.DriveType == DriveType.Fixed))
            {
                WriteDriveInfo(drive);
                DirectoryInfo root = drive.RootDirectory;
                var folders = root.GetDirectories();

                Console.WriteLine();
            }
            Console.WriteLine();

            GetCatalogs(); //   Вызов метода получения директорий

            #region Создание новой директории в каталоге текущего пользователя:

            DirectoryInfo dirInfo = new DirectoryInfo(@"/Users/admin");

            if (!dirInfo.Exists)
                dirInfo.Create();

            dirInfo.CreateSubdirectory("NewFolder");
            #endregion

            GetCountCatalogs();

            //Получение информации о каталоге: 
            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
        }
        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public static void WriteDriveInfo(DriveInfo di)
        {
            Console.WriteLine($"Название: {di.Name}");
            Console.WriteLine($"Тип: {di.DriveType}");
            if (di.IsReady)
            {
                Console.WriteLine($"Объем: {di.TotalSize}");
                Console.WriteLine($"Свободно: {di.TotalFreeSpace}");
                Console.WriteLine($"Метка: {di.VolumeLabel}");
            }
        }

        public static void WriteFolderInfo(DirectoryInfo[] folders)
        {
            Console.WriteLine("Папки:");
            foreach (var folder in folders)
            {
                Console.WriteLine(folder.Name);
            }
        }

        public void FolderAdd(string FolderName)
        {
            Folders.Add(FolderName, new Folder(FolderName));
            Console.WriteLine("Папка создана.");
        }

        static void GetCatalogs()
        {
            string dirName = @"/"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);
            }
        }

        static void GetCountCatalogs()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(@"/" /* Или С:\\ для Windows */ );
                if (dirInfo.Exists)
                {
                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }

                DirectoryInfo newDirectory = new DirectoryInfo(@"/NewFolder");
                if (!newDirectory.Exists)
                    newDirectory.Create();

                Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            DeleteCatalog(@"/Users/admin/NewFolder");
            DeleteCatalog(@"/NewFolder");

            //Перемещение каталога:
            DirectoryInfo directInfo = new DirectoryInfo("/Users/admin/Doctor Web");
            string newPath = "/Users/admin/Doctor Web New";

            if (directInfo.Exists && !Directory.Exists("/Users/admin/Doctor Web New")) ;
            directInfo.MoveTo(newPath);

            try
            {
                DirectoryInfo drInfo = new DirectoryInfo(@"/Users/admin/Desktop/testFolder");
                string trashPath = "c:/$Recycle.Bin/testFolder";

                drInfo.MoveTo(trashPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void DeleteCatalog(string path)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                dirInfo.Delete(true); // Удаление со всем содержимым
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

