namespace DesignPatterns.Observer.V1;

public class MacbookBuyer : ICustomer
{
  public void Notify(Product product)
  {
    if (product == Product.Macbook)
    {
      Console.WriteLine($"{GetType().Name} was notified about {product}");
    }
  }
}
