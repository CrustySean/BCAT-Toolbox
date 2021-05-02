
namespace BcatToolbox
{
    partial class Signature
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signature));
            this.button_importFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_import = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_input = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button_importFile
            // 
            this.button_importFile.Location = new System.Drawing.Point(274, 28);
            this.button_importFile.Name = "button_importFile";
            this.button_importFile.Size = new System.Drawing.Size(84, 23);
            this.button_importFile.TabIndex = 11;
            this.button_importFile.Text = "Import from file";
            this.button_importFile.UseVisualStyleBackColor = true;
            this.button_importFile.Click += new System.EventHandler(this.button_importFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input Type";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(156, 296);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(75, 23);
            this.button_import.TabIndex = 9;
            this.button_import.Text = "Import";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Note : Signature size must be 0x100";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_input
            // 
            this.comboBox_input.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_input.FormattingEnabled = true;
            this.comboBox_input.Items.AddRange(new object[] {
            "Hex String",
            "Base64"});
            this.comboBox_input.Location = new System.Drawing.Point(133, 30);
            this.comboBox_input.Name = "comboBox_input";
            this.comboBox_input.Size = new System.Drawing.Size(121, 21);
            this.comboBox_input.TabIndex = 7;
            this.comboBox_input.SelectedIndexChanged += new System.EventHandler(this.comboBox_input_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(13, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 193);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "All Files (*.*)|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Signature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 332);
            this.Controls.Add(this.button_importFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_input);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Signature";
            this.Text = "Signature";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_importFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_input;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}