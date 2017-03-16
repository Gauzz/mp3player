namespace mp3player
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.play = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.option = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Button();
            this.playlist = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hide = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.option.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Image = ((System.Drawing.Image)(resources.GetObject("play.Image")));
            this.play.Location = new System.Drawing.Point(104, 258);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(72, 51);
            this.play.TabIndex = 0;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.FlatAppearance.BorderSize = 0;
            this.pause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(104, 258);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(72, 51);
            this.pause.TabIndex = 2;
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.button3_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.Transparent;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.next.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Image = ((System.Drawing.Image)(resources.GetObject("next.Image")));
            this.next.Location = new System.Drawing.Point(182, 258);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(72, 51);
            this.next.TabIndex = 3;
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.Transparent;
            this.prev.FlatAppearance.BorderSize = 0;
            this.prev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.prev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Image = ((System.Drawing.Image)(resources.GetObject("prev.Image")));
            this.prev.Location = new System.Drawing.Point(21, 256);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(72, 51);
            this.prev.TabIndex = 4;
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // option
            // 
            this.option.BackColor = System.Drawing.Color.Black;
            this.option.Controls.Add(this.min);
            this.option.Controls.Add(this.playlist);
            this.option.Controls.Add(this.pictureBox2);
            this.option.Location = new System.Drawing.Point(319, 3);
            this.option.Name = "option";
            this.option.Size = new System.Drawing.Size(142, 198);
            this.option.TabIndex = 6;
            this.option.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.Transparent;
            this.min.FlatAppearance.BorderSize = 0;
            this.min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Font = new System.Drawing.Font("Digital Readout Expanded", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.min.Location = new System.Drawing.Point(3, 129);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(136, 30);
            this.min.TabIndex = 3;
            this.min.Text = "CLEAR";
            this.min.UseVisualStyleBackColor = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // playlist
            // 
            this.playlist.BackColor = System.Drawing.Color.Transparent;
            this.playlist.FlatAppearance.BorderSize = 0;
            this.playlist.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.playlist.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.playlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playlist.Font = new System.Drawing.Font("Digital Readout Expanded", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playlist.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.playlist.Location = new System.Drawing.Point(0, 165);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(142, 30);
            this.playlist.TabIndex = 2;
            this.playlist.Text = "SELECT";
            this.playlist.UseVisualStyleBackColor = false;
            this.playlist.Click += new System.EventHandler(this.playlist_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(135, 120);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // hide
            // 
            this.hide.BackColor = System.Drawing.Color.Transparent;
            this.hide.FlatAppearance.BorderSize = 0;
            this.hide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hide.ForeColor = System.Drawing.Color.Transparent;
            this.hide.Image = ((System.Drawing.Image)(resources.GetObject("hide.Image")));
            this.hide.Location = new System.Drawing.Point(397, 264);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(73, 45);
            this.hide.TabIndex = 0;
            this.hide.UseVisualStyleBackColor = false;
            this.hide.Click += new System.EventHandler(this.quit_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.Transparent;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(328, 260);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 55);
            this.exit.TabIndex = 1;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Digital Readout Expanded", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 11;
            this.listBox1.Location = new System.Drawing.Point(9, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(292, 198);
            this.listBox1.TabIndex = 7;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mc);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(10, 10);
            this.axWindowsMediaPlayer1.TabIndex = 8;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // listBox2
            // 
            this.listBox2.AllowDrop = true;
            this.listBox2.BackColor = System.Drawing.Color.Red;
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Font = new System.Drawing.Font("Digital Readout Expanded", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 11;
            this.listBox2.Location = new System.Drawing.Point(9, 3);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(292, 198);
            this.listBox2.TabIndex = 9;
            this.listBox2.Click += new System.EventHandler(this.play_Click);
            this.listBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mc);
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.play_Click);
            this.listBox2.SelectedValueChanged += new System.EventHandler(this.play_Click);
            this.listBox2.TabIndexChanged += new System.EventHandler(this.play_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.Color.Black;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(9, 207);
            this.trackBar1.Maximum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(452, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Digital Readout Expanded", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(17, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 10);
            this.label1.TabIndex = 11;
            this.label1.Text = "label";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Digital Readout Expanded", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(402, 238);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(55, 10);
            this.label2.TabIndex = 12;
            this.label2.Text = "label";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.option);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.next);
            this.Controls.Add(this.play);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.trackBar1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.option.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Panel option;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button playlist;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button hide;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ListBox listBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}

