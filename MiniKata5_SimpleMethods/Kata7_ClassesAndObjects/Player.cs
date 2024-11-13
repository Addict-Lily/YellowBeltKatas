namespace Kata7_ClassesAndObjects;

public class Player
{
    public string NameA;
    public int Health;
    public int Level;
    public int Experience;
    

    public void Attack()
    {
        Console.WriteLine($"Player Arin attacks the Orc and deals 20 damage.");
    }
    
    public void GainExperience()
    {
        Console.WriteLine("Player Arin gains 50 experience points.");
            
    }
    


}