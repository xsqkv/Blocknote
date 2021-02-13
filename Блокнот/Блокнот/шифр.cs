using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Блокнот
{
    public partial class шифр : Form
    {
        public шифр()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Update();
            richTextBox2.Update();
            if (domainUpDown1.Text == "MD5")
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                string pass = richTextBox1.Text;
                byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                richTextBox2.Text = result.ToString();
            }
            if (domainUpDown1.Text == "ASCII")
            {
                byte[] bytes = Encoding.ASCII.GetBytes(richTextBox1.Text);
                int result = BitConverter.ToInt32(bytes, 0);
                richTextBox2.Text = result.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void domainUpDown1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void шифр_Load(object sender, EventArgs e)
        {
            DomainUpDown.DomainUpDownItemCollection collection = this.domainUpDown1.Items;
            collection.Add("ASCII");
            collection.Add("HEX");
            collection.Add("Base64");
            collection.Add("Base32");
            collection.Add("RSI");
            collection.Add("MD5");
        }
    }
}
