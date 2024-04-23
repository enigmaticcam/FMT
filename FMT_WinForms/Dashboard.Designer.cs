namespace FMT_WinForms;

partial class Dashboard
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
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(cmdEncrypt);
        Name = "Dashboard";
        Text = "Dashboard";
        ResumeLayout(false);
    }

    #endregion

    private Button cmdEncrypt;
}
