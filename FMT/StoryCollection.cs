using FMT_Logic.Stories.Snowstorm;

namespace FMT_Logic;
public class StoryCollection
{
    private Dictionary<Chapter, int> _chapters;

    public StoryCollection()
    {
        var stories = new List<Story>()
        {
            new SnowstormStory()
        };
        SetChapters(stories);
    }

    public IEnumerable<Story> Stories => _chapters
        .Select(x => x.Key.ParentStory)
        .Distinct()
        .OrderBy(x => x.StoryId);

    public IEnumerable<Chapter> Chapters => _chapters
        .OrderBy(x => x.Value)
        .Select(x => x.Key);

    private void SetChapters(IEnumerable<Story> stories)
    {
        _chapters = new Dictionary<Chapter, int>();
        int order = 0;
        foreach (var story in stories)
        {
            foreach (var chap in story.Chapters)
            {
                _chapters.Add(chap, order);
                order++;
            }
        }
    }

    public bool IsCompleted(Chapter chapter, int progress)
    {
        return _chapters[chapter] <= progress;
    }

    public bool IsCompleted(Story story, int progress)
    {
        return IsCompleted(story.Chapters.Last(), progress);
    }

    public bool IsCurrent(Chapter chapter, int progress)
    {
        return _chapters[chapter] == progress;
    }

    public string Description(Chapter chapter, int progress)
    {
        if (IsCompleted(chapter.ParentStory, progress))
        {
            return $"{chapter.ParentStory.Title}: Chapter {chapter.Number}";
        }
        else if (IsCompleted(chapter, progress))
        {
            return $"(Next story) Chapter {chapter.Number}";
        }
        else
        {
            return "Incomplete";
        }
    }
}
