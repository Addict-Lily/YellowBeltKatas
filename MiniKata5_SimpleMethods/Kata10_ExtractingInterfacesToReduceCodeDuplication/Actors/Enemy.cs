namespace Kata10_ExtractingInterfacesToReduceCodeDuplication.Actors;
using Interfaces;
public class Enemy : ITakeDamage
{
    private string enemyType;
    private int enemyHealth;
    private int damage;

    public void Hunt()
    {
        //How to write name of the player?
        Console.WriteLine($"{enemyType} is hunting Arin...");
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
        Console.WriteLine($"{EnemyType} takes {damage}. Remaining health: {EnemyHealth}");

    }
}