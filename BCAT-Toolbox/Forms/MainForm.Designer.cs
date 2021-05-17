namespace BcatToolbox
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugyoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msgpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unpackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiSelectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalSelectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bCATContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decryptBCATDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptBCATDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passphraseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bCATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_topicIcon = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewLogsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_topicIcon)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.msgpackToolStripMenuItem,
            this.bCATContainerToolStripMenuItem,
            this.logsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.bugyoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testToolStripMenuItem.Text = "Open News";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // bugyoToolStripMenuItem
            // 
            this.bugyoToolStripMenuItem.Name = "bugyoToolStripMenuItem";
            this.bugyoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bugyoToolStripMenuItem.Text = "Bugyo";
            this.bugyoToolStripMenuItem.Click += new System.EventHandler(this.bugyoToolStripMenuItem_Click);
            // 
            // msgpackToolStripMenuItem
            // 
            this.msgpackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unpackToolStripMenuItem,
            this.packToolStripMenuItem});
            this.msgpackToolStripMenuItem.Name = "msgpackToolStripMenuItem";
            this.msgpackToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.msgpackToolStripMenuItem.Text = "Msgpack";
            // 
            // unpackToolStripMenuItem
            // 
            this.unpackToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multiSelectionToolStripMenuItem,
            this.normalSelectionToolStripMenuItem});
            this.unpackToolStripMenuItem.Name = "unpackToolStripMenuItem";
            this.unpackToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.unpackToolStripMenuItem.Text = "Unpack";
            this.unpackToolStripMenuItem.Click += new System.EventHandler(this.unpackToolStripMenuItem_Click);
            // 
            // multiSelectionToolStripMenuItem
            // 
            this.multiSelectionToolStripMenuItem.Name = "multiSelectionToolStripMenuItem";
            this.multiSelectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.multiSelectionToolStripMenuItem.Text = "Multi Selection";
            this.multiSelectionToolStripMenuItem.Click += new System.EventHandler(this.multiSelectionToolStripMenuItem_Click);
            // 
            // normalSelectionToolStripMenuItem
            // 
            this.normalSelectionToolStripMenuItem.Name = "normalSelectionToolStripMenuItem";
            this.normalSelectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.normalSelectionToolStripMenuItem.Text = "Normal Selection";
            this.normalSelectionToolStripMenuItem.Click += new System.EventHandler(this.normalSelectionToolStripMenuItem_Click);
            // 
            // packToolStripMenuItem
            // 
            this.packToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.multiSelectionToolStripMenuItem1,
            this.normalSelectionToolStripMenuItem1});
            this.packToolStripMenuItem.Name = "packToolStripMenuItem";
            this.packToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.packToolStripMenuItem.Text = "Pack";
            this.packToolStripMenuItem.Click += new System.EventHandler(this.packToolStripMenuItem_Click);
            // 
            // multiSelectionToolStripMenuItem1
            // 
            this.multiSelectionToolStripMenuItem1.Name = "multiSelectionToolStripMenuItem1";
            this.multiSelectionToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.multiSelectionToolStripMenuItem1.Text = "Multi Selection";
            this.multiSelectionToolStripMenuItem1.Click += new System.EventHandler(this.multiSelectionToolStripMenuItem1_Click);
            // 
            // normalSelectionToolStripMenuItem1
            // 
            this.normalSelectionToolStripMenuItem1.Name = "normalSelectionToolStripMenuItem1";
            this.normalSelectionToolStripMenuItem1.Size = new System.Drawing.Size(165, 22);
            this.normalSelectionToolStripMenuItem1.Text = "Normal Selection";
            this.normalSelectionToolStripMenuItem1.Click += new System.EventHandler(this.normalSelectionToolStripMenuItem1_Click);
            // 
            // bCATContainerToolStripMenuItem
            // 
            this.bCATContainerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decryptBCATDataToolStripMenuItem1,
            this.encryptBCATDataToolStripMenuItem});
            this.bCATContainerToolStripMenuItem.Name = "bCATContainerToolStripMenuItem";
            this.bCATContainerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bCATContainerToolStripMenuItem.Text = "Container";
            // 
            // decryptBCATDataToolStripMenuItem1
            // 
            this.decryptBCATDataToolStripMenuItem1.Name = "decryptBCATDataToolStripMenuItem1";
            this.decryptBCATDataToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.decryptBCATDataToolStripMenuItem1.Text = "Decrypt Data";
            this.decryptBCATDataToolStripMenuItem1.Click += new System.EventHandler(this.decryptBCATDataToolStripMenuItem1_Click);
            // 
            // encryptBCATDataToolStripMenuItem
            // 
            this.encryptBCATDataToolStripMenuItem.Name = "encryptBCATDataToolStripMenuItem";
            this.encryptBCATDataToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.encryptBCATDataToolStripMenuItem.Text = "Encrypt Data";
            this.encryptBCATDataToolStripMenuItem.Click += new System.EventHandler(this.encryptBCATDataToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationsToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // informationsToolStripMenuItem
            // 
            this.informationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleIDToolStripMenuItem,
            this.passphraseToolStripMenuItem,
            this.bCATToolStripMenuItem,
            this.prepoToolStripMenuItem});
            this.informationsToolStripMenuItem.Name = "informationsToolStripMenuItem";
            this.informationsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.informationsToolStripMenuItem.Text = "Informations";
            // 
            // titleIDToolStripMenuItem
            // 
            this.titleIDToolStripMenuItem.Name = "titleIDToolStripMenuItem";
            this.titleIDToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.titleIDToolStripMenuItem.Text = "Title ID";
            this.titleIDToolStripMenuItem.Click += new System.EventHandler(this.titleIDToolStripMenuItem_Click);
            // 
            // passphraseToolStripMenuItem
            // 
            this.passphraseToolStripMenuItem.Name = "passphraseToolStripMenuItem";
            this.passphraseToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.passphraseToolStripMenuItem.Text = "Passphrase";
            this.passphraseToolStripMenuItem.Click += new System.EventHandler(this.passphraseToolStripMenuItem_Click);
            // 
            // bCATToolStripMenuItem
            // 
            this.bCATToolStripMenuItem.Name = "bCATToolStripMenuItem";
            this.bCATToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.bCATToolStripMenuItem.Text = "BCAT";
            this.bCATToolStripMenuItem.Click += new System.EventHandler(this.bCATToolStripMenuItem_Click);
            // 
            // prepoToolStripMenuItem
            // 
            this.prepoToolStripMenuItem.Name = "prepoToolStripMenuItem";
            this.prepoToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.prepoToolStripMenuItem.Text = "Prepo";
            this.prepoToolStripMenuItem.Click += new System.EventHandler(this.prepoToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Controls.Add(this.richTextBox1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.pictureBox_topicIcon);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(949, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "News Viewer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox2.Location = new System.Drawing.Point(304, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox2.Location = new System.Drawing.Point(67, 18);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(516, 49);
            this.richTextBox2.TabIndex = 17;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Location = new System.Drawing.Point(598, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(310, 289);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox1.Location = new System.Drawing.Point(12, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox_topicIcon
            // 
            this.pictureBox_topicIcon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pictureBox_topicIcon.Location = new System.Drawing.Point(12, 18);
            this.pictureBox_topicIcon.Name = "pictureBox_topicIcon";
            this.pictureBox_topicIcon.Size = new System.Drawing.Size(49, 49);
            this.pictureBox_topicIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_topicIcon.TabIndex = 13;
            this.pictureBox_topicIcon.TabStop = false;
            this.pictureBox_topicIcon.Click += new System.EventHandler(this.pictureBox_topicIcon_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 428);
            this.tabControl1.TabIndex = 1;
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogsToolStripMenuItem1,
            this.viewLogsToolStripMenuItem1});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // clearLogsToolStripMenuItem1
            // 
            this.clearLogsToolStripMenuItem1.Name = "clearLogsToolStripMenuItem1";
            this.clearLogsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.clearLogsToolStripMenuItem1.Text = "Clear Logs";
            this.clearLogsToolStripMenuItem1.Click += new System.EventHandler(this.clearLogsToolStripMenuItem1_Click);
            // 
            // viewLogsToolStripMenuItem1
            // 
            this.viewLogsToolStripMenuItem1.Name = "viewLogsToolStripMenuItem1";
            this.viewLogsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.viewLogsToolStripMenuItem1.Text = "View Logs";
            this.viewLogsToolStripMenuItem1.Click += new System.EventHandler(this.viewLogsToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 368);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "BCAT Toolbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_topicIcon)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem informationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passphraseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem msgpackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bCATContainerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decryptBCATDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem encryptBCATDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unpackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bCATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prepoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalSelectionToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_topicIcon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem bugyoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiSelectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem normalSelectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewLogsToolStripMenuItem1;
    }
}

