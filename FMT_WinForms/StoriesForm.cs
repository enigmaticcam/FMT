using FMT_Logic;
using FMT_Logic.Stories.Snowstorm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMT_WinForms;
public partial class StoriesForm : Form
{
    private List<Story> _stories;
    private decimal _storyProgress;

    public StoriesForm()
    {
        InitializeComponent();
        LoadStories();
        LoadSettings();
        FillStories();
    }

    private void LoadStories()
    {
        _stories = new List<Story>()
        {
            new SnowstormStory()
        };
    }

    private void LoadSettings()
    {
        _storyProgress = (decimal)Properties.Settings.Default["StoryProgress"];
    }

    private void FillStories()
    {
        StoriesListBox.Items.Clear();
        foreach (var story in _stories.OrderBy(x => x.StoryId))
        {
            foreach (var chapter in story.Chapters.OrderBy(x => x.Number))
            {
                StoriesListBox.Items.Add(GetChapterDescription(story, chapter));
            }
        }
    }

    private string GetChapterDescription(Story story, Chapter chapter)
    {
        var unlock = Unlocked(story, chapter);
        if (!unlock.Chapter)
        {
            return "Unknown";
        } 
        else if (!unlock.Story)
        {
            return $"(Next story) Chapter {chapter.Number}";
        } 
        else
        {
            return $"{story.Title}: Chatper {chapter.Number}";
        }
    }

    private (bool Chapter, bool Story) Unlocked(Story story, Chapter chapter)
    {
        if (story.StoryId <= (int)_storyProgress && chapter.Number <= (int)(_storyProgress * 10) % 10) 
        {
            return (true, chapter.Number == story.Chapters.Count);
        }
        else
        {
            return (false, false);
        }
    }

    private void OpenButton_Click(object sender, EventArgs e)
    {

    }
}
