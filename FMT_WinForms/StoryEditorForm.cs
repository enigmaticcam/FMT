using FMT_Logic;

namespace FMT_WinForms;
public partial class StoryEditorForm : Form
{
    private StorySave _save;
    private StoryEdit _selectedStory;
    private ChapterEdit _selectedChapter;

    public StoryEditorForm()
    {
        InitializeComponent();
    }

    private void FillStories()
    {
        StoryListBox.Items.Clear();
        foreach (var story in _save.Stories)
        {
            StoryListBox.Items.Add(story.Title);
        }
    }

    private void FillStory(StoryEdit story)
    {
        StoryTitleTextBox.Text = story.Title;
    }

    private void FillChapters(StoryEdit story)
    {
        ChapterListBox.Items.Clear();
        foreach (var chapter in story.Chapters)
        {
            ChapterListBox.Items.Add(chapter.ChapterNumber);
        }
    }

    private void SelectStory(StoryEdit story = null)
    {
        bool isSelecting = story != null;
        _selectedStory = story;
        StoryTitleTextBox.Text = isSelecting ? story.Title : "";
        StoryTitleTextBox.Enabled = isSelecting;
        AddChapterButton.Enabled = isSelecting;
        DeleteChapterButton.Enabled = isSelecting;
        if (isSelecting)
        {
            FillChapters(story);
        }
    }

    private void SelectChapter(ChapterEdit chapter = null)
    {
        bool isSelecting = chapter != null;
        _selectedChapter = chapter;
        ChapterNumberTextBox.Text = isSelecting ? chapter.ChapterNumber.ToString() : "";
        ChapterNumberTextBox.Enabled = isSelecting;
        ChapterTextBox.Text = isSelecting ? chapter.EncryptedText : "";
        ChapterTextBox.Enabled = isSelecting;
        EditTextButton.Enabled = isSelecting;
    }

    private void SelectSave()
    {
        AddStoryButton.Enabled = true;
        DeleteStoryButton.Enabled = true;
    }

    private void LoadButton_Click(object sender, EventArgs e)
    {
        var fileDialog = new OpenFileDialog();
        if (fileDialog.ShowDialog() == DialogResult.OK)
        {
            var loader = new StoryLoader();
            _save = loader.Load(fileDialog.FileName);
            FillStories();
            SelectSave();
        }
    }

    private void StoryListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (StoryListBox.SelectedIndex > -1)
        {
            SelectStory(_save.Stories[StoryListBox.SelectedIndex]);
            SelectChapter();
        } else
        {
            SelectStory();
        }
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        if (_save != null)
        {
            var fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var loader = new StoryLoader();
                loader.Save(_save, fileDialog.FileName);
            }
        }
    }

    private void AddStoryButton_Click(object sender, EventArgs e)
    {
        var story = new StoryEdit()
        {
            Chapters = new List<ChapterEdit>(),
            Title = "New Story"
        };
        _save.Stories.Add(story);
        StoryListBox.Items.Add("New Story");
    }

    private void DeleteStoryButton_Click(object sender, EventArgs e)
    {
        if (StoryListBox.SelectedIndex > -1)
        {
            _save.Stories.RemoveAt(StoryListBox.SelectedIndex);
            SelectStory();
        }
    }

    private void ChapterListBox_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ChapterListBox.SelectedIndex > -1)
        {
            SelectChapter(_selectedStory.Chapters[ChapterListBox.SelectedIndex]);
        } else
        {
            SelectChapter();
        }
    }

    private void DeleteChapterButton_Click(object sender, EventArgs e)
    {
        if (ChapterListBox.SelectedIndex > -1)
        {
            _selectedStory.Chapters.RemoveAt(ChapterListBox.SelectedIndex);
            ChapterListBox.Items.RemoveAt(ChapterListBox.SelectedIndex);
            SelectChapter();
        }
    }

    private void StoryTitleTextBox_Leave(object sender, EventArgs e)
    {
        _selectedStory.Title = StoryTitleTextBox.Text;
    }

    private void ChapterNumberTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        int value = 0;
        bool parse = int.TryParse(ChapterNumberTextBox.Text, out value);
        if (!parse)
        {
            e.Cancel = true;
        } else
        {
            _selectedChapter.ChapterNumber = value;
        }
    }

    private void ChapterTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
    {
        _selectedChapter.EncryptedText = ChapterTextBox.Text;
    }

    private void NewButton_Click(object sender, EventArgs e)
    {
        SelectChapter();
        SelectStory();
        _save = new StorySave()
        {
            ChapterList = new List<int>(),
            Stories = new List<StoryEdit>()
        };
        FillStories();
        SelectSave();
    }

    private void AddChapterButton_Click(object sender, EventArgs e)
    {
        var chapter = new ChapterEdit()
        {
            ChapterNumber = _selectedStory.Chapters.Count + 1
        };
        _selectedStory.Chapters.Add(chapter);
        ChapterListBox.Items.Add(chapter.ChapterNumber);
    }

    private void EditTextButton_Click(object sender, EventArgs e)
    {
        var frm = new EncryptForm(_selectedChapter.EncryptedText);
        frm.ShowDialog();
        _selectedChapter.EncryptedText = frm.EncryptedText;
        ChapterTextBox.Text = frm.EncryptedText;
    }
}
