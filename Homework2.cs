using System;
namespace CSHARP
{
    internal class Homework2
    {
        // Задание 5 
        class Journal
        {
            private string name;
            private int foundationYear;
            private string description;
            private string phone;
            private string email;
            public void Input()
            {
                Console.Write("Введите название журнала: ");
                name = Console.ReadLine();
                Console.Write("Введите год основания: ");
                foundationYear = int.Parse(Console.ReadLine());
                Console.Write("Введите описание журнала: ");
                description = Console.ReadLine();
                Console.Write("Введите контактный телефон: ");
                phone = Console.ReadLine();
                Console.Write("Введите контактный email: ");
                email = Console.ReadLine();
            }
            public void Output()
            {
                Console.WriteLine("\nИнформация о журнале");
                Console.WriteLine($"Название: {name}");
                Console.WriteLine($"Год основания: {foundationYear}");
                Console.WriteLine($"Описание: {description}");
                Console.WriteLine($"Телефон: {phone}");
                Console.WriteLine($"Email: {email}");
            }
            public string GetName()
            {
                return name;
            }
            public void SetName(string value)
            {
                name = value;
            }
        }
        // Задание 6
        class Shop
        {
            private string name;
            private string address;
            private string description;
            private string phone;
            private string email;
            public void Input()
            {
                Console.Write("Введите название магазина: ");
                name = Console.ReadLine();

                Console.Write("Введите адрес магазина: ");
                address = Console.ReadLine();

                Console.Write("Введите описание профиля магазина: ");
                description = Console.ReadLine();

                Console.Write("Введите контактный телефон: ");
                phone = Console.ReadLine();

                Console.Write("Введите контактный email: ");
                email = Console.ReadLine();
            }

            public void Output()
            {
                Console.WriteLine("\nИнформация о магазине");
                Console.WriteLine($"Название: {name}");
                Console.WriteLine($"Адрес: {address}");
                Console.WriteLine($"Описание: {description}");
                Console.WriteLine($"Телефон: {phone}");
                Console.WriteLine($"Email: {email}");
            }
            public string GetAddress()
            {
                return address;
            }

            public void SetAddress(string value)
            {
                address = value;
            }
        }
        static void Main()
        {
            Journal journal = new Journal();
            Console.WriteLine("Ввод данных для журнала:");
            journal.Input();
            journal.Output();
            Shop shop = new Shop();
            Console.WriteLine("\nВвод данных для магазина:");
            shop.Input();
            shop.Output();
        }
    }
}
