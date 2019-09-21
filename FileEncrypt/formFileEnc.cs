using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace FileEncrypt
{
    public partial class formFileEnc : Form
    {

        private OpenFileDialog openFileDialog1;
        public formFileEnc()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            // Display the openFile dialog.
            DialogResult result = openFileDialog1.ShowDialog();

            // OK button was pressed.
            if (result == DialogResult.OK)
            {
                this.textFile.Text = openFileDialog1.FileName;

                Invalidate();
            }

            // Cancel button was pressed.
            else if (result == DialogResult.Cancel)
            {
                return;
            }

        }

        struct tDes{
            public string inName;
            public string outName;
            public byte[] desKey;
            public byte[] desIV;
        };

      //  private static void EncryptFile(String inName, String outName, byte[] desKey, byte[] desIV)
        private static void EncryptFile(object param)
        {
            tDes td = (tDes)param;
            //Create the file streams to handle the input and output files.  
            FileStream fin = new FileStream(td.inName, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(td.outName, FileMode.OpenOrCreate, FileAccess.Write);
            fout.SetLength(0);
            //Create variables to help with read and write.  
            byte[] bin = new byte[100]; //This is intermediate storage for the encryption.  
            long rdlen = 0; //This is the total number of bytes written.  
            long totlen = fin.Length; //This is the total length of the input file.  
            int len; //This is the number of bytes to be written at a time.  
            try
            {
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                CryptoStream encStream = new CryptoStream(fout, tdes.CreateEncryptor(td.desKey, td.desIV), CryptoStreamMode.Write);


                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                    len = fin.Read(bin, 0, 100);
                    encStream.Write(bin, 0, len);
                    rdlen = rdlen + len;
                }
                encStream.Close();
                fout.Close();
                fin.Close();
                MessageBox.Show("finshed.");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                fout.Close();
                fin.Close();
                Thread.CurrentThread.Abort();
            }
        }
        private static void DecryptFile(object param)
        {
            tDes td = (tDes)param;
            //Create the file streams to handle the input and output files.  
            FileStream fin = new FileStream(td.inName, FileMode.Open, FileAccess.Read);
            FileStream fout = new FileStream(td.outName, FileMode.OpenOrCreate, FileAccess.Write);
            fout.SetLength(0);
            //Create variables to help with read and write.  
            byte[] bin = new byte[100]; //This is intermediate storage for the encryption.  
            long rdlen = 0; //This is the total number of bytes written.  
            long totlen = fin.Length; //This is the total length of the input file.  
            int len; //This is the number of bytes to be written at a time.  
            try
            {
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                CryptoStream decStream = new CryptoStream(fout, tdes.CreateDecryptor(td.desKey, td.desIV), CryptoStreamMode.Write);
          
        

                //Read from the input file, then encrypt and write to the output file.
                while (rdlen < totlen)
                {
                   len = fin.Read(bin, 0, 100);
                   decStream.Write(bin, 0, len);
                   rdlen = rdlen + len;
                }
                decStream.Close();
                fout.Close();
                fin.Close();
                MessageBox.Show("finshed.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                fout.Close();
                fin.Close();
                Thread.CurrentThread.Abort();
            }
        }
        private void enCrypt_Click(object sender, EventArgs e)
        {
            //   byte[] key= Encoding.Unicode.GetBytes(textKey.Text);

        
            if (textKey.TextLength == 0 || textFile.TextLength == 0)
            {
                MessageBox.Show("Please select file and input a key.");

            }
            else
            {
                tDes td = new tDes();
                td.desKey = new byte[24];
                td.desIV = new byte[8];
                StringBuilder sb = new StringBuilder("", 32);
                do
                {
                    sb.Append(textKey.Text);

                } while (sb.Length < 32);
                Encoding.UTF8.GetBytes(sb.ToString(), 0, 24, td.desKey, 0);
                Encoding.UTF8.GetBytes(sb.ToString(), 24, 8, td.desIV, 0);

                td.inName = textFile.Text;
                td.outName = textFile.Text + "_";
                Thread th = new Thread(EncryptFile);
                th.Start(td);
               
                               
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            

         
            if (textKey.TextLength == 0 || textFile.TextLength == 0)
            {
                MessageBox.Show("Please select file and input a key.");

            }
            else
            {
                tDes td = new tDes();
                td.desKey = new byte[24];
                td.desIV = new byte[8];
                StringBuilder sb = new StringBuilder("", 32);
                do
                {
                    sb.Append(textKey.Text);

                } while (sb.Length < 32);
                Encoding.UTF8.GetBytes(sb.ToString(), 0, 24, td.desKey, 0);
                Encoding.UTF8.GetBytes(sb.ToString(), 24, 8, td.desIV, 0);

                td.inName = textFile.Text;
                td.outName = textFile.Text + "_";
                Thread th = new Thread(DecryptFile);
                th.Start(td);
                   
                                  
            }
        }
    }
}
