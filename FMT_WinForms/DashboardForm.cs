using FMT_Logic;

namespace FMT_WinForms;

public partial class DashboardForm : Form
{
    public DashboardForm()
    {
        InitializeComponent();
    }

    private void cmdEncrypt_Click(object sender, EventArgs e)
    {
        var encrypt = new EncryptForm();
        encrypt.Show();
    }

    private void StoriesButton_Click(object sender, EventArgs e)
    {
        var stories = new StoriesForm();
        stories.Show();
    }

    private void ImageToTextButton_Click(object sender, EventArgs e)
    {
        var imageToText = new ImageToTextForm();
        imageToText.Show();
    }
}
