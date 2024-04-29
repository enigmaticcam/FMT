using FMT_Logic;

namespace FMT_WinForms;
public partial class ChapterForm : Form
{
    private Chapter _chapter;
    private StoryProgress _storyProgress;
    private StoryCollection _storyCollection;
    private Encrypter _encrypter = new();

    public ChapterForm(Chapter chapter, StoryProgress storyProgress, StoryCollection storyCollection)
    {
        _chapter = chapter;
        _storyProgress = storyProgress;
        InitializeComponent();
        FillScreen();
        _storyProgress = storyProgress;
        _storyCollection = storyCollection;
    }

    private void FillScreen()
    {
        if (_storyCollection.IsCompleted(_chapter, _storyProgress.Progress))
        {
            CypterTextBox.Text = _chapter.Cypher;
            ChapterTextBox.Text = _encrypter.Encrypt(_chapter.Cypher, _chapter.EncryptedText, false);
        } else
        {
            ChapterTextBox.Text = _chapter.EncryptedText;
        }
    }

    private void DecryptButton_Click(object sender, EventArgs e)
    {
        ChapterTextBox.Text = _encrypter.Encrypt(CypterTextBox.Text, _chapter.EncryptedText, false);
        if (_chapter.Cypher == CypterTextBox.Text && !_storyCollection.IsCompleted(_chapter, _storyProgress.Progress))
            _storyProgress.SetProgressNext();
    }
}
