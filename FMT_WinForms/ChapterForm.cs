using FMT_Logic;

namespace FMT_WinForms;
public partial class ChapterForm : Form
{
    private Chapter _chapter;
    private StoryCollection _storyCollection;
    private Encrypter _encrypter = Factory.CreateEncrypter();

    public ChapterForm(Chapter chapter, StoryCollection storyCollection)
    {
        _chapter = chapter;
        _storyCollection = storyCollection;
        InitializeComponent();
        FillScreen();
    }

    private void FillScreen()
    {
        if (_storyCollection.IsCompleted(_chapter))
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
        if (_chapter.Cypher == CypterTextBox.Text && !_storyCollection.IsCompleted(_chapter))
            _storyCollection.SetProgress(_chapter);
    }
}
