// See https://aka.ms/new-console-template for more information
using EventProject;
 
var list = new List<object>
{
	1, 2, 3, 4, 5, 6, 7, 8, 9, 100, 11, 12, 13, 14, 15, 16, 17, 18, 19
};
Console.WriteLine("\nЗадание 1: вывести максимальный элемент");
Console.WriteLine(Searcher.GetMax<object>(list, Searcher.TTOFloat<object>));
Console.WriteLine("\nЗадание 2: вывести все файлы каталога, введите e для остановки");
new FileSearch().ListFilesInCatalog(Directory.GetCurrentDirectory());
