namespace FMT_WinForms;

public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private void cmdEncrypt_Click(object sender, EventArgs e)
    {
        var encrypt = new Encrypt();
        encrypt.ShowDialog();
    }
}
