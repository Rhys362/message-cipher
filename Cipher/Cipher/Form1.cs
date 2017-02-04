//A simple Windows form app which encrypts the user's input and allows another user to decipher message if encryption key is shared

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Cipher
{
    public partial class Cipher : Form
    {
        public Cipher()
        {
            InitializeComponent();
        }


        //Takes user's input from rich text box 1 and passes encrypted message to rich text box 2
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            rtbEncryption.Text = "";
            foreach (char c in rtbMessage.Text)
            {

                char encrypted = (char)(c + nudEncryptionKey.Value);//Changes characters in message by value of numerical up down box as selected by user 
                rtbEncryption.Text += encrypted.ToString();

            }
        }


        //Performs the same function as above code only in reverse so a user can decode an encrypted message they have received
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            rtbMessage.Text = "";
            foreach (char c in rtbEncryption.Text)
            {

                char encrypted = (char)(c - nudEncryptionKey.Value);
                rtbMessage.Text += encrypted.ToString();
            }
        }
    }
}