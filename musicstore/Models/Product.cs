namespace musicstore.Models;

public class Product
{
    private string title;

    public string Title
    {
        get => title;
        set => title = value ?? throw new ArgumentNullException(nameof(value));
    }

    private decimal price;

    public decimal Price
    {
        get => price;
        set => price = value < 0 ? 0 : value;
    }
    private string imageUrl;

    public string ImageUrl
    {
        get => imageUrl;
        set => imageUrl = value;
    }

    public Product(string title, decimal price, string imageUrl)
    {
        this.title = title;
        this.price = price;
        this.imageUrl = imageUrl;
    }

    public Product(string title, decimal price)
    {
        this.title = title;
        this.price = price;
    }
}