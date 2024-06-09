namespace FMT_WinForms;

partial class DashboardForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        cmdEncrypt = new Button();
        StoriesButton = new Button();
        ImageToTextButton = new Button();
        StoryEditorButton = new Button();
        SuspendLayout();
        // 
        // cmdEncrypt
        // 
        cmdEncrypt.Location = new Point(12, 12);
        cmdEncrypt.Name = "cmdEncrypt";
        cmdEncrypt.Size = new Size(94, 29);
        cmdEncrypt.TabIndex = 0;
        cmdEncrypt.Text = "Encrypt";
        cmdEncrypt.UseVisualStyleBackColor = true;
        cmdEncrypt.Click += cmdEncrypt_Click;
        // 
        // StoriesButton
        // 
        StoriesButton.Location = new Point(12, 47);
        StoriesButton.Name = "StoriesButton";
        StoriesButton.Size = new Size(94, 29);
        StoriesButton.TabIndex = 1;
        StoriesButton.Text = "Stories";
        StoriesButton.UseVisualStyleBackColor = true;
        StoriesButton.Click += StoriesButton_Click;
        // 
        // ImageToTextButton
        // 
        ImageToTextButton.Location = new Point(12, 82);
        ImageToTextButton.Name = "ImageToTextButton";
        ImageToTextButton.Size = new Size(116, 29);
        ImageToTextButton.TabIndex = 2;
        ImageToTextButton.Text = "Image to Text";
        ImageToTextButton.UseVisualStyleBackColor = true;
        ImageToTextButton.Click += ImageToTextButton_Click;
        // 
        // StoryEditorButton
        // 
        StoryEditorButton.Location = new Point(12, 117);
        StoryEditorButton.Name = "StoryEditorButton";
        StoryEditorButton.Size = new Size(116, 29);
        StoryEditorButton.TabIndex = 3;
        StoryEditorButton.Text = "Story Editor";
        StoryEditorButton.UseVisualStyleBackColor = true;
        StoryEditorButton.Click += StoryEditorButton_Click;
        // 
        // DashboardForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(StoryEditorButton);
        Controls.Add(ImageToTextButton);
        Controls.Add(StoriesButton);
        Controls.Add(cmdEncrypt);
        Name = "DashboardForm";
        Text = "Dashboard";
        ResumeLayout(false);
    }

    #endregion

    private Button cmdEncrypt;
    private Button StoriesButton;
    private Button ImageToTextButton;
    private Button StoryEditorButton;
}
