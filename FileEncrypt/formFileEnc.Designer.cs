namespace FileEncrypt
{
    partial class formFileEnc
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
            this.Browse = new System.Windows.Forms.Button();
            this.enCrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textKey = new System.Windows.Forms.TextBox();
            this.textFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Decrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Browse.Location = new System.Drawing.Point(434, 26);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(75, 23);
            this.Browse.TabIndex = 1;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Button1_Click);
            // 
            // enCrypt
            // 
            this.enCrypt.Location = new System.Drawing.Point(434, 57);
            this.enCrypt.Name = "enCrypt";
            this.enCrypt.Size = new System.Drawing.Size(75, 23);
            this.enCrypt.TabIndex = 2;
            this.enCrypt.Text = "EnCrypt";
            this.enCrypt.UseVisualStyleBackColor = true;
            this.enCrypt.Click += new System.EventHandler(this.enCrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "KEY";
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(78, 57);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(331, 21);
            this.textKey.TabIndex = 4;
            // 
            // textFile
            // 
            this.textFile.Location = new System.Drawing.Point(78, 26);
            this.textFile.Name = "textFile";
            this.textFile.Size = new System.Drawing.Size(331, 21);
            this.textFile.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "FILE";
            // 
            // Decrypt
            // 
            this.Decrypt.Location = new System.Drawing.Point(434, 86);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(75, 23);
            this.Decrypt.TabIndex = 7;
            this.Decrypt.Text = "DeCrypt";
            this.Decrypt.UseVisualStyleBackColor = true;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(383, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Encrypt fiel by TripleDES, the output file name is with an \'_\'.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "The same key should be used to encrypt and decrypt.";
            // 
            // formFileEnc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 128);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textFile);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enCrypt);
            this.Controls.Add(this.Browse);
            this.Name = "formFileEnc";
            this.Text = "File Encryptor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button enCrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.TextBox textFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

