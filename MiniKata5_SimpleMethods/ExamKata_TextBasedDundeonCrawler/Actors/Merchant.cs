namespace ExamKata_TextBasedDundeonCrawler;
public class Merchant : ISpeak
{
    private string merchantName;
    private List<string>inventory;
    public void Speak(string text)
    {
        Console.WriteLine($"{merchantName} said Let's trade!");
        Console.WriteLine($"{merchantName}'s inventory: {string.Join(",",Inventory)}!");
    }

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
}