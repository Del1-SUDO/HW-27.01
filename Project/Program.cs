using System;
using Library;
class Program
{
    static void Main(string[] args)
    {
        Management manage = new Management();
        manage.PrintAuthors();

        manage.FindAuthors();

        manage.FindAuthorByEmail("Siyovush@gmail.com");

        // System.Console.WriteLine();
        // System.Console.WriteLine("Adding a new car...");
        // System.Console.Write("Brand: ");
        // string Brand = Console.ReadLine();
        // System.Console.Write("Model: ");
        // string Model = Console.ReadLine();
        // System.Console.Write("Year: ");
        // int Year = int.Parse(Console.ReadLine());
        // System.Console.Write("Price: ");
        // double Price = double.Parse(Console.ReadLine());
        // System.Console.Write("Type: ");
        // string Type = Console.ReadLine();
        // Car car = new Car(Brand, Model, Year, Price, Type);
        // bool resut = manage.AddCar(car);
        // System.Console.Write(resut);

        System.Console.WriteLine();
        Cars set = new Cars ("BMW", "SUV", 2022, 45000);
        Cars set2 = new Cars ("Ferrari", "Sport", 2019, 150000);
        manage.CompareCars(set, set2);

        manage.AnalyzeCars();

        manage.GetPostInfo();


        List<Publication> foundPublications = manage.SearchPublications("John", "BMW X5");
        Console.WriteLine("\nНайдены публикации:");
        int index = 1;
        foreach (var publication in foundPublications)
        {
            Console.WriteLine($"{index++}. \"{publication.Title}\" от {publication.Author} ({publication.Likes} лайков) - {publication.Date.ToString("dd.MM.yyyy")}");
        }


        List<Publication> publications = new List<Publication>
        {
            new Publication("BMW X5 Review", "John", "BMW X5", new DateTime(2024, 1, 20), 15),
            new Publication("Mercedes Review", "Alice", "Mercedes", new DateTime(2024, 1, 23), 5),
            new Publication("Ferrari F8 Review", "John", "Ferrari F8", new DateTime(2024, 1, 24), 20),
            new Publication("Range Rover vs BMW", "Alice", "Range Rover", new DateTime(2024, 1, 25), 8),
            new Publication("BMW M5 Review", "Bob", "BMW", new DateTime(2024, 1, 30), 60)
        };
        manage.GetAuthorStatistics(publications);
    }
}