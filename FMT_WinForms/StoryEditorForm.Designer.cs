namespace FMT_WinForms;

partial class StoryEditorForm
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
        StoryListBox = new ListBox();
        LoadButton = new Button();
        label1 = new Label();
        label2 = new Label();
        ChapterListBox = new ListBox();
        SaveButton = new Button();
        AddStoryButton = new Button();
        AddChapterButton = new Button();
        label3 = new Label();
        StoryTitleTextBox = new TextBox();
        ChapterNumberTextBox = new TextBox();
        label4 = new Label();
        ChapterTextBox = new RichTextBox();
        DeleteStoryButton = new Button();
        DeleteChapterButton = new Button();
        NewButton = new Button();
        EditTextButton = new Button();
        SuspendLayout();
        // 
        // StoryListBox
        // 
        StoryListBox.FormattingEnabled = true;
        StoryListBox.Location = new Point(12, 129);
        StoryListBox.Name = "StoryListBox";
        StoryListBox.Size = new Size(353, 144);
        StoryListBox.TabIndex = 0;
        StoryListBox.SelectedIndexChanged += StoryListBox_SelectedIndexChanged;
        // 
        // LoadButton
        // 
        LoadButton.Location = new Point(112, 12);
        LoadButton.Name = "LoadButton";
        LoadButton.Size = new Size(94, 29);
        LoadButton.TabIndex = 1;
        LoadButton.Text = "Load...";
        LoadButton.UseVisualStyleBackColor = true;
        LoadButton.Click += LoadButton_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 71);
        label1.Name = "label1";
        label1.Size = new Size(54, 20);
        label1.TabIndex = 2;
        label1.Text = "Stories";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 296);
        label2.Name = "label2";
        label2.Size = new Size(67, 20);
        label2.TabIndex = 4;
        label2.Text = "Chapters";
        // 
        // ChapterListBox
        // 
        ChapterListBox.FormattingEnabled = true;
        ChapterListBox.Location = new Point(12, 354);
        ChapterListBox.Name = "ChapterListBox";
        ChapterListBox.Size = new Size(353, 204);
        ChapterListBox.TabIndex = 3;
        ChapterListBox.SelectedIndexChanged += ChapterListBox_SelectedIndexChanged;
        // 
        // SaveButton
        // 
        SaveButton.Location = new Point(212, 12);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new Size(94, 29);
        SaveButton.TabIndex = 5;
        SaveButton.Text = "Save...";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // AddStoryButton
        // 
        AddStoryButton.Enabled = false;
        AddStoryButton.Location = new Point(12, 94);
        AddStoryButton.Name = "AddStoryButton";
        AddStoryButton.Size = new Size(94, 29);
        AddStoryButton.TabIndex = 6;
        AddStoryButton.Text = "Add";
        AddStoryButton.UseVisualStyleBackColor = true;
        AddStoryButton.Click += AddStoryButton_Click;
        // 
        // AddChapterButton
        // 
        AddChapterButton.Enabled = false;
        AddChapterButton.Location = new Point(12, 319);
        AddChapterButton.Name = "AddChapterButton";
        AddChapterButton.Size = new Size(94, 29);
        AddChapterButton.TabIndex = 7;
        AddChapterButton.Text = "Add";
        AddChapterButton.UseVisualStyleBackColor = true;
        AddChapterButton.Click += AddChapterButton_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(371, 132);
        label3.Name = "label3";
        label3.Size = new Size(41, 20);
        label3.TabIndex = 8;
        label3.Text = "Title:";
        // 
        // StoryTitleTextBox
        // 
        StoryTitleTextBox.Enabled = false;
        StoryTitleTextBox.Location = new Point(418, 129);
        StoryTitleTextBox.Name = "StoryTitleTextBox";
        StoryTitleTextBox.Size = new Size(306, 27);
        StoryTitleTextBox.TabIndex = 9;
        StoryTitleTextBox.Leave += StoryTitleTextBox_Leave;
        // 
        // ChapterNumberTextBox
        // 
        ChapterNumberTextBox.Enabled = false;
        ChapterNumberTextBox.Location = new Point(443, 354);
        ChapterNumberTextBox.Name = "ChapterNumberTextBox";
        ChapterNumberTextBox.Size = new Size(281, 27);
        ChapterNumberTextBox.TabIndex = 11;
        ChapterNumberTextBox.Validating += ChapterNumberTextBox_Validating;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(371, 357);
        label4.Name = "label4";
        label4.Size = new Size(66, 20);
        label4.TabIndex = 10;
        label4.Text = "Number:";
        // 
        // ChapterTextBox
        // 
        ChapterTextBox.Enabled = false;
        ChapterTextBox.Location = new Point(371, 387);
        ChapterTextBox.Name = "ChapterTextBox";
        ChapterTextBox.Size = new Size(353, 136);
        ChapterTextBox.TabIndex = 12;
        ChapterTextBox.Text = "";
        ChapterTextBox.Validating += ChapterTextBox_Validating;
        // 
        // DeleteStoryButton
        // 
        DeleteStoryButton.Enabled = false;
        DeleteStoryButton.Location = new Point(112, 94);
        DeleteStoryButton.Name = "DeleteStoryButton";
        DeleteStoryButton.Size = new Size(94, 29);
        DeleteStoryButton.TabIndex = 13;
        DeleteStoryButton.Text = "Delete";
        DeleteStoryButton.UseVisualStyleBackColor = true;
        DeleteStoryButton.Click += DeleteStoryButton_Click;
        // 
        // DeleteChapterButton
        // 
        DeleteChapterButton.Enabled = false;
        DeleteChapterButton.Location = new Point(112, 319);
        DeleteChapterButton.Name = "DeleteChapterButton";
        DeleteChapterButton.Size = new Size(94, 29);
        DeleteChapterButton.TabIndex = 14;
        DeleteChapterButton.Text = "Delete";
        DeleteChapterButton.UseVisualStyleBackColor = true;
        DeleteChapterButton.Click += DeleteChapterButton_Click;
        // 
        // NewButton
        // 
        NewButton.Location = new Point(12, 12);
        NewButton.Name = "NewButton";
        NewButton.Size = new Size(94, 29);
        NewButton.TabIndex = 15;
        NewButton.Text = "New";
        NewButton.UseVisualStyleBackColor = true;
        NewButton.Click += NewButton_Click;
        // 
        // EditTextButton
        // 
        EditTextButton.Enabled = false;
        EditTextButton.Location = new Point(630, 529);
        EditTextButton.Name = "EditTextButton";
        EditTextButton.Size = new Size(94, 29);
        EditTextButton.TabIndex = 16;
        EditTextButton.Text = "Edit Text...";
        EditTextButton.UseVisualStyleBackColor = true;
        EditTextButton.Click += EditTextButton_Click;
        // 
        // StoryEditorForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(774, 570);
        Controls.Add(EditTextButton);
        Controls.Add(NewButton);
        Controls.Add(DeleteChapterButton);
        Controls.Add(DeleteStoryButton);
        Controls.Add(ChapterTextBox);
        Controls.Add(ChapterNumberTextBox);
        Controls.Add(label4);
        Controls.Add(StoryTitleTextBox);
        Controls.Add(label3);
        Controls.Add(AddChapterButton);
        Controls.Add(AddStoryButton);
        Controls.Add(SaveButton);
        Controls.Add(label2);
        Controls.Add(ChapterListBox);
        Controls.Add(label1);
        Controls.Add(LoadButton);
        Controls.Add(StoryListBox);
        Name = "StoryEditorForm";
        Text = "StoryEditor";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox StoryListBox;
    private Button LoadButton;
    private Label label1;
    private Label label2;
    private ListBox ChapterListBox;
    private Button SaveButton;
    private Button AddStoryButton;
    private Button AddChapterButton;
    private Label label3;
    private TextBox StoryTitleTextBox;
    private TextBox ChapterNumberTextBox;
    private Label label4;
    private RichTextBox ChapterTextBox;
    private Button DeleteStoryButton;
    private Button DeleteChapterButton;
    private Button NewButton;
    private Button EditTextButton;
}