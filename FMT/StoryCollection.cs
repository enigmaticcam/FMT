using FMT_Logic.Stories.LastLeaf;
using FMT_Logic.Stories.Snowstorm;

namespace FMT_Logic;
public class StoryCollection
{
    private Dictionary<Chapter, int> _chapters;
    private IStoryProgress _storyProgress;

    public StoryCollection(IStoryProgress storyProgress)
    {
        _storyProgress = storyProgress;
        var stories = new List<Story>()
        {
            new SnowstormStory(),
            new LastLeafStory()
        };
        var chapters = new List<Chapter>()
        {
            stories[1].Chapters[0],
            stories[1].Chapters[1],
            stories[0].Chapters[0],
            stories[0].Chapters[1],
            stories[0].Chapters[2],
            stories[0].Chapters[3]
        };
        SetChapters(chapters);
    }

    public IEnumerable<Story> Stories => _chapters
        .Select(x => x.Key.ParentStory)
        .Distinct()
        .OrderBy(x => x.StoryId);

    public IEnumerable<Chapter> Chapters => _chapters
        .OrderBy(x => x.Value)
        .Select(x => x.Key);

    private void SetChapters(IEnumerable<Chapter> chapters)
    {
        _chapters = chapters
            .Select((x, i) => new { x, i })
            .ToDictionary(x => x.x, x => x.i);
    }

    public bool IsCompleted(Chapter chapter)
    {
        return _storyProgress.Contains(_chapters[chapter]);
    }

    public bool IsCompleted(Story story)
    {
        foreach (var chap in story.Chapters)
        {
            if (!IsCompleted(chap))
                return false;
        }
        return true;
    }

    public bool IsCurrent(Chapter chapter)
    {
        var current = GetCurrentChapter();
        return current == chapter;
    }

    private Chapter GetCurrentChapter()
    {
        foreach (var chapter in Chapters)
        {
            if (!_storyProgress.Contains(_chapters[chapter]))
                return chapter;
        }
        return null;
    }

    public string Description(Chapter chapter)
    {
        if (IsCompleted(chapter.ParentStory))
        {
            return $"{chapter.ParentStory.Title}: Chapter {chapter.Number}";
        }
        else if (IsCompleted(chapter))
        {
            return $"Story #{chapter.ParentStory.StoryId}: Chapter {chapter.Number}";
        }
        else if (IsCurrent(chapter))
        {
            return $"Story #{chapter.ParentStory.StoryId}: Chapter {chapter.Number} (current)";
        }
        else
        {
            return "Incomplete";
        }
    }

    public void SetProgress(Chapter chapter)
    {
        _storyProgress.SetProgress(_chapters[chapter]);
    }
}
