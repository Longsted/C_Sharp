namespace musicstore.Models;

public class Book: Product
{
    private string author;

    public Book(string title, decimal price, string imageUrl, string author, string publisher, short published, string isbn) : base(title, price, imageUrl)
    {
        this.author = author;
        this.publisher = publisher;
        this.published = published;
        this.isbn = isbn;
    }

    public Book(string title, decimal price, string author, string publisher, short published, string isbn) : base(title, price)
    {
        this.author = author;
        this.publisher = publisher;
        this.published = published;
        this.isbn = isbn;
    }

    public Book(string author,string title, decimal price , short published) : base(title, price)
    {
        this.author = author;
        this.published = published;
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    
    private string publisher;

    public string Publisher
    {
        get { return publisher; }
        set { publisher = value; }
    }
    
    private short published;

    public short Published
    {
        get { return published; }
        set { published = value; }
    }
    private string isbn;

    public string ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

}