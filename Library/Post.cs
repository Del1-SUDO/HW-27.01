namespace Library;
public class Post
{
    public string Title { get; set; } 
    public string Author { get; set; }
    public DateTime Date { get; set; }
    public int Likes { get; set; }

    public Post(string title, string author, DateTime date, int likes)
    {
        Title = title;
        Author = author;
        Date = date;
        Likes = likes;
    }
}
