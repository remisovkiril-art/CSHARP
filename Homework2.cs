//using System;
//using System.Linq;
//namespace CSHARP
//{
//    class Phone
//    {
//        public string Name { get; set; }
//        public string Manufacturer { get; set; }
//        public decimal Price { get; set; }
//        public DateTime ReleaseDate { get; set; }
//        public Phone(string name, string manufacturer, decimal price, DateTime releaseDate)
//        {
//            Name = name;
//            Manufacturer = manufacturer;
//            Price = price;
//            ReleaseDate = releaseDate;
//        }
//        public void Show()
//        {
//            Console.WriteLine($"Модель: {Name}");
//            Console.WriteLine($"Производитель: {Manufacturer}");
//            Console.WriteLine($"Цена: {Price}");
//            Console.WriteLine($"Дата выпуска: {ReleaseDate.ToShortDateString()}");
//            Console.WriteLine();
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            Phone[] phones =
//            {
//                new Phone("Galaxy S22", "Samsung", 800, new DateTime(2022, 2, 1)),
//                new Phone("iPhone 11", "Apple", 500, new DateTime(2019, 9, 10)),
//                new Phone("Redmi Note 10", "Xiaomi", 250, new DateTime(2021, 3, 5)),
//                new Phone("iPhone 15", "Apple", 1100, new DateTime(2023, 9, 15)),
//                new Phone("Galaxy A52", "Samsung", 400, new DateTime(2021, 1, 20))
//            };
//            Console.WriteLine("Всего телефонов: " + phones.Count());
//            Console.WriteLine("Телефонов дороже 100: " +
//                phones.Count(p => p.Price > 100));
//            Console.WriteLine("Телефонов с ценой от 400 до 700: " +
//                phones.Count(p => p.Price >= 400 && p.Price <= 700));
//            string manufacturer = "Apple";
//            Console.WriteLine($"Телефонов производителя {manufacturer}: " +
//                phones.Count(p => p.Manufacturer == manufacturer));
//            Phone minPricePhone = phones.MinBy(p => p.Price);
//            Console.WriteLine("\nТелефон с минимальной ценой:");
//            minPricePhone.Show();
//            Phone maxPricePhone = phones.MaxBy(p => p.Price);
//            Console.WriteLine("Телефон с максимальной ценой:");
//            maxPricePhone.Show();
//            Phone oldestPhone = phones.MinBy(p => p.ReleaseDate);
//            Console.WriteLine("Самый старый телефон:");
//            oldestPhone.Show();
//            Phone newestPhone = phones.MaxBy(p => p.ReleaseDate);
//            Console.WriteLine("Самый новый телефон:");
//            newestPhone.Show();
//            decimal averagePrice = phones.Average(p => p.Price);
//            Console.WriteLine("Средняя цена телефона: " + averagePrice);
//        }
//    }
//}