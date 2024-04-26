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
        encrypt.ShowDialog();
    }

    private void StoriesButton_Click(object sender, EventArgs e)
    {
        var stories = new StoriesForm();
        stories.ShowDialog();
    }
}
