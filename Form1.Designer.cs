namespace RAmsol
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
            this.pgb1 = new System.Windows.Forms.ProgressBar();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.lblAv1 = new System.Windows.Forms.Label();
            this.lblAv2 = new System.Windows.Forms.Label();
            this.lblAv3 = new System.Windows.Forms.Label();
            this.lblAv4 = new System.Windows.Forms.Label();
            this.tmrPlayer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picPortal = new System.Windows.Forms.PictureBox();
            this.picCoin = new System.Windows.Forms.PictureBox();
            this.picJumpad = new System.Windows.Forms.PictureBox();
            this.picLazer = new System.Windows.Forms.PictureBox();
            this.picDemo = new System.Windows.Forms.PictureBox();
            this.picCannon = new System.Windows.Forms.PictureBox();
            this.picTrap = new System.Windows.Forms.PictureBox();
            this.picPlatformL = new System.Windows.Forms.PictureBox();
            this.picPlatformS = new System.Windows.Forms.PictureBox();
            this.PicSelect1 = new System.Windows.Forms.PictureBox();
            this.picupdate = new System.Windows.Forms.PictureBox();
            this.tmrSelect = new System.Windows.Forms.Timer(this.components);
            this.tmrBuild = new System.Windows.Forms.Timer(this.components);
            this.lblError = new System.Windows.Forms.Label();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.hSB1 = new System.Windows.Forms.HScrollBar();
            this.hSB2 = new System.Windows.Forms.HScrollBar();
            ((System.ComponentModel.ISupportInitialize)(this.picPortal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJumpad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLazer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCannon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatformL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatformS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSelect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picupdate)).BeginInit();
            this.SuspendLayout();
            // 
            // pgb1
            // 
            this.pgb1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pgb1.Location = new System.Drawing.Point(5, 410);
            this.pgb1.Name = "pgb1";
            this.pgb1.Size = new System.Drawing.Size(560, 30);
            this.pgb1.TabIndex = 0;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 600;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // lblAv1
            // 
            this.lblAv1.AutoSize = true;
            this.lblAv1.Location = new System.Drawing.Point(38, 78);
            this.lblAv1.Name = "lblAv1";
            this.lblAv1.Size = new System.Drawing.Size(72, 17);
            this.lblAv1.TabIndex = 2;
            this.lblAv1.Text = "Player1Av";
            // 
            // lblAv2
            // 
            this.lblAv2.AutoSize = true;
            this.lblAv2.Location = new System.Drawing.Point(38, 181);
            this.lblAv2.Name = "lblAv2";
            this.lblAv2.Size = new System.Drawing.Size(72, 17);
            this.lblAv2.TabIndex = 3;
            this.lblAv2.Text = "Player2Av";
            // 
            // lblAv3
            // 
            this.lblAv3.AutoSize = true;
            this.lblAv3.Location = new System.Drawing.Point(38, 285);
            this.lblAv3.Name = "lblAv3";
            this.lblAv3.Size = new System.Drawing.Size(72, 17);
            this.lblAv3.TabIndex = 4;
            this.lblAv3.Text = "Player3Av";
            // 
            // lblAv4
            // 
            this.lblAv4.AutoSize = true;
            this.lblAv4.Location = new System.Drawing.Point(38, 388);
            this.lblAv4.Name = "lblAv4";
            this.lblAv4.Size = new System.Drawing.Size(72, 17);
            this.lblAv4.TabIndex = 5;
            this.lblAv4.Text = "Player4Av";
            // 
            // tmrPlayer
            // 
            this.tmrPlayer.Enabled = true;
            this.tmrPlayer.Interval = 20;
            this.tmrPlayer.Tick += new System.EventHandler(this.tmrPlayer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(465, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Jump_to_build";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Spawn_item";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // picPortal
            // 
            this.picPortal.BackgroundImage = global::RAmsol.Properties.Resources.Portal;
            this.picPortal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPortal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPortal.Location = new System.Drawing.Point(426, 231);
            this.picPortal.Name = "picPortal";
            this.picPortal.Size = new System.Drawing.Size(90, 90);
            this.picPortal.TabIndex = 15;
            this.picPortal.TabStop = false;
            this.picPortal.Click += new System.EventHandler(this.picPortal_Click);
            // 
            // picCoin
            // 
            this.picCoin.BackgroundImage = global::RAmsol.Properties.Resources.Coin;
            this.picCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCoin.Location = new System.Drawing.Point(426, 131);
            this.picCoin.Name = "picCoin";
            this.picCoin.Size = new System.Drawing.Size(90, 90);
            this.picCoin.TabIndex = 14;
            this.picCoin.TabStop = false;
            this.picCoin.Click += new System.EventHandler(this.picCoin_Click);
            // 
            // picJumpad
            // 
            this.picJumpad.BackgroundImage = global::RAmsol.Properties.Resources.Jumpad;
            this.picJumpad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picJumpad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picJumpad.Location = new System.Drawing.Point(426, 26);
            this.picJumpad.Name = "picJumpad";
            this.picJumpad.Size = new System.Drawing.Size(90, 90);
            this.picJumpad.TabIndex = 13;
            this.picJumpad.TabStop = false;
            this.picJumpad.Click += new System.EventHandler(this.picJumpad_Click);
            // 
            // picLazer
            // 
            this.picLazer.BackgroundImage = global::RAmsol.Properties.Resources.Laser;
            this.picLazer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLazer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLazer.Location = new System.Drawing.Point(313, 231);
            this.picLazer.Name = "picLazer";
            this.picLazer.Size = new System.Drawing.Size(90, 90);
            this.picLazer.TabIndex = 12;
            this.picLazer.TabStop = false;
            this.picLazer.Click += new System.EventHandler(this.picLazer_Click);
            // 
            // picDemo
            // 
            this.picDemo.BackgroundImage = global::RAmsol.Properties.Resources.Remove;
            this.picDemo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picDemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDemo.Location = new System.Drawing.Point(204, 231);
            this.picDemo.Name = "picDemo";
            this.picDemo.Size = new System.Drawing.Size(90, 90);
            this.picDemo.TabIndex = 11;
            this.picDemo.TabStop = false;
            this.picDemo.Click += new System.EventHandler(this.picDemo_Click);
            // 
            // picCannon
            // 
            this.picCannon.BackgroundImage = global::RAmsol.Properties.Resources.Cannon;
            this.picCannon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCannon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCannon.Location = new System.Drawing.Point(313, 131);
            this.picCannon.Name = "picCannon";
            this.picCannon.Size = new System.Drawing.Size(90, 90);
            this.picCannon.TabIndex = 10;
            this.picCannon.TabStop = false;
            this.picCannon.Click += new System.EventHandler(this.picCannon_Click);
            // 
            // picTrap
            // 
            this.picTrap.BackgroundImage = global::RAmsol.Properties.Resources.Trap;
            this.picTrap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picTrap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTrap.Location = new System.Drawing.Point(204, 131);
            this.picTrap.Name = "picTrap";
            this.picTrap.Size = new System.Drawing.Size(90, 90);
            this.picTrap.TabIndex = 9;
            this.picTrap.TabStop = false;
            this.picTrap.Click += new System.EventHandler(this.picTrap_Click);
            // 
            // picPlatformL
            // 
            this.picPlatformL.BackgroundImage = global::RAmsol.Properties.Resources.Big_platform2;
            this.picPlatformL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlatformL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlatformL.Location = new System.Drawing.Point(313, 26);
            this.picPlatformL.Name = "picPlatformL";
            this.picPlatformL.Size = new System.Drawing.Size(90, 90);
            this.picPlatformL.TabIndex = 8;
            this.picPlatformL.TabStop = false;
            this.picPlatformL.Click += new System.EventHandler(this.picPlatformL_Click);
            // 
            // picPlatformS
            // 
            this.picPlatformS.BackgroundImage = global::RAmsol.Properties.Resources.Small_platform;
            this.picPlatformS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlatformS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlatformS.Location = new System.Drawing.Point(204, 26);
            this.picPlatformS.Name = "picPlatformS";
            this.picPlatformS.Size = new System.Drawing.Size(90, 90);
            this.picPlatformS.TabIndex = 7;
            this.picPlatformS.TabStop = false;
            this.picPlatformS.Click += new System.EventHandler(this.picPlatformS_Click);
            // 
            // PicSelect1
            // 
            this.PicSelect1.BackgroundImage = global::RAmsol.Properties.Resources.dot_outline1;
            this.PicSelect1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicSelect1.Location = new System.Drawing.Point(157, 78);
            this.PicSelect1.Name = "PicSelect1";
            this.PicSelect1.Size = new System.Drawing.Size(20, 20);
            this.PicSelect1.TabIndex = 6;
            this.PicSelect1.TabStop = false;
            // 
            // picupdate
            // 
            this.picupdate.BackColor = System.Drawing.SystemColors.Control;
            this.picupdate.Location = new System.Drawing.Point(157, 12);
            this.picupdate.Name = "picupdate";
            this.picupdate.Size = new System.Drawing.Size(30, 20);
            this.picupdate.TabIndex = 18;
            this.picupdate.TabStop = false;
            // 
            // tmrSelect
            // 
            this.tmrSelect.Interval = 20;
            this.tmrSelect.Tick += new System.EventHandler(this.tmrSelect_Tick);
            // 
            // tmrBuild
            // 
            this.tmrBuild.Interval = 20;
            this.tmrBuild.Tick += new System.EventHandler(this.tmrBuild_Tick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(220, 9);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 46);
            this.lblError.TabIndex = 19;
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.Location = new System.Drawing.Point(277, 352);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(130, 17);
            this.lblSubmit.TabIndex = 21;
            this.lblSubmit.Text = "Scroll to adjust freq";
            this.lblSubmit.Click += new System.EventHandler(this.lblSubmit_Click);
            // 
            // hSB1
            // 
            this.hSB1.Location = new System.Drawing.Point(9, 352);
            this.hSB1.Maximum = 110;
            this.hSB1.Name = "hSB1";
            this.hSB1.Size = new System.Drawing.Size(262, 25);
            this.hSB1.TabIndex = 22;
            this.hSB1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSB1_Scroll);
            // 
            // hSB2
            // 
            this.hSB2.Location = new System.Drawing.Point(9, 377);
            this.hSB2.Maximum = 110;
            this.hSB2.Name = "hSB2";
            this.hSB2.Size = new System.Drawing.Size(262, 25);
            this.hSB2.TabIndex = 23;
            this.hSB2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hSB2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(570, 446);
            this.Controls.Add(this.hSB2);
            this.Controls.Add(this.hSB1);
            this.Controls.Add(this.lblSubmit);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.picupdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPortal);
            this.Controls.Add(this.picCoin);
            this.Controls.Add(this.picJumpad);
            this.Controls.Add(this.picLazer);
            this.Controls.Add(this.picDemo);
            this.Controls.Add(this.picCannon);
            this.Controls.Add(this.picTrap);
            this.Controls.Add(this.picPlatformL);
            this.Controls.Add(this.picPlatformS);
            this.Controls.Add(this.PicSelect1);
            this.Controls.Add(this.lblAv4);
            this.Controls.Add(this.lblAv3);
            this.Controls.Add(this.lblAv2);
            this.Controls.Add(this.lblAv1);
            this.Controls.Add(this.pgb1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picPortal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJumpad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLazer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCannon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTrap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatformL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlatformS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSelect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picupdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar pgb1;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Label lblAv1;
        private System.Windows.Forms.Label lblAv2;
        private System.Windows.Forms.Label lblAv3;
        private System.Windows.Forms.Label lblAv4;
        private System.Windows.Forms.PictureBox PicSelect1;
        private System.Windows.Forms.PictureBox picPlatformS;
        private System.Windows.Forms.PictureBox picPlatformL;
        private System.Windows.Forms.PictureBox picTrap;
        private System.Windows.Forms.PictureBox picCannon;
        private System.Windows.Forms.PictureBox picDemo;
        private System.Windows.Forms.PictureBox picLazer;
        private System.Windows.Forms.PictureBox picJumpad;
        private System.Windows.Forms.PictureBox picCoin;
        private System.Windows.Forms.PictureBox picPortal;
        private System.Windows.Forms.Timer tmrPlayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picupdate;
        private System.Windows.Forms.Timer tmrSelect;
        private System.Windows.Forms.Timer tmrBuild;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSubmit;
        private System.Windows.Forms.HScrollBar hSB1;
        private System.Windows.Forms.HScrollBar hSB2;
    }
}

