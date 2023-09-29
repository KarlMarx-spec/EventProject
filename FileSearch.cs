using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventProject
{
	
	public class FileArgs : EventArgs { }
	public class FileSearch
	{
		public delegate void EventHandler(string fileName);
		public event EventHandler FileFound;
		public void ListFilesInCatalog(string path)
		{
			FileFound += FileFoundHandler;
			var files = Directory.GetFiles(path);
			
			foreach (var file in files)
			{
				FileFound(file);
				var key = Console.ReadKey();
				if (key.Key == ConsoleKey.Escape)
				{
					return;
				}
			}
			Console.WriteLine("\nВсе файлы выведены");
		}

		private void FileFoundHandler(string fileName)
		{
			Console.WriteLine("Найден файл: " + fileName);
			Console.WriteLine("Нажмите любую кнопку для продолжения, esc для выхода");
		}
	}
}
