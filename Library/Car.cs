namespace Library;
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double Price { get; set; }
    public string Type { get; set; }

    public Car (string Brand, string Model, int Year, double Price, string Type)
    {
        this.Brand = Brand;
        this.Model = Model;
        this.Year = Year;
        this.Price = Price;
        this.Type = Type;
    }   
}
