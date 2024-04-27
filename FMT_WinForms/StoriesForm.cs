using FMT_Logic;
using FMT_Logic.Stories.Snowstorm;
using System.Data;

namespace FMT_WinForms;
public partial class StoriesForm : Form
{
    private List<Story> _stories;
    private StoryProgress _storyProgress = new();

    public StoriesForm()
    {
        InitializeComponent();
        LoadStories();
        FillStories();
    }

    private void LoadStories()
    {
        _stories = new List<Story>()
        {
            new SnowstormStory()
        };
    }

    private void FillStories()
    {
        StoriesListBox.Items.Clear();
        foreach (var story in _stories.OrderBy(x => x.StoryId))
        {
            foreach (var chapter in story.Chapters.OrderBy(x => x.Number))
            {
                StoriesListBox.Items.Add(chapter.Description(_storyProgress.Progress));
            }
        }
    }

    private Chapter GetSelectedChapter()
    {
        int count = 0;
        foreach (var story in _stories)
        {
            foreach (var chapter in story.Chapters)
            {
                if (count == StoriesListBox.SelectedIndex)
                    return chapter;
                count++;
            }
        }
        return null;
    }

    private void OpenButton_Click(object sender, EventArgs e)
    {
        var chapter = GetSelectedChapter();
        var frm = new ChapterForm(chapter, _storyProgress);
        frm.ShowDialog();
        FillStories();
    }

    private void ResetProgressButton_Click(object sender, EventArgs e)
    {
        _storyProgress.Reset();
        FillStories();
    }
}
