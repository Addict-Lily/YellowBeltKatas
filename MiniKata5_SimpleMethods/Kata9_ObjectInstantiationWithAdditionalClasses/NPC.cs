namespace Kata9_ObjectInstantiationWithAdditionalClasses;

public class NPC
{
    public string Name { get; private set; }
    public string Dialogue { get; private set; }
    
    public NPC(string name, string dialogue)
    {
        Name = name;
        Dialogue = dialogue;
    }

    public void Talk()
    {
        Console.WriteLine($"{Name} says: {Dialogue}!");
    }
}