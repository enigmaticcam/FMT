using FMT_Logic;
using FMT_Logic.Stories.Snowstorm;
using System.Data;

namespace FMT_WinForms;
public partial class StoriesForm : Form
{
    private StoryCollection _stories = new();
    private StoryProgress _storyProgress = new();

    public StoriesForm()
    {
        InitializeComponent();
        FillStories();
    }

    private void FillStories()
    {
        StoriesListBox.Items.Clear();
        foreach (var chapter in _stories.Chapters)
        {
            StoriesListBox.Items.Add(_stories.Description(chapter, _storyProgress.Progress));
        }
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
        var frm = new ChapterForm(chapter, _storyProgress, _stories);
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
            OpenButton.Enabled = _stories.IsCompleted(chapter, _storyProgress.Progress) || _stories.IsCurrent(chapter, _storyProgress.Progress);
        }
    }
}
