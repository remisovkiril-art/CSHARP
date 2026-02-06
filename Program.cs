//using System;
//using System.IO;
//using System.Text.Json;
//namespace CSHARP
//{
//    class Magazine
//    {
//        public string Title { get; set; }
//        public string Publisher { get; set; }
//        public DateTime ReleaseDate { get; set; }
//        public int Pages { get; set; }
//        public void Input()
//        {
//            Console.Write("Введите название журнала: ");
//            Title = Console.ReadLine();
//            Console.Write("Введите издательство: ");
//            Publisher = Console.ReadLine();
//            Console.Write("Введите дату выпуска (год -, месяц - и дата): ");
//            ReleaseDate = DateTime.Parse(Console.ReadLine());
//            Console.Write("Введите количество страниц: ");
//            Pages = int.Parse(Console.ReadLine());
//        }
//        public void Show()
//        {
//            Console.WriteLine("\nИнформация о журнале:");
//            Console.WriteLine("Название: " + Title);
//            Console.WriteLine("Издательство: " + Publisher);
//            Console.WriteLine("Дата выпуска: " + ReleaseDate.ToShortDateString());
//            Console.WriteLine("Количество страниц: " + Pages);
//        }
//    }
//    class Program
//    {
//        static string filePath = "magazine.json";
//        static void Save(Magazine magazine)
//        {
//            string json = JsonSerializer.Serialize(magazine, new JsonSerializerOptions
//            {
//                WriteIndented = true
//            });
//            File.WriteAllText(filePath, json);
//            Console.WriteLine("\nЖурнал сохранен в файл");
//        }
//        static Magazine Load()
//        {
//            if (!File.Exists(filePath))
//            {
//                Console.WriteLine("Файл не найден.");
//                return null;
//            }
//            string json = File.ReadAllText(filePath);
//            Magazine mag = JsonSerializer.Deserialize<Magazine>(json);
//            Console.WriteLine("Журнал загружен из файла");
//            return mag;
//        }
//        static void Main()
//        {
//            Magazine magazine = new Magazine();
//            magazine.Input();
//            magazine.Show();
//            Save(magazine);
//            Magazine loadedMagazine = Load();
//            if (loadedMagazine != null)
//                loadedMagazine.Show();
//            Console.WriteLine("\nРабота программы завершена.");
//        }
//    }
//}