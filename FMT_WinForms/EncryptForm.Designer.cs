namespace FMT_WinForms;

partial class EncryptForm
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
        txtPlainText = new RichTextBox();
        label1 = new Label();
        txtCypher = new TextBox();
        label2 = new Label();
        label3 = new Label();
        txtEncryptedText = new RichTextBox();
        cmdRandomizeCypher = new Button();
        cmdEncrypt = new Button();
        cmdDecrypt = new Button();
        SuspendLayout();
        // 
        // txtPlainText
        // 
        txtPlainText.AcceptsTab = true;
        txtPlainText.Location = new Point(12, 78);
        txtPlainText.Name = "txtPlainText";
        txtPlainText.Size = new Size(1283, 358);
        txtPlainText.TabIndex = 0;
        txtPlainText.Text = "";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 55);
        label1.Name = "label1";
        label1.Size = new Size(72, 20);
        label1.TabIndex = 1;
        label1.Text = "Plain Text";
        // 
        // txtCypher
        // 
        txtCypher.Location = new Point(72, 12);
        txtCypher.Name = "txtCypher";
        txtCypher.Size = new Size(125, 27);
        txtCypher.TabIndex = 2;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(11, 15);
        label2.Name = "label2";
        label2.Size = new Size(55, 20);
        label2.TabIndex = 3;
        label2.Text = "Cypher";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(12, 439);
        label3.Name = "label3";
        label3.Size = new Size(106, 20);
        label3.TabIndex = 5;
        label3.Text = "Encrypted Text";
        // 
        // txtEncryptedText
        // 
        txtEncryptedText.Location = new Point(12, 462);
        txtEncryptedText.Name = "txtEncryptedText";
        txtEncryptedText.Size = new Size(1283, 358);
        txtEncryptedText.TabIndex = 4;
        txtEncryptedText.Text = "";
        // 
        // cmdRandomizeCypher
        // 
        cmdRandomizeCypher.Location = new Point(203, 12);
        cmdRandomizeCypher.Name = "cmdRandomizeCypher";
        cmdRandomizeCypher.Size = new Size(101, 29);
        cmdRandomizeCypher.TabIndex = 6;
        cmdRandomizeCypher.Text = "Randomize";
        cmdRandomizeCypher.UseVisualStyleBackColor = true;
        cmdRandomizeCypher.Click += cmdRandomizeCypher_Click;
        // 
        // cmdEncrypt
        // 
        cmdEncrypt.Location = new Point(12, 826);
        cmdEncrypt.Name = "cmdEncrypt";
        cmdEncrypt.Size = new Size(101, 29);
        cmdEncrypt.TabIndex = 7;
        cmdEncrypt.Text = "Encrypt";
        cmdEncrypt.UseVisualStyleBackColor = true;
        cmdEncrypt.Click += cmdEncrypt_Click;
        // 
        // cmdDecrypt
        // 
        cmdDecrypt.Location = new Point(119, 826);
        cmdDecrypt.Name = "cmdDecrypt";
        cmdDecrypt.Size = new Size(101, 29);
        cmdDecrypt.TabIndex = 8;
        cmdDecrypt.Text = "Decrypt";
        cmdDecrypt.UseVisualStyleBackColor = true;
        cmdDecrypt.Click += cmdDecrypt_Click;
        // 
        // EncryptForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1324, 911);
        Controls.Add(cmdDecrypt);
        Controls.Add(cmdEncrypt);
        Controls.Add(cmdRandomizeCypher);
        Controls.Add(label3);
        Controls.Add(txtEncryptedText);
        Controls.Add(label2);
        Controls.Add(txtCypher);
        Controls.Add(label1);
        Controls.Add(txtPlainText);
        Name = "EncryptForm";
        Text = "Encrypter";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RichTextBox txtPlainText;
    private Label label1;
    private TextBox txtCypher;
    private Label label2;
    private Label label3;
    private RichTextBox txtEncryptedText;
    private Button cmdRandomizeCypher;
    private Button cmdEncrypt;
    private Button cmdDecrypt;
}