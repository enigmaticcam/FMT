using FMT_Logic;
using System.Text;

namespace FMT_WinForms;
public partial class Encrypt : Form
{
    private Encrypter _encrypter = new();
    public Encrypt()
    {
        InitializeComponent();
    }

    private void cmdRandomizeCypher_Click(object sender, EventArgs e)
    {
        txtCypher.Text = _encrypter.RandomCypher();
    }

    private void cmdEncrypt_Click(object sender, EventArgs e)
    {
        txtEncryptedText.Text = _encrypter.Encrypt(txtCypher.Text, txtPlainText.Text, true);
    }

    private void cmdDecrypt_Click(object sender, EventArgs e)
    {
        txtPlainText.Text = _encrypter.Encrypt(txtCypher.Text, txtEncryptedText.Text, false);
    }
}
