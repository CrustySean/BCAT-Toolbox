using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BcatToolbox
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
            ReadLogs();
        }

        private void ReadLogs()
        {
            // check if logs exixts
            string logs = Utils.output + Path.DirectorySeparatorChar + "log.txt";
            if (!File.Exists(logs))
            {
                MessageBox.Show("No log file was found");
            }
            else
            {
                var str = File.ReadAllText(logs);
                richTextBox1.Text = str;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
