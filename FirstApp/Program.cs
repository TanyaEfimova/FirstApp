using System;

namespace FirstApp
{
    class Program
    {

        static void Main(string[] args)
        {
            IFile file = new FileInfo();
            IBinaryFile binaryFile = new FileInfo();
            FileInfo fileInfo = new FileInfo();

            file.ReadFile();

            binaryFile.ReadFile();
            binaryFile.OpenBinaryFile();

            fileInfo.Search("Строка для поиска");

            Console.ReadKey();
        }
    }

    public interface IFile
    {
        void ReadFile();
    }

    public interface IBinaryFile
    {
        void ReadFile();
        void OpenBinaryFile();
    }

    public class FileInfo : IFile, IBinaryFile
    {
        void IBinaryFile.OpenBinaryFile()
        {
            Console.WriteLine("Открываем бинарный файл...");
        }

        void IFile.ReadFile()
        {
            Console.WriteLine("Читаем текстовый файл");
        }

        void IBinaryFile.ReadFile()
        {
            Console.WriteLine("Читаем бинарный файл");
        }

        public void Search(string text)
        {
            Console.WriteLine("Начался поиск текста в файле...");
        }
    }
}
