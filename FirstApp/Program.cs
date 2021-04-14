using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FirstApp
{
    class Program
    {
        const string SettingsFileName = @"/Users/admin/Desktop/BinaryFile.bin";
        static void Main(string[] args)
        {
            // объект для сериализации
            var person = new Pet("Rex", 2);
            Console.WriteLine("Объект создан");

            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (var fs = new FileStream("myPets.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, person);
                Console.WriteLine("Объект сериализован");
            }
            // десериализация
            using (var fs = new FileStream("myPets.dat", FileMode.OpenOrCreate))
            {
                var newPet = (Pet)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {newPet.Name} --- Возраст: {newPet.Age}");
            }
            Console.ReadLine();
        }

        Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();
        static void WriteValues()
        {
            // Создаем объект BinaryWriter и указываем, куда будет направлен поток данных
            using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Open)))
            {
                // записываем данные
                writer.Write($"Файл изменен {DateTime.Now} на компьютере с ОС {Environment.OSVersion}");
            }
        }

        static void ReadValues()
        {
            float FloatValue;
            string StringValue;
            int IntValue;
            bool BooleanValue;

            if (File.Exists(SettingsFileName))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных.
                    // FloatValue = reader.ReadSingle();
                    StringValue = reader.ReadString();
                    // IntValue = reader.ReadInt32();
                    // BooleanValue = reader.ReadBoolean();
                }

                Console.WriteLine("Из файла считано:");

                // Console.WriteLine("Дробь: " + FloatValue);
                Console.WriteLine(StringValue);
                //Console.WriteLine("Целое: " + IntValue);
                //Console.WriteLine("Булево значение " + BooleanValue);
            }
        }
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
