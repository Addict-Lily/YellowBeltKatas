namespace Kata10_ExtractingInterfacesToReduceCodeDuplication;
using Kata10_ExtractingInterfacesToReduceCodeDuplication.Actors;
using Kata10_ExtractingInterfacesToReduceCodeDuplication.Interfaces;

public class Player
{
    private string Name = "Arin";
    
    public string name { get; set; }
    {
        Name = name;
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