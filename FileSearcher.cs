using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class FileSearcher
	{
		private string directoryPath;
		private string fileExtension;
		private string searchText;

		public FileSearcher(string directoryPath, string fileExtension, string searchText)
		{
			this.directoryPath = directoryPath;
			this.fileExtension = fileExtension;
			this.searchText = searchText;
		}

		public void Search()
		{
			try
			{
				string[] files = Directory.GetFiles(directoryPath, $"*.{fileExtension}", SearchOption.AllDirectories);
				List<Task> tasks = new List<Task>();

				foreach (string file in files)
				{
					FileHandler fileHandler = new FileHandler(file, searchText);
					Task task = Task.Run(() => fileHandler.Search());

					tasks.Add(task);
				}

				Task.WaitAll(tasks.ToArray());
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Ошибка при поиске файлов: {ex.Message}");
			}
		}
	}
}
