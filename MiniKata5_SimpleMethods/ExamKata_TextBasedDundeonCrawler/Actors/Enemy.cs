namespace ExamKata_TextBasedDundeonCrawler;
public class Enemy
{
    private string enemyType;
    private int enemyHealth;
    private int damage;
    
    public Enemy(string aEnemyType, int aEnemyHealth, int aDamage)
    {
        EnemyType = aEnemyType;
        EnemyHealth = aEnemyHealth;
        Damage = aDamage;
    }
    public string EnemyType
    {
        get { return enemyType; }
        set { enemyType = value; }
    }
    public int EnemyHealth
    {
        get { return enemyHealth; }
        set { enemyHealth = value; }
    }
    public int Damage
    {
        get { return damage; }
        set { damage = value;}
    }
    public void TakeDamage(int damage)
    {
        EnemyHealth -= damage;
        Console.WriteLine($" This one{EnemyType} takes {damage}. Remaining health: {EnemyHealth}");
    }
}