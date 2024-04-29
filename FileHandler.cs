using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class FileHandler
	{
		private string filePath;
		private string searchText;

		public FileHandler(string filePath, string searchText)
		{
			this.filePath = filePath;
			this.searchText = searchText;
		}

		public void Search()
		{
			try
			{
				string fileContent = File.ReadAllText(filePath);
				if (fileContent.Contains(searchText))
				{
					Console.WriteLine($"Найдено совпадение в файле: {filePath}");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка при чтении файла {filePath}: {ex.Message}");
			}
		}
	}
}
