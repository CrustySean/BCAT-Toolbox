using System;
using System.IO;
using System.Windows.Forms;

namespace BcatToolbox
{
    public partial class Encrypt : Form
    {
        private byte[] Sig = new byte[0x100];
        public Encrypt()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            openFileDialog1.FileName = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte crypto = 0, hashType = 0;
            crypto = (byte)comboBox_crypto.SelectedIndex;
            hashType = (byte)comboBox_sha.SelectedIndex;

            var data = File.ReadAllBytes(openFileDialog1.FileName);
            if (data == null)
            {
                MessageBox.Show("Data is null!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var tid = Convert.ToUInt64(textBox2.Text);
                byte[] enc = BCAT.EncryptBCAT(data, tid, textBox3.Text, hashType, crypto, Sig);

                var output = Path.GetDirectoryName(openFileDialog1.FileName) + Path.DirectorySeparatorChar + Path.GetFileName(openFileDialog1.FileName) + "";
                File.WriteAllBytes(output, enc);
            }

        }

        private void comboBox_crypto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_importSign_Click(object sender, EventArgs e)
        {
            Signature fm = new Signature();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                Sig = fm.Sig;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
