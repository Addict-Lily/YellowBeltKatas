namespace ExamKata;

public class Merchant : ITrade, ISpeak
{
    public string Name { get; set; }
    public List<string> Inventory { get; set; }

    public Merchant(string name)
    {
        Name = name;
        Inventory = new List<string> { "Sword", "Shield", "Potion" };
    }

    public void ShowInventory()
    {
        Console.WriteLine($"{Name} says: Take a look at my wares.");
        foreach (var item in Inventory)
        {
            Console.WriteLine($"- {item}");
        }
    }

    public void BuyItem(string item)
    {
        if (Inventory.Contains(item))
        {
            Console.WriteLine($"You bought {item}!");
            Inventory.Remove(item);
        }
        else
        {
            Console.WriteLine("Item not available.");
        }
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Hello, would you like to trade?");
    }
    
}