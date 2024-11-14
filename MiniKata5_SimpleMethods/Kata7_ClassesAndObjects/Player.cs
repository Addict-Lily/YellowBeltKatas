namespace Kata7_ClassesAndObjects;

public class Player
{
    public string NameA;
    public int Health;
    public int Level;
    public int Experience;
    public int Damage;
    

    public void Attack(int damage)
    {
        Health -= damage;
        Console.WriteLine($"Player {NameA} attacks the Orc and deals {damage} damage.");
    }
    
    public void GainExperience(int exp)
    {
        Experience += exp;
        Console.WriteLine($"Player {NameA} gains {Experience} experience points.");
            
    }
    


}