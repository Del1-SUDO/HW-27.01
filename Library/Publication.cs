namespace Library;
public class Publication
{
    public string Title { get; set; }  // Название публикации
    public string Author { get; set; } // Автор публикации
    public string CarModel { get; set; } // Модель машины
    public DateTime Date { get; set; } // Дата публикации
    public int Likes { get; set; }    // Количество лайков

    public Publication(string title, string author, string carModel, DateTime date, int likes)
    {
        Title = title;
        Author = author;
        CarModel = carModel;
        Date = date;
        Likes = likes;
    }
}