using System;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Product mouse = new Product(123, "Mouse Gamer", 50.2, EProductType.Product);
      Console.WriteLine(mouse.Id);
      Console.WriteLine(mouse.Name);
      mouse.Name = "Mouse LED Full";
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
      Console.WriteLine(mouse.Type);
      Console.WriteLine((int)mouse.Type);
    }
  }

  struct Product
  {
    public Product(int id, string name, double price, EProductType type)
    {
      Id = id;
      Name = name;
      Price = price;
      Type = type;
    }
    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public double PriceInDollar(double dollar)
    {
      return Price * dollar;
    }
  }

  enum EProductType
  {
    Product = 1,
    Service = 2
  }
}
