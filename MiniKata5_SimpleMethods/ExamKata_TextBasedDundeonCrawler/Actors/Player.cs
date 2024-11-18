namespace ExamKata_TextBasedDundeonCrawler;

public class Player : IWalk, ISpeak
{ public void Walk()
    {
        Console.WriteLine($"Player is approaching.");
    }

    public void Speak(string text)
    {
        
    }
    
    private string playerName;
    private int playerHealth;
    private int level;
    
    public Player(string aPlayerName, int aPlayerHealth, int aLevel)
    {
        PlayerName = aPlayerName;
        PlayerHealth = aPlayerHealth;
        Level = aLevel;
    }
    
    public string PlayerName
    {
        get { return playerName; }
        set { playerName = value; }
    }
    public int PlayerHealth
    {
        get { return playerHealth; }
        set
        {
            if (value >= 0)
            {
                playerHealth = value;
                
            }
            else
            {
                Console.WriteLine($"{PlayerName}, it seems you're not alive anymore!!");
            }
        }
    }
    public int Level
    {
        get { return level; }
        set { level = value; }
    }
    public void Attack(Enemy enemy,  int damage)
    {
        Console.WriteLine($"{PlayerName} attacks {enemy.EnemyType} and deals {damage} damage.");
        enemy.TakeDamage(damage);
    }
}