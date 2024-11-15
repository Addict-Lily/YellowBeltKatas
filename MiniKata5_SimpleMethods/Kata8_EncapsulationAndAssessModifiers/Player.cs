namespace Kata8_EncapsulationAndAssessModifiers;

public class Player
{
    private int _health;
    private int _level;
    private int _experience;
    
    public string Name { get; private set; }
    public int Health
    {
        get => _health;
        private set => _health = value;
    }
    
    public int Level
    {
        get => _level;
        set
        {
            if (value >=0)
                _level = value;
            else
            {
                Console.WriteLine("Level cannot be negative.");
            }
        }
    }

    public int Experience
    {
        get => _experience;
        set
        {
            if (value >= 0)
                _experience = value;
            else
            {
                Console.WriteLine("Experience cannot be negative.");
            }
        }
    }

    public Player(string name,int health, int level)
    {
        Name = name;
        _health = health;
        _level = level;
        _experience = 0;
    }
    public void GainExperience(int exp)
    {
        Console.WriteLine($"{Name} gains {exp} experience points.");
        Experience += exp;

        if (Experience >= 100)
        {
            LevelUp();
        }
    }
    private void LevelUp()
    {
        _level += 1;
        _experience = 0;
        Console.WriteLine($"Congratulations! {Name} leveled up to Level {Level}.");
    }
}