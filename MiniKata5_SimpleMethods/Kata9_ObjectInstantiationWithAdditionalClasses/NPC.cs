namespace Kata9_ObjectInstantiationWithAdditionalClasses;

public class NPC
{
    private string npcName;
    private string npcDialogue;
    
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
    public void Talk()
    {
        Console.WriteLine($"{NpcName} says: {NpcDialogue}!");
    }
}