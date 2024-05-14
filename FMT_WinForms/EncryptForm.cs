using FMT_Logic;
using FMT_Logic.Encrypters;

namespace FMT_WinForms;
public partial class EncryptForm : Form
{
    public EncryptForm()
    {
        InitializeComponent();
    }

    private Encrypter GetEncrypter(int selectedIndex)
        => selectedIndex switch
        {
            0 => new Version1(),
            1 => new Version2(),
            _ => null
        };

    private void cmdRandomizeCypher_Click(object sender, EventArgs e)
    {
        var encrypter = GetEncrypter(EncrypterTypeComboBox.SelectedIndex);
        if (encrypter != null)
            txtCypher.Text = encrypter.RandomCypher();
    }

    private void cmdEncrypt_Click(object sender, EventArgs e)
    {
        var encrypter = GetEncrypter(EncrypterTypeComboBox.SelectedIndex);
        if (encrypter != null)
            txtEncryptedText.Text = encrypter.Encrypt(txtCypher.Text, txtPlainText.Text, true);
    }

    private void cmdDecrypt_Click(object sender, EventArgs e)
    {
        var encrypter = GetEncrypter(EncrypterTypeComboBox.SelectedIndex);
        if (encrypter != null)
            txtPlainText.Text = encrypter.Encrypt(txtCypher.Text, txtEncryptedText.Text, false);
    }
}
