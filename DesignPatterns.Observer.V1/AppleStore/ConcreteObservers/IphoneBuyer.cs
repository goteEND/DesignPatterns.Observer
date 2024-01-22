namespace DesignPatterns.Observer.V1;

public class IphoneBuyer : ICustomer
{
  public void Notify(Product product)
  {
    if (product == Product.Iphone)
    {
      Console.WriteLine($"{GetType().Name} was notified about {product}");
    }
  }
}
