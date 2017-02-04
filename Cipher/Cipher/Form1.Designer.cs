namespace Cipher
{
    partial class Cipher
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
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.rtbEncryption = new System.Windows.Forms.RichTextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.nudEncryptionKey = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudEncryptionKey)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(0, 59);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(422, 162);
            this.rtbMessage.TabIndex = 4;
            this.rtbMessage.Text = "";
            // 
            // rtbEncryption
            // 
            this.rtbEncryption.Location = new System.Drawing.Point(0, 256);
            this.rtbEncryption.Name = "rtbEncryption";
            this.rtbEncryption.Size = new System.Drawing.Size(422, 162);
            this.rtbEncryption.TabIndex = 5;
            this.rtbEncryption.Text = "";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(0, 227);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(167, 23);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(0, 424);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(167, 23);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "Decipher";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // nudEncryptionKey
            // 
            this.nudEncryptionKey.Location = new System.Drawing.Point(0, 33);
            this.nudEncryptionKey.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudEncryptionKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEncryptionKey.Name = "nudEncryptionKey";
            this.nudEncryptionKey.Size = new System.Drawing.Size(120, 20);
            this.nudEncryptionKey.TabIndex = 8;
            this.nudEncryptionKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Set encryption key:";
            // 
            // Cipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 458);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudEncryptionKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.rtbEncryption);
            this.Controls.Add(this.rtbMessage);
            this.Name = "Cipher";
            this.Text = "Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.nudEncryptionKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.RichTextBox rtbEncryption;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.NumericUpDown nudEncryptionKey;
        private System.Windows.Forms.Label label1;
    }
}