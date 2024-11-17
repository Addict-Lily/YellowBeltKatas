namespace Kata9_ObjectInstantiationWithAdditionalClasses;

public class Merchant
{
    private string merchantName;
    private List<string>inventory;

    public Merchant(string aMerchantName, List<string> aInventory)
    {
        MerchantName = aMerchantName;
        Inventory = aInventory;
    }
    public string MerchantName
        {
            get { return merchantName; }
            set { merchantName = value; }
        }
    public List<string> Inventory
    {
        get { return inventory; }
        set { inventory = value; }
    }
    public void Trade()
    {
        Console.WriteLine($"{merchantName}'s inventory: {string.Join(",",Inventory)}!");
    }
}