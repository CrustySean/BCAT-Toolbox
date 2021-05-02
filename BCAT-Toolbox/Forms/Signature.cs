using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace BcatToolbox
{
    public partial class Signature : Form
    {
        public byte[] Sig;
        static bool correct = false;
        public Signature()
        {
            InitializeComponent();
        }

        // ICON == https://www.flaticon.com/free-icon/signature-with-a-pen_1180

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox_input.SelectedIndex)
                {
                    case 0: //hex string
                        Sig = Utils.HexToBytes(textBox1.Text);
                        correct = (Sig.Length == 0x100);
                        break;
                    case 1: //base64
                        Sig = Convert.FromBase64String(textBox1.Text);
                        correct = (Sig.Length == 0x100);
                        break;
                }
            }
            catch { }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_import_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_input_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
        }

        private void button_importFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Utils.BytesToHex(File.ReadAllBytes(openFileDialog1.FileName), " ");
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
