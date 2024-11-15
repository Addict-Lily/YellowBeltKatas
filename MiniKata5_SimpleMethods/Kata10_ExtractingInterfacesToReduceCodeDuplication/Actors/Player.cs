namespace Kata10_ExtractingInterfacesToReduceCodeDuplication;
using Kata10_ExtractingInterfacesToReduceCodeDuplication.Actors;
using Kata10_ExtractingInterfacesToReduceCodeDuplication.Interfaces;

public class Player
{
    public string Name {get; private set;}
    public int Health {get; private set;}
    
    public Player(string name, int health)
    {
        Name = name;
        Health = health;
    }
    public void Walk()
    {
        Console.WriteLine("Character walking...");
    }

    public void NameOfTheCharacter()
    {
        Console.WriteLine("Name of the player is Arin.");
    }
    
}