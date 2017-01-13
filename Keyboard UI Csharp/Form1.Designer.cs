namespace Keyboard_UI_Csharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.labelRed = new System.Windows.Forms.Label();
            this.numericUpDownRed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGreen = new System.Windows.Forms.NumericUpDown();
            this.labelGreen = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.numericUpDownBlue = new System.Windows.Forms.NumericUpDown();
            this.labelBlue = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.key1 = new System.Windows.Forms.PictureBox();
            this.key2 = new System.Windows.Forms.PictureBox();
            this.key3 = new System.Windows.Forms.PictureBox();
            this.key4 = new System.Windows.Forms.PictureBox();
            this.key5 = new System.Windows.Forms.PictureBox();
            this.key9 = new System.Windows.Forms.PictureBox();
            this.key8 = new System.Windows.Forms.PictureBox();
            this.key7 = new System.Windows.Forms.PictureBox();
            this.key6 = new System.Windows.Forms.PictureBox();
            this.key13 = new System.Windows.Forms.PictureBox();
            this.key12 = new System.Windows.Forms.PictureBox();
            this.key11 = new System.Windows.Forms.PictureBox();
            this.key10 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.key10)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(128, 49);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(104, 45);
            this.trackBarRed.TabIndex = 0;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(83, 49);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(15, 13);
            this.labelRed.TabIndex = 1;
            this.labelRed.Text = "R";
            // 
            // numericUpDownRed
            // 
            this.numericUpDownRed.Location = new System.Drawing.Point(260, 49);
            this.numericUpDownRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownRed.Name = "numericUpDownRed";
            this.numericUpDownRed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRed.TabIndex = 2;
            this.numericUpDownRed.ValueChanged += new System.EventHandler(this.numericUpDownRed_ValueChanged);
            // 
            // numericUpDownGreen
            // 
            this.numericUpDownGreen.Location = new System.Drawing.Point(260, 100);
            this.numericUpDownGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownGreen.Name = "numericUpDownGreen";
            this.numericUpDownGreen.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGreen.TabIndex = 5;
            this.numericUpDownGreen.ValueChanged += new System.EventHandler(this.numericUpDownGreen_ValueChanged);
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(83, 100);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(15, 13);
            this.labelGreen.TabIndex = 4;
            this.labelGreen.Text = "G";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(128, 100);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(104, 45);
            this.trackBarGreen.TabIndex = 3;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // numericUpDownBlue
            // 
            this.numericUpDownBlue.Location = new System.Drawing.Point(260, 151);
            this.numericUpDownBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownBlue.Name = "numericUpDownBlue";
            this.numericUpDownBlue.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownBlue.TabIndex = 8;
            this.numericUpDownBlue.ValueChanged += new System.EventHandler(this.numericUpDownBlue_ValueChanged);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(83, 151);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(14, 13);
            this.labelBlue.TabIndex = 7;
            this.labelBlue.Text = "B";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(128, 151);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(104, 45);
            this.trackBarBlue.TabIndex = 6;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(305, 209);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 9;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // key1
            // 
            this.key1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key1.Image = ((System.Drawing.Image)(resources.GetObject("key1.Image")));
            this.key1.Location = new System.Drawing.Point(50, 260);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(50, 50);
            this.key1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key1.TabIndex = 10;
            this.key1.TabStop = false;
            this.key1.Tag = 1;
            this.key1.Click += new System.EventHandler(this.key_Click);
            // 
            // key2
            // 
            this.key2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key2.Image = ((System.Drawing.Image)(resources.GetObject("key2.Image")));
            this.key2.Location = new System.Drawing.Point(115, 260);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(50, 50);
            this.key2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key2.TabIndex = 11;
            this.key2.TabStop = false;
            this.key2.Tag = 2;
            this.key2.Click += new System.EventHandler(this.key_Click);
            // 
            // key3
            // 
            this.key3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key3.Image = ((System.Drawing.Image)(resources.GetObject("key3.Image")));
            this.key3.Location = new System.Drawing.Point(167, 260);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(50, 50);
            this.key3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key3.TabIndex = 12;
            this.key3.TabStop = false;
            this.key3.Tag = 3;
            this.key3.Click += new System.EventHandler(this.key_Click);
            // 
            // key4
            // 
            this.key4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key4.Image = ((System.Drawing.Image)(resources.GetObject("key4.Image")));
            this.key4.Location = new System.Drawing.Point(219, 260);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(50, 50);
            this.key4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key4.TabIndex = 13;
            this.key4.TabStop = false;
            this.key4.Tag = 4;
            this.key4.Click += new System.EventHandler(this.key_Click);
            // 
            // key5
            // 
            this.key5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key5.Image = ((System.Drawing.Image)(resources.GetObject("key5.Image")));
            this.key5.Location = new System.Drawing.Point(271, 260);
            this.key5.Name = "key5";
            this.key5.Size = new System.Drawing.Size(50, 50);
            this.key5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key5.TabIndex = 14;
            this.key5.TabStop = false;
            this.key5.Tag = 5;
            this.key5.Click += new System.EventHandler(this.key_Click);
            // 
            // key9
            // 
            this.key9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key9.Image = ((System.Drawing.Image)(resources.GetObject("key9.Image")));
            this.key9.Location = new System.Drawing.Point(492, 260);
            this.key9.Name = "key9";
            this.key9.Size = new System.Drawing.Size(50, 50);
            this.key9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key9.TabIndex = 18;
            this.key9.TabStop = false;
            this.key9.Tag = 9;
            this.key9.Click += new System.EventHandler(this.key_Click);
            // 
            // key8
            // 
            this.key8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key8.Image = ((System.Drawing.Image)(resources.GetObject("key8.Image")));
            this.key8.Location = new System.Drawing.Point(440, 260);
            this.key8.Name = "key8";
            this.key8.Size = new System.Drawing.Size(50, 50);
            this.key8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key8.TabIndex = 17;
            this.key8.TabStop = false;
            this.key8.Tag = 8;
            this.key8.Click += new System.EventHandler(this.key_Click);
            // 
            // key7
            // 
            this.key7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key7.Image = ((System.Drawing.Image)(resources.GetObject("key7.Image")));
            this.key7.Location = new System.Drawing.Point(388, 260);
            this.key7.Name = "key7";
            this.key7.Size = new System.Drawing.Size(50, 50);
            this.key7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key7.TabIndex = 16;
            this.key7.TabStop = false;
            this.key7.Tag = 7;
            this.key7.Click += new System.EventHandler(this.key_Click);
            // 
            // key6
            // 
            this.key6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key6.Image = ((System.Drawing.Image)(resources.GetObject("key6.Image")));
            this.key6.Location = new System.Drawing.Point(336, 260);
            this.key6.Name = "key6";
            this.key6.Size = new System.Drawing.Size(50, 50);
            this.key6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key6.TabIndex = 15;
            this.key6.TabStop = false;
            this.key6.Tag = 6;
            this.key6.Click += new System.EventHandler(this.key_Click);
            // 
            // key13
            // 
            this.key13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key13.Image = ((System.Drawing.Image)(resources.GetObject("key13.Image")));
            this.key13.Location = new System.Drawing.Point(713, 260);
            this.key13.Name = "key13";
            this.key13.Size = new System.Drawing.Size(50, 50);
            this.key13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key13.TabIndex = 22;
            this.key13.TabStop = false;
            this.key13.Tag = 13;
            this.key13.Click += new System.EventHandler(this.key_Click);
            // 
            // key12
            // 
            this.key12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key12.Image = ((System.Drawing.Image)(resources.GetObject("key12.Image")));
            this.key12.Location = new System.Drawing.Point(661, 260);
            this.key12.Name = "key12";
            this.key12.Size = new System.Drawing.Size(50, 50);
            this.key12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key12.TabIndex = 21;
            this.key12.TabStop = false;
            this.key12.Tag = 12;
            this.key12.Click += new System.EventHandler(this.key_Click);
            // 
            // key11
            // 
            this.key11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key11.Image = ((System.Drawing.Image)(resources.GetObject("key11.Image")));
            this.key11.Location = new System.Drawing.Point(609, 260);
            this.key11.Name = "key11";
            this.key11.Size = new System.Drawing.Size(50, 50);
            this.key11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key11.TabIndex = 20;
            this.key11.TabStop = false;
            this.key11.Tag = 11;
            this.key11.Click += new System.EventHandler(this.key_Click);
            // 
            // key10
            // 
            this.key10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.key10.Image = ((System.Drawing.Image)(resources.GetObject("key10.Image")));
            this.key10.Location = new System.Drawing.Point(557, 260);
            this.key10.Name = "key10";
            this.key10.Size = new System.Drawing.Size(50, 50);
            this.key10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.key10.TabIndex = 19;
            this.key10.TabStop = false;
            this.key10.Tag = 10;
            this.key10.Click += new System.EventHandler(this.key_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 572);
            this.Controls.Add(this.key13);
            this.Controls.Add(this.key12);
            this.Controls.Add(this.key11);
            this.Controls.Add(this.key10);
            this.Controls.Add(this.key9);
            this.Controls.Add(this.key8);
            this.Controls.Add(this.key7);
            this.Controls.Add(this.key6);
            this.Controls.Add(this.key5);
            this.Controls.Add(this.key4);
            this.Controls.Add(this.key3);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.numericUpDownBlue);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.numericUpDownGreen);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.numericUpDownRed);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.trackBarRed);
            this.Name = "Form1";
            this.Text = "Keyboard UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.key10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.NumericUpDown numericUpDownRed;
        private System.Windows.Forms.NumericUpDown numericUpDownGreen;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.NumericUpDown numericUpDownBlue;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.PictureBox key1;
        private System.Windows.Forms.PictureBox key2;
        private System.Windows.Forms.PictureBox key3;
        private System.Windows.Forms.PictureBox key4;
        private System.Windows.Forms.PictureBox key5;
        private System.Windows.Forms.PictureBox key9;
        private System.Windows.Forms.PictureBox key8;
        private System.Windows.Forms.PictureBox key7;
        private System.Windows.Forms.PictureBox key6;
        private System.Windows.Forms.PictureBox key13;
        private System.Windows.Forms.PictureBox key12;
        private System.Windows.Forms.PictureBox key11;
        private System.Windows.Forms.PictureBox key10;
    }
}

