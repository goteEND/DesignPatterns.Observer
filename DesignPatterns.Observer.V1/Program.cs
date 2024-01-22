namespace DesignPatterns.Observer.V1;

class Program
{
    static void Main(string[] args)
    {
        AppleStore appleStore = new();

        IphoneBuyer iphoneBuyer = new();
        MacbookBuyer macbookBuyer = new();
        MacBuyer macBuyer = new();

        appleStore.AddCustomer(iphoneBuyer);
        appleStore.AddCustomer(macbookBuyer);
        appleStore.AddCustomer(macBuyer);

        appleStore.SaleManager();
    }
}
