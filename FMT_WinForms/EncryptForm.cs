using FMT_Logic;
using FMT_Logic.Encrypters;

namespace FMT_WinForms;
public partial class EncryptForm : Form
{
    public EncryptForm(string encryptedText = null)
    {
        InitializeComponent();
        if (!string.IsNullOrEmpty(encryptedText))
        {
            txtEncryptedText.Text = encryptedText;
        }
    }

    public string EncryptedText { get; set; }
    public string PlainText { get; set; }

    private Encrypter GetEncrypter(int selectedIndex)
        => selectedIndex switch
        {
            0 => new Version1(),
            1 => new Version2(),
            _ => null
        };

    private void Encrypt()
    {
        var encrypter = GetEncrypter(EncrypterTypeComboBox.SelectedIndex);
        if (encrypter != null)
            txtEncryptedText.Text = encrypter.Encrypt(txtCypher.Text, txtPlainText.Text, true);
    }

    private void cmdRandomizeCypher_Click(object sender, EventArgs e)
    {
        var encrypter = GetEncrypter(EncrypterTypeComboBox.SelectedIndex);
        if (encrypter != null)
            txtCypher.Text = encrypter.RandomCypher();
    }

    private void cmdEncrypt_Click(object sender, EventArgs e)
    {
        Encrypt();
    }

    private void cmdDecrypt_Click(object sender, EventArgs e)
    {
        var encrypter = GetEncrypter(EncrypterTypeComboBox.SelectedIndex);
        if (encrypter != null)
            txtPlainText.Text = encrypter.Encrypt(txtCypher.Text, txtEncryptedText.Text, false);
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {

    }

    private void EncryptForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        EncryptedText = txtEncryptedText.Text;
        PlainText = txtPlainText.Text;
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.OK;
        Encrypt();
        Close();
    }

    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}
