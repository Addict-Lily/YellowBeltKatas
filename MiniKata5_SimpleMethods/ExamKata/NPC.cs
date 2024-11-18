namespace ExamKata;

public class NPC : ISpeak 
{
    public string Name { get; set; }

    public NPC(string name)
    {
        Name = name;
    }

    public void Speak()
    {
        Console.WriteLine($"{Name} says: Welcome to our village!");
    }
    
}