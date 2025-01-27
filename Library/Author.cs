namespace Library;
public class Author
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Email { get; set; }
    public bool HasCar { get; set; }

    public Author (string Name, int Age, string Email, bool HasCar)
    {
        this.Name = Name;
        this.Age = Age;
        this.Email = Email;
        this.HasCar = true;
    }
}
