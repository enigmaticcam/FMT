﻿namespace FMT_WinForms;

partial class StoriesForm
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
        StoriesListBox = new ListBox();
        OpenButton = new Button();
        ResetProgressButton = new Button();
        SuspendLayout();
        // 
        // StoriesListBox
        // 
        StoriesListBox.FormattingEnabled = true;
        StoriesListBox.Location = new Point(12, 12);
        StoriesListBox.Name = "StoriesListBox";
        StoriesListBox.Size = new Size(369, 424);
        StoriesListBox.TabIndex = 0;
        StoriesListBox.SelectedIndexChanged += StoriesListBox_SelectedIndexChanged;
        // 
        // OpenButton
        // 
        OpenButton.Enabled = false;
        OpenButton.Location = new Point(387, 12);
        OpenButton.Name = "OpenButton";
        OpenButton.Size = new Size(94, 29);
        OpenButton.TabIndex = 1;
        OpenButton.Text = "Open";
        OpenButton.UseVisualStyleBackColor = true;
        OpenButton.Click += OpenButton_Click;
        // 
        // ResetProgressButton
        // 
        ResetProgressButton.Location = new Point(665, 12);
        ResetProgressButton.Name = "ResetProgressButton";
        ResetProgressButton.Size = new Size(123, 29);
        ResetProgressButton.TabIndex = 2;
        ResetProgressButton.Text = "Reset Progress";
        ResetProgressButton.UseVisualStyleBackColor = true;
        ResetProgressButton.Click += ResetProgressButton_Click;
        // 
        // StoriesForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(ResetProgressButton);
        Controls.Add(OpenButton);
        Controls.Add(StoriesListBox);
        Name = "StoriesForm";
        Text = "Stories";
        ResumeLayout(false);
    }

    #endregion

    private ListBox StoriesListBox;
    private Button OpenButton;
    private Button ResetProgressButton;
}