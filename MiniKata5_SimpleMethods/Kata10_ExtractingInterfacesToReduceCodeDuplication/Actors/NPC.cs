namespace Kata10_ExtractingInterfacesToReduceCodeDuplication;
using Interfaces;

public class NPC : IWalk, ISpeak
{
    private string npcName;
    private string npcDialogue;

    public void Walk()
    {
        Console.WriteLine($"{npcName} walking...");
    }

    public void Speak()
    {
        
        Console.WriteLine($"{npcName} speaking...");
        Console.WriteLine($"{NpcName} says: {NpcDialogue}!");
    }
    
    public NPC(string aNpcName, string aNpcDialogue)
    {
        NpcName = aNpcName;
        NpcDialogue = aNpcDialogue;
    }
    public string NpcName
    {
        get { return npcName; }
        set { npcName = value; }
    }
    public string NpcDialogue
    {
        get { return npcDialogue; }
        set { npcDialogue = value; }
    }
    
}