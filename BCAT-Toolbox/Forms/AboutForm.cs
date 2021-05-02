using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace BcatToolbox
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
            Region rg = new Region(gp);
            pictureBox1.Region = rg;
            pictureBox2.Region = rg;
            pictureBox3.Region = rg;
            pictureBox4.Region = rg;
            pictureBox5.Region = rg;
            pictureBox_topicIcon.Region = rg;


            Image c_img = Utils.DownloadImageFromUrl("https://pbs.twimg.com/profile_images/1328962469239394306/hO27qAoB_400x400.jpg");
            pictureBox_topicIcon.Image = c_img;

            Image s_img = Utils.DownloadImageFromUrl("https://pbs.twimg.com/profile_images/1079505658494369792/bqSfzLLw_400x400.jpg");
            pictureBox2.Image = s_img;

            Image n_img = Utils.DownloadImageFromUrl("https://pbs.twimg.com/profile_images/1112788774952599553/dfJHXyre_400x400.jpg");
            pictureBox1.Image = n_img;

            Image r_img = Utils.DownloadImageFromUrl("https://pbs.twimg.com/profile_images/940832199661760513/6Y2NDlOW_400x400.jpg");
            pictureBox3.Image = r_img;

            Image i_img = Utils.DownloadImageFromUrl("https://pbs.twimg.com/profile_images/1373615019397632000/dnD05hKj_400x400.jpg");
            pictureBox4.Image = i_img;

            Image sb_img = Utils.DownloadImageFromUrl("https://pbs.twimg.com/profile_images/1346362345933713408/qZGLqj1x_400x400.jpg");
            pictureBox5.Image = sb_img;
        }

        private void pictureBox_topicIcon_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/CrustySean_");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Shadowninja108");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Random6457");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Nkrapivindev");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/Ivydrinkscoffee");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/OatmealDome");
        }

    }
}
