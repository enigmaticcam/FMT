namespace FMT_Logic;

public abstract class Story
{
    public abstract string Title { get; }
    public abstract int StoryId { get; }
    public abstract List<Chapter> Chapters { get; }
}
