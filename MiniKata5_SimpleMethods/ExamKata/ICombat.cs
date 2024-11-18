namespace ExamKata;

public interface ICombat
{
    {
        void Attack(ICombat target); // Perform an attack
        void TakeDamage(int damage); // Take damage when attacked
        bool IsAlive(); // Check if the character is still alive
    }

    public interface ISpeak
    {
        void Speak(); // Dialogue method for speaking
    }

    public interface ITrade
    {
        void ShowInventory(); // Show items available for trade
        void BuyItem(string item); // Buy an item from the merchant
    }
    
}