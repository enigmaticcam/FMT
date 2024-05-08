namespace FMT_WinForms;

partial class ImageToTextForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        GoButton = new Button();
        ResultTextBox = new RichTextBox();
        SuspendLayout();
        // 
        // GoButton
        // 
        GoButton.Location = new Point(12, 12);
        GoButton.Name = "GoButton";
        GoButton.Size = new Size(94, 29);
        GoButton.TabIndex = 0;
        GoButton.Text = "Go";
        GoButton.UseVisualStyleBackColor = true;
        GoButton.Click += GoButton_Click;
        // 
        // ResultTextBox
        // 
        ResultTextBox.Location = new Point(12, 47);
        ResultTextBox.Name = "ResultTextBox";
        ResultTextBox.ReadOnly = true;
        ResultTextBox.Size = new Size(776, 391);
        ResultTextBox.TabIndex = 1;
        ResultTextBox.Text = "";
        // 
        // ImageToTextForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ResultTextBox);
        Controls.Add(GoButton);
        Name = "ImageToTextForm";
        Text = "ImageToTextForm";
        ResumeLayout(false);
    }

    #endregion

    private Button GoButton;
    private RichTextBox ResultTextBox;
}