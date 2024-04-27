namespace FMT_Logic;

public abstract class Chapter
{
    protected Chapter(Story parentStory)
    {
        ParentStory = parentStory;
    }

    public Story ParentStory { get; private set; }
    public abstract int Number { get; }
    public abstract string EncryptedText { get; }
    public abstract string Cypher { get; }

    public bool Completed(decimal progress)
    {
        return ParentStory.StoryId <= (int)progress && Number <= (int)(progress * 10) % 10;
    }

    public string Description(decimal progress)
    {
        if (ParentStory.Completed(progress))
        {
            return $"{ParentStory.Title}: Chapter {Number}";
        } 
        else if (Completed(progress))
        {
            return $"(Next story) Chapter {Number}";
        } 
        else
        {
            return "Unknown";
        }
    }
}
