namespace Library;
public class Management
{
    public void PrintAuthors() //1
    {
        List<Author> MyList = new List<Author>();
        Author set = new Author("Siyovush", 20, "Siyovush@gmail.com", false);
        Author set2 = new Author("Kurbon", 19, "Kurbon@gmail.com", false);
        Author set3 = new Author("Said", 26, "Said@gmail.com", false);
        MyList.Add(set);
        MyList.Add(set2);
        MyList.Add(set3);
        
        foreach (var item in MyList)
        {
            System.Console.WriteLine($"Имя автора: {item.Name}, Возраст: {item.Age}, Email: {item.Email}");
        }
    }

    public void FindAuthors() //2
    {
        List<Author> MyList = new List<Author>();
        Author set = new Author("Siyovush", 20, "Siyovush@gmail.com", true);
        Author set2 = new Author("Kurbon", 19, "Kurbon@gmail.com", true);
        Author set3 = new Author("Said", 26, "Said@gmail.com", false);
        MyList.Add(set);
        MyList.Add(set2);
        MyList.Add(set3);
        
        int cnt = 1;
        System.Console.WriteLine();
        foreach (var item in MyList)
        {
            if (item.Age > 25 && item.HasCar == true)
            {
                System.Console.WriteLine($"{cnt}. {item.Name} ({item.Age})");
                cnt++;
            }
        }
    }

    public void FindAuthorByEmail(string email) //3
    {
        List<Author> MyList = new List<Author>();
        Author set = new Author("Siyovush", 20, "Siyovush@gmail.com", true);
        Author set2 = new Author("Kurbon", 19, "Kurbon@gmail.com", true);
        Author set3 = new Author("Said", 26, "Said@gmail.com", false);
        MyList.Add(set);
        MyList.Add(set2);
        MyList.Add(set3);

        foreach (var item in MyList)
        {
            if (item.Email == email)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("Author is found!");
                System.Console.WriteLine($"Имя: {item.Name}");
                System.Console.WriteLine($"Возраст: {item.Age}");
                System.Console.WriteLine($"Машина: {item.HasCar}");
            }
        }
    }

    public bool AddCar(Car newCar) //4
    {
        List<Car> car = new List<Car>();
        Car set = new Car ("BMW", "M5", 2015, 44000, "Sport");
        Car set2 = new Car ("BMW", "M4", 2018, 56000, "SUV");
        Car set3 = new Car ("Opel", "Astra", 2018, 15000, "Sedan");
        car.Add(set);
        car.Add(set2);
        car.Add(set3);

        if (newCar.Year <= 2025 && newCar.Price > 0 && newCar.Type == "Sedan" || newCar.Type == "SUV" || newCar.Type == "Sport")
        {
            car.Add(newCar);
            return true;
        }
        else
        {
            return false;
        }
    }

    public void CompareCars(Cars car1, Cars car2) //6
    {
        System.Console.WriteLine();
        string result = "";

        if (car1.Price > car2.Price)
        {
            result += $"Более дорогая: {car1.Model} ({car1.Price}$)\n";
        }
        else if (car1.Price < car2.Price)
        {
            result += $"Более дорогая: {car2.Model} ({car2.Price}$)\n";
        }
        else
        {
            result += $"Обе машины стоят одинаково: {car1.Model} ({car1.Price}$) и {car2.Model} ({car2.Price}$)\n";
        }

        if (car1.Year > car2.Year)
        {
            result += $"Более новая: {car1.Model} ({car1.Year})\n";
        }
        else if (car1.Year < car2.Year)
        {
            result += $"Более новая: {car2.Model} ({car2.Year})\n";
        }
        else
        {
            result += $"Обе машины одинаково новы: {car1.Model} ({car1.Year}) и {car2.Model} ({car2.Year})\n";
        }

        if (car1.Type == car2.Type)
        {
            result += "Машины одного типа\n";
        }
        else
        {
            result += "Машины разного типа\n";
        }

        System.Console.WriteLine(result);
    }


    public void AnalyzeCars() //7
    {
        System.Console.WriteLine();
        List<Cars> cars = new List<Cars>
        {
            new Cars("BMW", "SUV", 2022, 50000),
            new Cars("Honda", "Sedan", 2020, 25000),
            new Cars("Mercedes", "SUV", 2023, 60000),
            new Cars("Ferrari", "Sport", 2019, 150000)
        };

        double totalPrice = 0;
        foreach (var car in cars)
        {
            totalPrice += car.Price;
        }
        double averagePrice = totalPrice / cars.Count;
        Console.WriteLine($"Средняя цена: {averagePrice}");

        Console.WriteLine("\nМашины дороже средней:");
        bool foundAboveAverage = false;
        int index = 1;
        foreach (var car in cars)
        {
            if (car.Price > averagePrice)
            {
                Console.WriteLine($"{index++}. {car.Model} - {car.Price}");
                foundAboveAverage = true;
            }
        }
        if (!foundAboveAverage)
        {
            Console.WriteLine("\nНет машин, дороже средней цены.");
        }

        Dictionary<string, List<Cars>> groupedCars = new Dictionary<string, List<Cars>>();
        foreach (var car in cars)
        {
            if (!groupedCars.ContainsKey(car.Type))
            {
                groupedCars[car.Type] = new List<Cars>();
            }
            groupedCars[car.Type].Add(car);
        }

        Console.WriteLine("\nГруппировка по типу:");
        foreach (var group in groupedCars)
        {
            Console.WriteLine($"{group.Key} ({group.Value.Count}):");
            foreach (var car in group.Value)
            {
                Console.WriteLine($"  - {car.Model} - {car.Price}");
            }
        }
    }

    public void GetPostInfo() //8
    {
        System.Console.WriteLine();
        List<Post> posts = new List<Post>
        {
            new Post("Post1", "John", new DateTime(2024, 1, 20), 15),
            new Post("Post2", "Jane", new DateTime(2024, 1, 21), 5),
            new Post("Post3", "Alice", new DateTime(2024, 1, 25), 20),
            new Post("Post4", "Bob", new DateTime(2024, 1, 26), 3),
        };

        Console.WriteLine("Посты с >10 лайками:");
        bool found = false;
        foreach (var post in posts)
        {
            if (post.Likes > 10)
            {
                Console.WriteLine($"- {post.Title} от {post.Author} ({post.Likes} лайков) - {post.Date.ToString("dd.MM.yyyy")}");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Нет постов с более чем 10 лайками.");
        }

        int totalLikes = 0;
        foreach (var post in posts)
        {
            totalLikes += post.Likes;
        }

        Console.WriteLine($"\nОбщее количество лайков: {totalLikes}");

        Post mostPopularPost = null;
        foreach (var post in posts)
        {
            if (mostPopularPost == null || post.Likes > mostPopularPost.Likes)
            {
                mostPopularPost = post;
            }
        }

        if (mostPopularPost != null)
        {
            Console.WriteLine($"Самый популярный пост: {mostPopularPost.Title} ({mostPopularPost.Likes} лайков)");
        }
    }
    
    public List<Publication> SearchPublications(string authorName, string carModel) //9
    {
        List<Publication> publications = new List<Publication>
        {
            new Publication("BMW X5 Review", "John", "BMW X5", new DateTime(2024, 1, 20), 15),
            new Publication("X5 vs Range Rover", "John", "BMW X5", new DateTime(2024, 1, 22), 12),
            new Publication("Mercedes Review", "Alice", "Mercedes", new DateTime(2024, 1, 23), 5),
            new Publication("Ferrari F8 Review", "John", "Ferrari F8", new DateTime(2024, 1, 24), 20),
            new Publication("Range Rover vs BMW", "Alice", "Range Rover", new DateTime(2024, 1, 25), 8)
        };

        List<Publication> result = new List<Publication>();

        foreach (var publication in publications)
        {
            if ((string.IsNullOrEmpty(authorName) || publication.Author.Contains(authorName, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(carModel) || publication.CarModel.Contains(carModel, StringComparison.OrdinalIgnoreCase)))
            {
                result.Add(publication);
            }
        }

        return result;
    }

    public void GetAuthorStatistics(List<Publication> publications) //10
    {
        Dictionary<string, int> authorStats = new Dictionary<string, int>();

        foreach (var publication in publications)
        {
            if (authorStats.ContainsKey(publication.Author))
            {
                authorStats[publication.Author]++;
            }
            else
            {
                authorStats[publication.Author] = 1;
            }
        }

        Console.WriteLine("\nСтатистика постов:");
        foreach (var author in authorStats)
        {
            string postWord = author.Value == 1 ? "пост" : "постов";
            Console.WriteLine($"{author.Key}: {author.Value} {postWord}");
        }
    }
}