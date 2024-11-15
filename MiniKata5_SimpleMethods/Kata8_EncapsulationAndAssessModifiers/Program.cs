namespace Kata8_EncapsulationAndAssessModifiers;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Player", 100, 1);
        
        player.GainExperience(50);
        player.GainExperience(60);
        
    }
}