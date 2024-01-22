namespace DesignPatterns.Observer.V1;

public class MacBuyer : ICustomer
{
  public void Notify(Product product)
  {
    if (product == Product.Mac)
    {
      Console.WriteLine($"{GetType().Name} was notified about {product}");
    }
  }
}
