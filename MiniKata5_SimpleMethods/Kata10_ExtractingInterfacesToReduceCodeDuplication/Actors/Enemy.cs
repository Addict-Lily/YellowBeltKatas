namespace Kata10;
public class Enemy : Character
{
    private string enemyType;
    private int enemyHealth;
    private int damage;

    public override void Hunt(Character target)
    {
        //How to write name of the player?
        Console.WriteLine($"{enemyType} smelled its target and is hunting Arin...");
    }
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