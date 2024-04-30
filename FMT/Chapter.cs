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

    public override bool Equals(object obj)
    {
        var cast = (Chapter)obj;
        return cast.ParentStory.StoryId == ParentStory.StoryId && cast.Number == Number;
    }

    public override int GetHashCode()
    {
        return ParentStory.StoryId * 100 + Number;
    }
}
