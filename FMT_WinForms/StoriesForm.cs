using FMT_Logic;

namespace FMT_WinForms;
public partial class StoriesForm : Form
{
    private StoryCollection _stories;
    private IStoryProgress _storyProgress;

    public StoriesForm()
    {
        _storyProgress = new StoryProgress();
        _stories = new StoryCollection(_storyProgress);
        InitializeComponent();
        FillStories();
    }

    private void FillStories()
    {
        StoriesListBox.Items.Clear();
        foreach (var chapter in _stories.Chapters)
        {
            StoriesListBox.Items.Add(_stories.Description(chapter));
        }
        OpenButton.Enabled = false;
    }

    private Chapter GetSelectedChapter()
    {
        int count = 0;
        foreach (var chapter in _stories.Chapters)
        {
            if (count == StoriesListBox.SelectedIndex)
                return chapter;
            count++;
        }
        return null;
    }

    private void OpenButton_Click(object sender, EventArgs e)
    {
        var chapter = GetSelectedChapter();
        var frm = new ChapterForm(chapter, _stories);
        frm.ShowDialog();
        FillStories();
    }

    private void ResetProgressButton_Click(object sender, EventArgs e)
    {
        _storyProgress.Reset();
        FillStories();
    }
    
    private void StoriesListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (StoriesListBox.SelectedIndex == -1)
        {
            OpenButton.Enabled = false;
        } 
        else
        {
            var chapter = GetSelectedChapter();
            OpenButton.Enabled = _stories.IsCompleted(chapter) || _stories.IsCurrent(chapter);
        }
    }
}
