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
        IEncrDecr encrDecr;
        public Form1()
        {
            InitializeComponent();
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextEncrypt.Text = "";
            richTextDecrypt.Text = "";
            richTextOpen.Text = "";
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (!NotSelectedItem())
            {
                richTextEncrypt.Text = encrDecr.Encrypt(richTextOpen.Text);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (!NotSelectedItem())
            {
                richTextDecrypt.Text = encrDecr.Decrypt(richTextEncrypt.Text);
            }
        }
        private bool NotSelectedItem()
        {
            if (comboMethods.SelectedItem == null)
            {
                MessageBox.Show("Метод не вибраний!");
                return true;
            }
            return false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboMethods_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboMethods.SelectedItem.ToString())
            {
                case "Цезаря":
                    encrDecr = new Tsezar();
                    EnableElem(false);
                    break;

                case "Заміни":
                    encrDecr = new SwapMethod();
                    EnableElem(false);
                    break;

                case "Перестановки":                   
                    EnableElem(true);
                    buttonEncrypt.Enabled = false;
                    break;

                default:
                    MessageBox.Show("Нічого не вибрано");
                    break;
            }
        }

       private void EnableElem(bool need)
        {
            textBox.Enabled = need;
            buttonKey.Enabled = need;
        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            encrDecr = new ShuffleMethod(textBox.Text);
            buttonEncrypt.Enabled = true;
            EnableElem(false);
        }
    }
}
