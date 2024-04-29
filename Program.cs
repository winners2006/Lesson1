using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

delegate void MyDelegate();

namespace ConsoleApp27
{
    class Program
    {

        static void Main(string[] args)
        {
			Console.WriteLine("Введите путь к папке для поиска:");
			string directoryPath = Console.ReadLine();

			while (!Directory.Exists(directoryPath))
			{
				Console.WriteLine("Указанный путь не существует. Попробуйте еще раз:");
				directoryPath = Console.ReadLine();
			}

			Console.WriteLine("Введите расширение файлов (без точки, например, txt):");
			string fileExtension = Console.ReadLine();

			while (string.IsNullOrWhiteSpace(fileExtension))
			{
				Console.WriteLine("Расширение не может быть пустым. Попробуйте еще раз:");
				fileExtension = Console.ReadLine();
			}

			Console.WriteLine("Введите текст для поиска:");
			string searchText = Console.ReadLine();

			while (string.IsNullOrWhiteSpace(searchText))
			{
				Console.WriteLine("Текст для поиска не может быть пустым. Попробуйте еще раз:");
				searchText = Console.ReadLine();
			}

			FileSearcher searcher = new FileSearcher(directoryPath, fileExtension, searchText);
			searcher.Search();

			Console.WriteLine("Поиск завершен.");
			Console.ReadLine();
		}
    }

}