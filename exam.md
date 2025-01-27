# Экзаменационное задание

Создайте программу, состоящую из двух проектов:

## Часть 1: ClassLibrary проект

1. Создайте классы в отдельном файле.
2. Создайте класс `Management`, который будет управлять всеми остальными классами. В нём должны быть все методы которые требуется в заданий.

## Часть 2: Console проект

1. В файле Program.cs:
   - Создайте объект класса `Management`
   - Через него работайте со всеми методами
   - Создайте меню для пользователя



## Класс 1: Author 
```csharp
public class Author
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public bool HasCar { get; set; }
}
```

### Задача 1
Создайте массив из 3 авторов и выведите информацию о каждом в формате:
"Имя автора: [Name], Возраст: [Age], Email: [Email]"

**Пояснение:**
- Метод: `void PrintAuthors()`
- Параметры: нет
- Тип возвращения: void (просто вывод в консоль)

**Пример работы:**
```
Создаём массив:
Author[] authors = new Author[3];
authors[0] = new Author { Name = "John", Age = 25, Email = "john@mail.com" };
...

Вывод в консоль:
Имя автора: John, Возраст: 25, Email: john@mail.com
Имя автора: Alice, Возраст: 30, Email: alice@mail.com
Имя автора: Bob, Возраст: 20, Email: bob@mail.com
```

### Задача 2
Найдите и выведите всех авторов:
- Которым больше 25 лет
- У которых есть машина

**Пояснение:**
- Метод: `void FindAuthors(Author[] authors)`
- Параметры: массив авторов
- Тип возвращения: void (вывод в консоль)

**Пример работы:**
```
Вход:
authors = [
    { Name: "John", Age: 30, HasCar: true },
    { Name: "Alice", Age: 20, HasCar: true },
    { Name: "Bob", Age: 27, HasCar: true }
]

Вывод в консоль:
Найдены авторы:
1. John (30 лет)
2. Bob (27 лет)
```

### Задача 3
Создайте метод поиска автора по email и выведите его данные.

**Пояснение:**
- Метод: `Author FindAuthorByEmail(Author[] authors, string email)`
- Параметры: 
  - authors: массив авторов
  - email: email для поиска
- Тип возвращения: Author (найденный автор или null)

**Пример работы:**
```
Вход:
email = "john@mail.com"

Вывод в консоль:
Найден автор:
Имя: John
Возраст: 25
Есть машина: Да
```

## Класс 2: Car 
```csharp
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public string Type { get; set; }
}
```

### Задача 4
Создайте метод AddCar для добавления машины в массив:
- Проверить, что год выпуска не больше текущего
- Проверить, что цена больше 0
- Тип должен быть только Sedan, SUV или Sport

**Пояснение:**
- Метод: `bool AddCar(Car[] cars, Car newCar)`
- Параметры:
  - cars: массив машин
  - newCar: новая машина для добавления
- Тип возвращения: bool (успешно добавлена или нет)

**Пример работы:**
```
Вход:
newCar = { Brand: "Toyota", Model: "Camry", Year: 2025, Price: -100, Type: "Truck" }

Вывод в консоль:
Ошибка: некорректные данные машины
Результат: false

Вход:
newCar = { Brand: "BMW", Model: "X5", Year: 2023, Price: 50000, Type: "SUV" }

Вывод в консоль:
Машина успешно добавлена
Результат: true
```

### Задача 5
Создайте метод GetCarsByFilter для поиска машин по параметрам:
- Поиск по диапазону цен (от/до)
- Поиск по диапазону годов (от/до)
- Поиск по типу машины

**Пояснение:**
- Метод: `Car[] GetCarsByFilter(Car[] cars, double minPrice, double maxPrice, int minYear, int maxYear, string type)`
- Параметры:
  - cars: массив машин
  - minPrice, maxPrice: диапазон цен
  - minYear, maxYear: диапазон годов
  - type: тип машины
- Тип возвращения: Car[] (массив найденных машин)

**Пример работы:**
```
Вход:
minPrice = 20000
maxPrice = 50000
minYear = 2020
maxYear = 2023
type = "SUV"

Вывод в консоль:
Найдены машины:
1. BMW X5 (2022) - 45000$
2. Toyota RAV4 (2021) - 35000$
```

### Задача 6
Создайте метод для сравнения двух машин:
- Вывести более дорогую
- Вывести более новую
- Вывести, одинакового ли они типа

**Пояснение:**
- Метод: `void CompareCars(Car car1, Car car2)`
- Параметры:
  - car1, car2: машины для сравнения
- Тип возвращения: void (вывод в консоль)

**Пример работы:**
```
Вход:
car1 = { Brand: "BMW", Model: "X5", Year: 2022, Price: 50000, Type: "SUV" }
car2 = { Brand: "Toyota", Model: "Camry", Year: 2023, Price: 35000, Type: "Sedan" }

Вывод в консоль:
Более дорогая: BMW X5 (50000$)
Более новая: Toyota Camry (2023)
Машины разного типа
```

### Задача 7
Создайте метод для работы с массивом машин:
- Создать массив из 5 машин
- Подсчитать среднюю цену всех машин
- Вывести все машины дороже средней цены

**Пояснение:**
- Метод: `void AnalyzeCars(Car[] cars)`
- Параметры: массив машин
- Тип возвращения: void (вывод в консоль)

**Пример работы:**
```
Вход:
cars = [
    { Brand: "BMW", Price: 50000 },
    { Brand: "Toyota", Price: 30000 },
    { Brand: "Honda", Price: 25000 },
    { Brand: "Mercedes", Price: 60000 },
    { Brand: "Kia", Price: 20000 }
]

Вывод в консоль:
Средняя цена: 37000$
Машины дороже средней:
1. Mercedes - 60000$
2. BMW - 50000$
```

## Класс 3: Post 
```csharp
public class Post
{
    public string Title { get; set; }
    public Author Author { get; set; }
    public Car Car { get; set; }
    public string Description { get; set; }
    public int Likes { get; set; }
}
```

### Задача 8
Создайте метод GetPostInfo для анализа постов:
- Найти посты с лайками больше 10
- Посчитать общее количество лайков у всех постов
- Найти пост с максимальным количеством лайков

**Пояснение:**
- Метод: `void GetPostInfo(Post[] posts)`
- Параметры: массив постов
- Тип возвращения: void (вывод в консоль)

**Пример работы:**
```
Вход:
posts = [
    { Title: "Post1", Likes: 15 },
    { Title: "Post2", Likes: 5 },
    { Title: "Post3", Likes: 20 }
]

Вывод в консоль:
Посты с >10 лайками:
- Post1 (15 лайков)
- Post3 (20 лайков)
Общее количество лайков: 40
Самый популярный пост: Post3 (20 лайков)
```

### Задача 9
Создайте метод SearchPosts для поиска постов:
- По имени автора
- По модели машины
- С количеством лайков больше указанного

**Пояснение:**
- Метод: `Post[] SearchPosts(Post[] posts, string authorName, string carModel, int minLikes)`
- Параметры:
  - posts: массив постов
  - authorName: имя автора
  - carModel: модель машины
  - minLikes: минимальное количество лайков
- Тип возвращения: Post[] (массив найденных постов)

**Пример работы:**
```
Вход:
authorName = "John"
carModel = "X5"
minLikes = 10

Вывод в консоль:
Найдены посты:
1. "BMW X5 Review" от John (15 лайков)
2. "X5 vs Range Rover" от John (12 лайков)
```

### Задача 10
Создайте словарь (Dictionary), где:
1. Ключ - имя автора
2. Значение - количество его постов
И методы:
- Добавить пост автору (увеличить счётчик)
- Показать количество постов у каждого автора

**Пояснение:**
- Методы: 
  1. `void AddPost(string authorName)`
  2. `void ShowStatistics()`
- Параметры для AddPost: имя автора
- Тип возвращения: void (вывод в консоль)

**Пример работы:**
```
Добавление постов:
AddPost("John")
AddPost("John")
AddPost("Alice")

Вывод статистики:
Статистика постов:
John: 2 поста
Alice: 1 пост

---

