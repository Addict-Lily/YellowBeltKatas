namespace Kata8_EncapsulationAndAssessModifiers;

class Program
{
    static void Main(string[] args)
    {
        Player8 player = new Player8(100, 1, 0);
        player.name8 = "Player";
        
        player.GainExperience(50);
        player.GainExperience(60);
    }
}