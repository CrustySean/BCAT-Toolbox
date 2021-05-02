using System;
using System.IO;
using System.Windows.Forms;

namespace BcatToolbox
{
    public partial class Decrypt : Form
    {
        public Decrypt()
        {
            InitializeComponent();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();

            textBox1.Text = openFileDialog1.FileName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // decrypt
            string TitleID = textBox3.Text;

            // check if path is empty
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("You must specify the directory of the encrypted file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // check TID length
            if (TitleID.Length < 16 || string.IsNullOrEmpty(TitleID))
            {
                MessageBox.Show("The inserted Title ID is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ulong TID = Convert.ToUInt64(TitleID);

            // check if passphrase is empty
            if (textBox2.Text.Length < 64 || string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("The inserted Passphrase is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string output = Path.GetDirectoryName(textBox1.Text) + Path.DirectorySeparatorChar + Path.GetFileName(textBox1.Text) + ".decrypted";
            const int size = 0x1000;
            using var file = File.OpenRead(textBox1.Text);
            int bytesRead;
            var buff = new byte[size];
            while ((bytesRead = file.Read(buff, 0, buff.Length)) > 0)
            {
                BCAT.DecryptBCAT(buff, TID, textBox2.Text);

                File.WriteAllBytes(output, buff);
            }
        }
    }
}
