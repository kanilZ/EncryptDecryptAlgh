using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShyfryLab1
{
    public partial class Form1 : Form
    {
        Tsezar tsezar;
        public Form1()
        {
            InitializeComponent();
            tsezar = new Tsezar();
        }

      
        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextEncrypt.Text = "";
            richTextDecrypt.Text = "";
            richTextOpen.Text = "";
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            richTextEncrypt.Text = tsezar.Encrypt(richTextOpen.Text);
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            richTextDecrypt.Text = tsezar.Decrypt(richTextEncrypt.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
