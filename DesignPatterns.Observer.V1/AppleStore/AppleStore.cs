namespace DesignPatterns.Observer.V1;

public class AppleStore
{
  public List<ICustomer> _customers;
  public List<Product> _products = [];

  public AppleStore()
  {
    _customers = new List<ICustomer>();
    StockProducts();
  }

  public void AddCustomer(ICustomer customer)
  {
    Console.WriteLine($"Added customer {customer.GetType().Name}");
    _customers.Add(customer);
  }

  public void RemoveCustomer(ICustomer customer)
  {
    Console.WriteLine($"Removed customer {customer.GetType().Name}");
    _customers.Remove(customer);
  }

  private void NotifyCustomers(Product product)
  {
    foreach (ICustomer customer in _customers)
    {
      customer.Notify(product);
    }
  }

  private void StockProducts()
  {
    foreach (Product product in Enum.GetValues(typeof(Product)))
    {
      _products.Add(product);
    }
  }

  public void SaleManager()
  {
    foreach (Product product in _products)
    {
      Thread.Sleep(1000);
      if (_customers.Count != 0)
      {
        NotifyCustomers(product);
      }
    }
  }

}
