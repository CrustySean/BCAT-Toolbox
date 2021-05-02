using MessagePack;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BcatToolbox
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            /* Load a clean layout. */
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;

            Logger.DateAndCheck();

            string b_ver = "BCAT-Toolbox version: " + Utils.version;
            Logger.Info(b_ver, Logger.LogLevel.Info);

            Logger.Info("App started", Logger.LogLevel.Info);

            if (Directory.Exists(Utils.output))
            {
                Logger.Info("Directory already exists", Logger.LogLevel.Info);
            }
            else
            {
                Directory.CreateDirectory(Utils.output + "BCAT-Toolbox");
                Logger.Info("Directory created", Logger.LogLevel.Info);
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fm = new About();
            fm.Show();
        }

        private void selectAFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void decryptBCATDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void titleIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Nintendo Switch (NX) uses the Title IDs protocol to keep tracks of all the apps / games or system modules.\n\nNormal Titles: for Switch are in this format --> *0100*.\nSystem Titles: are in this format --> *010000000000XXXX*.\nGames Title IDs end with *Y000*, with Y being an even digit.\nDLCs end with *YXXX*, with Y being an odd digit, and XXX a DLC ID from 0x000 to 0xFFF.\n\n\nSee more on SwitchBrew.", "Title ID", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void passphraseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nintendo Switch games store in the Control partition a file *control.nacp* which contains various informations about the contents of the specific title.\n\nThe Passphrase is stored at *0x3100* with a size of *0x41* that's used by the game to download BCAT files.\n\n\nSee more on SwitchBrew.", "Passphrase", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void decryptBCATDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form fm = new Decrypt();
            fm.ShowDialog();
        }

        private void encryptBCATDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new Encrypt();
            fm.ShowDialog();
        }

        private void unpackToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox_topicIcon_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you want to save the selected image?", "Save Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.No)
            {
                return;
            }
            else
            {
                folderBrowserDialog1.SelectedPath = "";
                folderBrowserDialog1.ShowDialog();

                var imgarr = Utils.ImageToByteArray(pictureBox_topicIcon.Image);

                var out_ = folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar + pictureBox_topicIcon.Name + ".jpg";

                File.WriteAllBytes(out_, imgarr);

                MessageBox.Show("Successfuly saved the image", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox_topicDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                DialogResult rs = MessageBox.Show("Do you want to save the selected image?", "Save Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }
                else
                {
                    folderBrowserDialog1.SelectedPath = "";
                    folderBrowserDialog1.ShowDialog();

                    var imgarr = Utils.ImageToByteArray(pictureBox1.Image);

                    var out_ = folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar + pictureBox1.Image + ".jpg";

                    File.WriteAllBytes(out_, imgarr);

                    MessageBox.Show("Successfuly saved the image", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void multiSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.ShowDialog();

            if (!string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.msgpack");

                DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] Files = di.GetFiles("*.msgpack");

                DialogResult rs = MessageBox.Show("Are you sure you want to save all the unpacked msgpack?", "Save Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.No)
                {
                    return;

                }
                else if (rs == DialogResult.Yes)
                {

                    foreach (FileInfo file in Files)
                    {

                        Directory.CreateDirectory(folderBrowserDialog1.SelectedPath);

                        var y = folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar + file.Name;
                        var yj = y + ".json";

                        try
                        {
                            var blk = File.ReadAllBytes(y);

                            var dc = MessagePackSerializer.ConvertToJson(blk);

                            /* Check if our data isn't null. */
                            if (dc == null)
                            {
                                MessageBox.Show("Failed to unpack the msgpack to json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                /* Hacky method to get a pretty json. */
                                var t = JsonConvert.DeserializeObject(dc);
                                var x = JsonConvert.SerializeObject(t, Formatting.Indented);

                                string sPrettyStr = JToken.Parse(dc).ToString(Formatting.Indented); ;

                                string dec_out = sPrettyStr;

                                /* Remove the output file if it already exists. */
                                if (File.Exists(yj))
                                {
                                    File.Delete(yj);
                                }

                                File.WriteAllText(yj, dec_out);

                            }

                        }
                        catch (Exception exc)
                        {
                            string exception = "Exception: " + exc.Message;

                            Logger.Error(exception, Logger.LogLevel.Error);
                        }
                    }

                    MessageBox.Show("Files successfully saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void normalSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Msgpack files (*.msgpack)|*.msgpack|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;

            if (openFileDialog1.FileName.Contains(".msgpack"))
            {

                byte[] ix = File.ReadAllBytes(path);

                using MemoryStream stream = new MemoryStream(ix);

                var iq = Utils.ReadFile(path);

                var dec = MessagePackSerializer.ConvertToJson(iq);

                if (dec == null)
                {
                    MessageBox.Show("Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DialogResult rs = MessageBox.Show("Do you want to save the unpacked msgpack?", "Save Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.No)
                {
                    return;

                }
                else if (rs == DialogResult.Yes)
                {

                    /* Check if our data isn't null. */
                    if (dec == null)
                    {
                        MessageBox.Show("Failed to unpack the msgpack to json", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        /* Hacky method to get a pretty json. */
                        var item = dec;

                        var t = JsonConvert.DeserializeObject(item);
                        var x = JsonConvert.SerializeObject(t, Formatting.Indented);

                        var item2 = dec;
                        string sPrettyStr = JToken.Parse(item2).ToString(Formatting.Indented); ;

                        string dec_out = sPrettyStr;
                        string path_out = Path.GetDirectoryName(path) + Path.DirectorySeparatorChar + Path.GetFileName(path) + ".json";

                        /* Remove the output file if it already exists:*/
                        if (File.Exists(path_out))
                        {
                            File.Delete(path_out);
                        }

                        File.WriteAllText(path_out, dec_out);

                        MessageBox.Show("File successfully saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                DialogResult rs = MessageBox.Show("Do you want to save the selected image?", "Save Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.No)
                {
                    return;
                }
                else
                {
                    folderBrowserDialog1.SelectedPath = "";
                    folderBrowserDialog1.ShowDialog();

                    var imgarr = Utils.ImageToByteArray(pictureBox2.Image);

                    var out_ = folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar + pictureBox2.Image + ".jpg";

                    File.WriteAllBytes(out_, imgarr);

                    MessageBox.Show("Successfuly saved the image", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var OVersion = "https://github.com/CrustySean/StarlionFiles/raw/main/BT.txt";
            var Version = Utils.version + "\n"; /* "\n" is needed cause for some reasons the downloaded file comes with a second line instead of just 1. */

            string BTexe = Assembly.GetExecutingAssembly().Location;
            string appPath = Path.GetDirectoryName(BTexe);

            string c_out = appPath + Path.DirectorySeparatorChar + "BT" + ".txt"; /* BT == Bcat Toolbox. */

            using var client = new WebClient();

            client.DownloadFile(OVersion, c_out);

            string upd = File.ReadAllText(c_out);

            if (upd != Version)
            {
                Process.Start("https://github.com/CrustySean/BCAT-Toolbox/releases");
            }
            else
            {
                MessageBox.Show("BCAT-Toolbox is up to date", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            /* Delete the downloaded file. */
            if (File.Exists(c_out))
            {
                File.Delete(c_out);
            }
        }

        private void bCATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BCAT (Background Content Asymmetric synchronized delivery and Transmission) encompasses a set of content download/upload related services.\n\nSee more on SwitchBrew.", "BCAT", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void prepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prepo (Player Report) is a part of BCAT\n\nIt uploads system and user information to a cloud server.\n\nPrepo --> Game Player Report.\n\nSrepo --> System Report.\n\n\nSee more on SwitchBrew.", "Prepo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void textBox1_TextChanged_4(object sender, EventArgs e)
        {
        }

        private void packToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox_topicIcon.SizeMode = PictureBoxSizeMode.Zoom;

            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Msgpack files (*.msgpack)|*.msgpack|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            /* load msgpack. */
            var obj = openFileDialog1.FileName;

            try
            {
                var msg = File.ReadAllBytes(obj);

                var ix = NewsR.Deserialize(msg);

                Stream ms = new MemoryStream(ix.TopicImage);

                pictureBox_topicIcon.Image = Image.FromStream(ms);

                var tp_name = ix.TopicName;
                var tp_pub = ix.TopicPublisher;
                var tp_id = ix.TopicId;

                int date = unchecked((int)ix.PublishTime);

                var publishDate = DateTimeOffset.FromUnixTimeSeconds(date).DateTime.ToString();

                var lang = ix.Language;
                var d_type = ix.DisplayType;
                var prior = ix.Priority;

                var b_text = "";
                var movie = "";

                foreach (var athing in ix.Bodies)
                {
                    // not sure
                    if (athing.MainImage != athing.MainImage)
                    {
                        var xt = Utils.Base64ToImage(athing.MainImage.ToString());
                        pictureBox1.Image = xt;

                    }
                    else
                    {
                        Stream xn = new MemoryStream(athing.MainImage);

                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox1.Image = Image.FromStream(xn);
                    }

                    b_text = athing.Text;
                    movie = athing.MovieUrl;
                }

                var TopicName = "\nTopicName :" + tp_name;
                var TopicPubl = "\n\nTopic Publisher: " + tp_pub;
                var TopicID = "\n\nTopic ID: " + tp_id;
                var Language = "\n\nLanguage: " + lang;
                var PublishD = "\n\nPublish Date: " + publishDate;
                var DisplayType = "\n\nDisplay Type: " + d_type;
                var Priority = "\n\nPriority: " + prior;
                var MovieURL = "\n\nMovieURL: " + movie;
                var BodyText = "\n\nMainText: \n" + b_text;

                string all = TopicName + TopicPubl + TopicID + Language + PublishD + DisplayType + Priority + MovieURL + BodyText;

                richTextBox1.Visible = true;
                richTextBox2.Visible = true;

                richTextBox1.Text = all;
                richTextBox2.Text = "\n" + ix.TopicDescription;

                Stream xs = new MemoryStream(ix.ListImage);

                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox2.Image = Image.FromStream(xs);

            }
            catch (Exception ex)
            {
                string exception = "Exception: " + ex.Message;

                Logger.Error(exception, Logger.LogLevel.Error);
            }
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void bugyoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "";
            folderBrowserDialog1.ShowDialog();

            try
            {
                DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] Files = di.GetFiles("*.json");

                string path;
                string key;
                string ftxt;
                string[] URLs;
                string value;
                List<string> results = new List<string>();

                var cpath = folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar + "bugyo.txt";

                if (File.Exists(cpath))
                {
                    File.Delete(cpath);
                }

                foreach (FileInfo file in Files)
                {
                    path = folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar + file.Name;
                    using StreamWriter sw = new StreamWriter(cpath, true);

                    key = "bugyo";
                    URLs = File.ReadAllLines(path);

                    foreach (string ln in URLs)
                    {
                        if (ln.Contains(key))
                        {
                            results.Add(ln);
                            value = ln.Replace("\"movie_url\":\"", " ").Replace("\",", " ").Trim();
                            ftxt = file.Name + " " + "-->" + value + "\n";
                            sw.WriteLine(ftxt);
                        }
                    }
                }
            }
            catch (Exception exc)
            {
                string exception = "Exception: " + exc.Message;

                Logger.Error(exception, Logger.LogLevel.Error);
            }
        }

        private void normalSelectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialog1.ShowDialog();

            if (!openFileDialog1.FileName.Contains("json"))
            {
                MessageBox.Show("Make sure to select a json file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    var path = Path.GetDirectoryName(openFileDialog1.FileName) + Path.DirectorySeparatorChar + Path.GetFileName(openFileDialog1.FileName) + " .msgpack";
                    var jsonToLoad = File.ReadAllText(openFileDialog1.FileName);

                    // json doesn't support binary data which is why the msgpack to json converter converted the image to base64
                    var serializedFromJson = MessagePackSerializer.ConvertFromJson(jsonToLoad, MessagePack.Resolvers.ContractlessStandardResolver.Options);
                    File.WriteAllBytes(path, serializedFromJson);

                }
                catch (Exception exce)
                {
                    string exception = "Exception: " + exce.Message;

                    Logger.Error(exception, Logger.LogLevel.Error);
                }
            }
        }

        private void multiSelectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "";
            folderBrowserDialog1.ShowNewFolderButton = false;
            folderBrowserDialog1.ShowDialog();

            if (!string.IsNullOrWhiteSpace(folderBrowserDialog1.SelectedPath))
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath, "*.json");

                DirectoryInfo di = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                FileInfo[] Files = di.GetFiles("*.json");

                DialogResult rs = MessageBox.Show("Are you sure you want to save all the packed json?", "Save Dialog", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (rs == DialogResult.No)
                {
                    return;

                }
                else if (rs == DialogResult.Yes)
                {
                    foreach (FileInfo file in Files)
                    {
                        Directory.CreateDirectory(folderBrowserDialog1.SelectedPath);

                        var y = folderBrowserDialog1.SelectedPath + Path.DirectorySeparatorChar + file.Name;
                        var yj = y + ".msgpack";

                        try
                        {
                            var blk = File.ReadAllText(y);
                            var dec_out = MessagePackSerializer.ConvertFromJson(blk);

                            /* Check if our data isn't null. */
                            if (dec_out == null)
                            {
                                MessageBox.Show("Failed to pack json to msgpack", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                /* Remove the output file if it already exists. */
                                if (File.Exists(yj))
                                {
                                    File.Delete(yj);
                                }

                                File.WriteAllBytes(yj, dec_out);
                            }

                        }
                        catch (Exception exce)
                        {
                            MessageBox.Show(exce.Message, "Exception");
                        }
                    }

                    MessageBox.Show("Files successfully saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string p = Utils.output + Path.DirectorySeparatorChar + "log.txt";

            if (File.Exists(p))
            {

                File.Delete(p);
                MessageBox.Show("Successfully cleared the log file", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else
            {
                MessageBox.Show("There isn't any lof file to clear!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
