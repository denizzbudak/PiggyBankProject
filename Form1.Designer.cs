namespace KumbaraUygulamasi
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.paraTuruComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.kumbaraStatusLabel = new System.Windows.Forms.Label();
            this.sonHacim = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(177, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "PARA AT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // paraTuruComboBox
            // 
            this.paraTuruComboBox.FormattingEnabled = true;
            this.paraTuruComboBox.Location = new System.Drawing.Point(229, 311);
            this.paraTuruComboBox.Name = "paraTuruComboBox";
            this.paraTuruComboBox.Size = new System.Drawing.Size(137, 21);
            this.paraTuruComboBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(488, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "KIR!!!";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kumbaraStatusLabel
            // 
            this.kumbaraStatusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.kumbaraStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kumbaraStatusLabel.Font = new System.Drawing.Font("Berlin Sans FB", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kumbaraStatusLabel.ForeColor = System.Drawing.Color.Green;
            this.kumbaraStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.kumbaraStatusLabel.Name = "kumbaraStatusLabel";
            this.kumbaraStatusLabel.Padding = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.kumbaraStatusLabel.Size = new System.Drawing.Size(596, 415);
            this.kumbaraStatusLabel.TabIndex = 5;
            this.kumbaraStatusLabel.Text = "10 Tl";
            this.kumbaraStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sonHacim
            // 
            this.sonHacim.AutoSize = true;
            this.sonHacim.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonHacim.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.sonHacim.Location = new System.Drawing.Point(9, 9);
            this.sonHacim.Name = "sonHacim";
            this.sonHacim.Size = new System.Drawing.Size(35, 15);
            this.sonHacim.TabIndex = 5;
            this.sonHacim.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PiggyBankProject.Properties.Resources.piggy_bank;
            this.pictureBox1.Location = new System.Drawing.Point(141, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(596, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sonHacim);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.paraTuruComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kumbaraStatusLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox paraTuruComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label kumbaraStatusLabel;
        private System.Windows.Forms.Label sonHacim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

