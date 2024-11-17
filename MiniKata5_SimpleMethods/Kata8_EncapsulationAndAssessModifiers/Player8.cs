namespace Kata8_EncapsulationAndAssessModifiers;

public class Player8
{
    public string name8;
    private int health;
    private int level;
    private int experience;

    public Player8(int health, int level, int experience)
    {
        Health = health;
        Level = level;
        Experience = experience;
    }
    
    public int Health
    {
        get { return health; }
        set
        {
            health = value;
        }
    }
    
    public int Level
    {
        get { return level;}
        set
        {
            if (value >= 0)
            {
                level = value;
            }
            else
                Console.WriteLine("Level cannot be negative.");
        }
        
    }
    public int Experience
    {
        get { return experience; }
        set
        {
            
            if (value >= 0)
            {experience = value;}
            else
            {
                Console.WriteLine("Experience cannot be negative.");
            }
        }
    }
    public void GainExperience(int exp)
    {
        Console.WriteLine($"{name8} gains {exp} experience points.");
        Experience += exp;

        if (Experience >= 100)
        {
            LevelUp();
        }
    }
    public void LevelUp()
    {
        level += 1;
        experience = 0;
        Console.WriteLine($"Congratulations! {name8} leveled up to Level {Level}.");
    }
}


//Is this also correct? Is it possible to write like this?
/*
public Player (string name,int health, int level)
    {
        _name = name;
        _health = health;
        _level = level;
        _experience = 0;
    }
    
    //How to write as a short way?
    public int Experience
    {
        get => experience;
        set
        {
            if (value >= 0)
                experience = value;
            else
            {
                Console.WriteLine("Experience cannot be negative.");
            }
        }
*/