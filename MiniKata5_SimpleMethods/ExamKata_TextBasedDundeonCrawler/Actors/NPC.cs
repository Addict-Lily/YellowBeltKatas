namespace ExamKata_TextBasedDundeonCrawler;

public class NPC : IWalk, ISpeak
{
    private string npcName;
    private string npcDialogue;

    public void Walk()
    {
        Console.WriteLine($"{npcName} walking and he said: {npcDialogue}!");
    }

    public void Speak(string text)
    {
        Console.WriteLine($"{npcName} said: Who are you?...");
        
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