namespace FMT_Logic;

public abstract class Story
{
    public abstract string Title { get; }
    public abstract int StoryId { get; }

    private List<Chapter> _chapters;
    public List<Chapter> Chapters
    {
        get
        {
            if (_chapters == null)
                _chapters = GetChapters();
            return _chapters;
        }
    }
    protected abstract List<Chapter> GetChapters();
}
