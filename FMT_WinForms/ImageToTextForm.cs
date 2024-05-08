using FMT_Logic;

namespace FMT_WinForms;
public partial class ImageToTextForm : Form
{
    public ImageToTextForm()
    {
        InitializeComponent();
    }

    private void GoButton_Click(object sender, EventArgs e)
    {
        var reader = new ImageToText();
        var text = reader.GetText(@"C:\Users\enigm\OneDrive\Pictures\Screenshots\Capture.png");
        ResultTextBox.Text = text;
    }
}
