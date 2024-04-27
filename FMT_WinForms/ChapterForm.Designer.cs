namespace FMT_WinForms;

partial class ChapterForm
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
        label1 = new Label();
        CypterTextBox = new TextBox();
        label2 = new Label();
        ChapterTextBox = new RichTextBox();
        DecryptButton = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(10, 15);
        label1.Name = "label1";
        label1.Size = new Size(58, 20);
        label1.TabIndex = 0;
        label1.Text = "Cypher:";
        // 
        // CypterTextBox
        // 
        CypterTextBox.Location = new Point(74, 12);
        CypterTextBox.Name = "CypterTextBox";
        CypterTextBox.Size = new Size(125, 27);
        CypterTextBox.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 65);
        label2.Name = "label2";
        label2.Size = new Size(39, 20);
        label2.TabIndex = 2;
        label2.Text = "Text:";
        // 
        // ChapterTextBox
        // 
        ChapterTextBox.Location = new Point(12, 88);
        ChapterTextBox.Name = "ChapterTextBox";
        ChapterTextBox.ReadOnly = true;
        ChapterTextBox.Size = new Size(906, 371);
        ChapterTextBox.TabIndex = 3;
        ChapterTextBox.Text = "";
        // 
        // DecryptButton
        // 
        DecryptButton.Location = new Point(205, 12);
        DecryptButton.Name = "DecryptButton";
        DecryptButton.Size = new Size(94, 29);
        DecryptButton.TabIndex = 4;
        DecryptButton.Text = "Decrypt";
        DecryptButton.UseVisualStyleBackColor = true;
        DecryptButton.Click += DecryptButton_Click;
        // 
        // ChapterForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(930, 482);
        Controls.Add(DecryptButton);
        Controls.Add(ChapterTextBox);
        Controls.Add(label2);
        Controls.Add(CypterTextBox);
        Controls.Add(label1);
        Name = "ChapterForm";
        Text = "Chapter";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox CypterTextBox;
    private Label label2;
    private RichTextBox ChapterTextBox;
    private Button DecryptButton;
}