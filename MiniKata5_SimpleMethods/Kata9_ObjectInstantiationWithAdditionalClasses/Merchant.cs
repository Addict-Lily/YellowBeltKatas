namespace Kata9_ObjectInstantiationWithAdditionalClasses;

public class Merchant
{
    public string Name { get; private set; }
    public List<string> Inventory { get; private set; }

    public Merchant(string name, List<string> inventory)
    {
        Name = name;
        Inventory = inventory;
    }
    
    public void Trade()
    {
        Console.WriteLine($"{Name}'s inventory: {string.Join(",",Inventory)}!");
    }
}