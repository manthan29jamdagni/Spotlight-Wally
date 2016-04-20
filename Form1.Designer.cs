namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.checkBox_loc = new System.Windows.Forms.CheckBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.textBox_loc = new System.Windows.Forms.TextBox();
            this.download_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_next = new System.Windows.Forms.Button();
            this.imgPicture = new System.Windows.Forms.PictureBox();
            this.logHandler = new System.Windows.Forms.RichTextBox();
            this.button_about = new System.Windows.Forms.Button();
            this.button_wpsetter = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_loc
            // 
            this.checkBox_loc.AutoSize = true;
            this.checkBox_loc.Location = new System.Drawing.Point(12, 13);
            this.checkBox_loc.Name = "checkBox_loc";
            this.checkBox_loc.Size = new System.Drawing.Size(105, 17);
            this.checkBox_loc.TabIndex = 0;
            this.checkBox_loc.Text = "Custom Location";
            this.checkBox_loc.UseVisualStyleBackColor = true;
            this.checkBox_loc.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // browse_button
            // 
            this.browse_button.Location = new System.Drawing.Point(472, 9);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(113, 23);
            this.browse_button.TabIndex = 1;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // textBox_loc
            // 
            this.textBox_loc.Location = new System.Drawing.Point(123, 11);
            this.textBox_loc.Name = "textBox_loc";
            this.textBox_loc.Size = new System.Drawing.Size(343, 20);
            this.textBox_loc.TabIndex = 2;
            this.textBox_loc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // download_button
            // 
            this.download_button.Location = new System.Drawing.Point(591, 9);
            this.download_button.Name = "download_button";
            this.download_button.Size = new System.Drawing.Size(100, 23);
            this.download_button.TabIndex = 3;
            this.download_button.Text = "Download";
            this.download_button.UseVisualStyleBackColor = true;
            this.download_button.Click += new System.EventHandler(this.download_button_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(66, 315);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(106, 24);
            this.button_next.TabIndex = 6;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgPicture
            // 
            this.imgPicture.Image = global::Spotlight_Wally.Properties.Resources.My;
            this.imgPicture.Location = new System.Drawing.Point(12, 39);
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Size = new System.Drawing.Size(480, 270);
            this.imgPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPicture.TabIndex = 7;
            this.imgPicture.TabStop = false;
            this.imgPicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logHandler
            // 
            this.logHandler.Location = new System.Drawing.Point(499, 39);
            this.logHandler.Name = "logHandler";
            this.logHandler.Size = new System.Drawing.Size(182, 269);
            this.logHandler.TabIndex = 8;
            this.logHandler.Text = "";
            this.logHandler.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(557, 313);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 9;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_wpsetter
            // 
            this.button_wpsetter.Location = new System.Drawing.Point(324, 315);
            this.button_wpsetter.Name = "button_wpsetter";
            this.button_wpsetter.Size = new System.Drawing.Size(100, 23);
            this.button_wpsetter.TabIndex = 10;
            this.button_wpsetter.Text = "Set Wallpaper";
            this.button_wpsetter.UseVisualStyleBackColor = true;
            this.button_wpsetter.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "FitToScreen",
            "Center",
            "Tile"});
            this.listBox1.Location = new System.Drawing.Point(178, 315);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(140, 30);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 348);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_wpsetter);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.logHandler);
            this.Controls.Add(this.imgPicture);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.download_button);
            this.Controls.Add(this.textBox_loc);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.checkBox_loc);
            this.Name = "Form1";
            this.Text = "Spotlight Wallpapers";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_loc;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.TextBox textBox_loc;
        private System.Windows.Forms.Button download_button;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.PictureBox imgPicture;
        private System.Windows.Forms.RichTextBox logHandler;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_wpsetter;
        private System.Windows.Forms.ListBox listBox1;
    }
}

