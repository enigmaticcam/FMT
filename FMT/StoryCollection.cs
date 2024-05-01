using FMT_Logic.Stories.LastLeaf;
using FMT_Logic.Stories.Snowstorm;

namespace FMT_Logic;
public class StoryCollection
{
    private Dictionary<Chapter, int> _chapters;
    private IStoryProgress _storyProgress;

    public StoryCollection(IStoryProgress storyProgress)
    {
        var stories = new List<Story>()
        {
            new SnowstormStory(),
            new LastLeafStory()
        };
        SetChapters(stories);
        _storyProgress = storyProgress;
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

    public bool IsCompleted(Chapter chapter)
    {
        return _storyProgress.Contains(_chapters[chapter]);
    }

    public bool IsCompleted(Story story)
    {
        return IsCompleted(story.Chapters.Last());
    }

    public bool IsCurrent(Chapter chapter)
    {
        var current = GetCurrentChapter();
        return current == chapter;
    }

    private Chapter GetCurrentChapter()
    {
        foreach (var story in Stories)
        {
            foreach (var chapter in story.Chapters)
            {
                if (!_storyProgress.Contains(_chapters[chapter]))
                    return chapter;
            }
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
            return $"(Next story) Chapter {chapter.Number}";
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
