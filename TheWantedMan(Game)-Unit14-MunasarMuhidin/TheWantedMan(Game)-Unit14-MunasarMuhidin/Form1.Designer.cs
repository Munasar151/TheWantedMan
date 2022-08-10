
namespace TheWantedMan_Game__Unit14_MunasarMuhidin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trees = new System.Windows.Forms.PictureBox();
            this.helicopter = new System.Windows.Forms.PictureBox();
            this.police = new System.Windows.Forms.PictureBox();
            this.police2 = new System.Windows.Forms.PictureBox();
            this.treelog = new System.Windows.Forms.PictureBox();
            this.treelog2 = new System.Windows.Forms.PictureBox();
            this.movement = new System.Windows.Forms.Timer(this.components);
            this.playerRight = new System.Windows.Forms.PictureBox();
            this.playerDown = new System.Windows.Forms.PictureBox();
            this.playerUp = new System.Windows.Forms.PictureBox();
            this.score = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.playerLeft = new System.Windows.Forms.PictureBox();
            this.police1Movement = new System.Windows.Forms.Timer(this.components);
            this.police2Movement = new System.Windows.Forms.Timer(this.components);
            this.policeLeft = new System.Windows.Forms.PictureBox();
            this.policeRight = new System.Windows.Forms.PictureBox();
            this.policeUp = new System.Windows.Forms.PictureBox();
            this.policeDown = new System.Windows.Forms.PictureBox();
            this.gameOver = new System.Windows.Forms.Timer(this.components);
            this.boundary = new System.Windows.Forms.PictureBox();
            this.boundary2 = new System.Windows.Forms.PictureBox();
            this.boundary3 = new System.Windows.Forms.PictureBox();
            this.boundary4 = new System.Windows.Forms.PictureBox();
            this.playTime = new System.Windows.Forms.Timer(this.components);
            this.policeHeli = new System.Windows.Forms.Timer(this.components);
            this.police3 = new System.Windows.Forms.PictureBox();
            this.police3Movement = new System.Windows.Forms.Timer(this.components);
            this.bossPolice = new System.Windows.Forms.PictureBox();
            this.bigPoliceMovement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helicopter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treelog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treelog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundary2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundary3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundary4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.police3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossPolice)).BeginInit();
            this.SuspendLayout();
            // 
            // trees
            // 
            this.trees.BackColor = System.Drawing.Color.Transparent;
            this.trees.Image = ((System.Drawing.Image)(resources.GetObject("trees.Image")));
            this.trees.Location = new System.Drawing.Point(409, 168);
            this.trees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trees.Name = "trees";
            this.trees.Size = new System.Drawing.Size(150, 72);
            this.trees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trees.TabIndex = 1;
            this.trees.TabStop = false;
            this.trees.Tag = "collision";
            this.trees.Visible = false;
            // 
            // helicopter
            // 
            this.helicopter.BackColor = System.Drawing.Color.Transparent;
            this.helicopter.Image = ((System.Drawing.Image)(resources.GetObject("helicopter.Image")));
            this.helicopter.Location = new System.Drawing.Point(14, 16);
            this.helicopter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.helicopter.Name = "helicopter";
            this.helicopter.Size = new System.Drawing.Size(149, 97);
            this.helicopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.helicopter.TabIndex = 4;
            this.helicopter.TabStop = false;
            this.helicopter.Tag = "police";
            this.helicopter.Visible = false;
            // 
            // police
            // 
            this.police.BackColor = System.Drawing.Color.Transparent;
            this.police.Image = ((System.Drawing.Image)(resources.GetObject("police.Image")));
            this.police.Location = new System.Drawing.Point(353, 73);
            this.police.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.police.Name = "police";
            this.police.Size = new System.Drawing.Size(94, 75);
            this.police.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.police.TabIndex = 5;
            this.police.TabStop = false;
            this.police.Tag = "police";
            // 
            // police2
            // 
            this.police2.BackColor = System.Drawing.Color.Transparent;
            this.police2.Image = ((System.Drawing.Image)(resources.GetObject("police2.Image")));
            this.police2.Location = new System.Drawing.Point(43, 505);
            this.police2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.police2.Name = "police2";
            this.police2.Size = new System.Drawing.Size(94, 75);
            this.police2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.police2.TabIndex = 7;
            this.police2.TabStop = false;
            this.police2.Tag = "police";
            // 
            // treelog
            // 
            this.treelog.BackColor = System.Drawing.Color.Transparent;
            this.treelog.Image = ((System.Drawing.Image)(resources.GetObject("treelog.Image")));
            this.treelog.Location = new System.Drawing.Point(568, 349);
            this.treelog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treelog.Name = "treelog";
            this.treelog.Size = new System.Drawing.Size(289, 96);
            this.treelog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treelog.TabIndex = 8;
            this.treelog.TabStop = false;
            this.treelog.Tag = "collision";
            this.treelog.Visible = false;
            // 
            // treelog2
            // 
            this.treelog2.BackColor = System.Drawing.Color.Transparent;
            this.treelog2.Image = ((System.Drawing.Image)(resources.GetObject("treelog2.Image")));
            this.treelog2.Location = new System.Drawing.Point(209, 235);
            this.treelog2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treelog2.Name = "treelog2";
            this.treelog2.Size = new System.Drawing.Size(65, 265);
            this.treelog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.treelog2.TabIndex = 9;
            this.treelog2.TabStop = false;
            this.treelog2.Tag = "collision";
            this.treelog2.Visible = false;
            // 
            // movement
            // 
            this.movement.Enabled = true;
            this.movement.Interval = 10;
            this.movement.Tick += new System.EventHandler(this.movement_Tick);
            // 
            // playerRight
            // 
            this.playerRight.Image = ((System.Drawing.Image)(resources.GetObject("playerRight.Image")));
            this.playerRight.Location = new System.Drawing.Point(736, 605);
            this.playerRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playerRight.Name = "playerRight";
            this.playerRight.Size = new System.Drawing.Size(91, 75);
            this.playerRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerRight.TabIndex = 11;
            this.playerRight.TabStop = false;
            // 
            // playerDown
            // 
            this.playerDown.Image = ((System.Drawing.Image)(resources.GetObject("playerDown.Image")));
            this.playerDown.Location = new System.Drawing.Point(623, 605);
            this.playerDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playerDown.Name = "playerDown";
            this.playerDown.Size = new System.Drawing.Size(91, 75);
            this.playerDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerDown.TabIndex = 12;
            this.playerDown.TabStop = false;
            // 
            // playerUp
            // 
            this.playerUp.Image = ((System.Drawing.Image)(resources.GetObject("playerUp.Image")));
            this.playerUp.Location = new System.Drawing.Point(510, 605);
            this.playerUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playerUp.Name = "playerUp";
            this.playerUp.Size = new System.Drawing.Size(94, 75);
            this.playerUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerUp.TabIndex = 13;
            this.playerUp.TabStop = false;
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(709, 31);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(57, 20);
            this.score.TabIndex = 14;
            this.score.Text = "Time: 0";
            this.score.UseWaitCursor = true;
            // 
            // player
            // 
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(383, 505);
            this.player.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(94, 75);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 15;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // playerLeft
            // 
            this.playerLeft.Image = ((System.Drawing.Image)(resources.GetObject("playerLeft.Image")));
            this.playerLeft.Location = new System.Drawing.Point(385, 605);
            this.playerLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.playerLeft.Name = "playerLeft";
            this.playerLeft.Size = new System.Drawing.Size(91, 75);
            this.playerLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerLeft.TabIndex = 16;
            this.playerLeft.TabStop = false;
            // 
            // police1Movement
            // 
            this.police1Movement.Enabled = true;
            this.police1Movement.Tick += new System.EventHandler(this.police1Movement_Tick);
            // 
            // police2Movement
            // 
            this.police2Movement.Enabled = true;
            this.police2Movement.Tick += new System.EventHandler(this.police2Movement_Tick);
            // 
            // policeLeft
            // 
            this.policeLeft.Image = ((System.Drawing.Image)(resources.GetObject("policeLeft.Image")));
            this.policeLeft.Location = new System.Drawing.Point(997, 127);
            this.policeLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.policeLeft.Name = "policeLeft";
            this.policeLeft.Size = new System.Drawing.Size(94, 75);
            this.policeLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.policeLeft.TabIndex = 17;
            this.policeLeft.TabStop = false;
            // 
            // policeRight
            // 
            this.policeRight.Image = ((System.Drawing.Image)(resources.GetObject("policeRight.Image")));
            this.policeRight.Location = new System.Drawing.Point(997, 235);
            this.policeRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.policeRight.Name = "policeRight";
            this.policeRight.Size = new System.Drawing.Size(94, 75);
            this.policeRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.policeRight.TabIndex = 18;
            this.policeRight.TabStop = false;
            // 
            // policeUp
            // 
            this.policeUp.Image = ((System.Drawing.Image)(resources.GetObject("policeUp.Image")));
            this.policeUp.Location = new System.Drawing.Point(997, 349);
            this.policeUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.policeUp.Name = "policeUp";
            this.policeUp.Size = new System.Drawing.Size(94, 75);
            this.policeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.policeUp.TabIndex = 19;
            this.policeUp.TabStop = false;
            // 
            // policeDown
            // 
            this.policeDown.Image = ((System.Drawing.Image)(resources.GetObject("policeDown.Image")));
            this.policeDown.Location = new System.Drawing.Point(997, 465);
            this.policeDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.policeDown.Name = "policeDown";
            this.policeDown.Size = new System.Drawing.Size(94, 75);
            this.policeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.policeDown.TabIndex = 20;
            this.policeDown.TabStop = false;
            // 
            // gameOver
            // 
            this.gameOver.Enabled = true;
            this.gameOver.Interval = 1;
            this.gameOver.Tick += new System.EventHandler(this.gameOver_Tick);
            // 
            // boundary
            // 
            this.boundary.BackColor = System.Drawing.Color.Transparent;
            this.boundary.Location = new System.Drawing.Point(1, 587);
            this.boundary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boundary.Name = "boundary";
            this.boundary.Size = new System.Drawing.Size(878, 67);
            this.boundary.TabIndex = 21;
            this.boundary.TabStop = false;
            this.boundary.Tag = "boundariesBottom";
            // 
            // boundary2
            // 
            this.boundary2.BackColor = System.Drawing.Color.Transparent;
            this.boundary2.Location = new System.Drawing.Point(864, -3);
            this.boundary2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boundary2.Name = "boundary2";
            this.boundary2.Size = new System.Drawing.Size(35, 639);
            this.boundary2.TabIndex = 22;
            this.boundary2.TabStop = false;
            this.boundary2.Tag = "boundaries";
            // 
            // boundary3
            // 
            this.boundary3.BackColor = System.Drawing.Color.Transparent;
            this.boundary3.Location = new System.Drawing.Point(-8, -3);
            this.boundary3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boundary3.Name = "boundary3";
            this.boundary3.Size = new System.Drawing.Size(11, 639);
            this.boundary3.TabIndex = 23;
            this.boundary3.TabStop = false;
            this.boundary3.Tag = "boundaries";
            // 
            // boundary4
            // 
            this.boundary4.BackColor = System.Drawing.Color.Transparent;
            this.boundary4.Location = new System.Drawing.Point(1, -40);
            this.boundary4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boundary4.Name = "boundary4";
            this.boundary4.Size = new System.Drawing.Size(878, 47);
            this.boundary4.TabIndex = 24;
            this.boundary4.TabStop = false;
            this.boundary4.Tag = "boundariesTop";
            this.boundary4.Visible = false;
            // 
            // playTime
            // 
            this.playTime.Enabled = true;
            this.playTime.Interval = 1000;
            this.playTime.Tick += new System.EventHandler(this.playTime_Tick);
            // 
            // policeHeli
            // 
            this.policeHeli.Enabled = true;
            this.policeHeli.Interval = 10;
            this.policeHeli.Tick += new System.EventHandler(this.policeHeli_Tick);
            // 
            // police3
            // 
            this.police3.BackColor = System.Drawing.Color.Transparent;
            this.police3.Image = ((System.Drawing.Image)(resources.GetObject("police3.Image")));
            this.police3.Location = new System.Drawing.Point(736, 83);
            this.police3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.police3.Name = "police3";
            this.police3.Size = new System.Drawing.Size(94, 75);
            this.police3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.police3.TabIndex = 25;
            this.police3.TabStop = false;
            this.police3.Tag = "police";
            this.police3.Visible = false;
            // 
            // police3Movement
            // 
            this.police3Movement.Enabled = true;
            this.police3Movement.Tick += new System.EventHandler(this.police3Movement_Tick);
            // 
            // bossPolice
            // 
            this.bossPolice.Image = ((System.Drawing.Image)(resources.GetObject("bossPolice.Image")));
            this.bossPolice.Location = new System.Drawing.Point(14, 235);
            this.bossPolice.Name = "bossPolice";
            this.bossPolice.Size = new System.Drawing.Size(198, 97);
            this.bossPolice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bossPolice.TabIndex = 26;
            this.bossPolice.TabStop = false;
            this.bossPolice.Tag = "police";
            this.bossPolice.Visible = false;
            // 
            // bigPoliceMovement
            // 
            this.bigPoliceMovement.Enabled = true;
            this.bigPoliceMovement.Interval = 10;
            this.bigPoliceMovement.Tick += new System.EventHandler(this.bigPoliceMovement_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(870, 588);
            this.Controls.Add(this.helicopter);
            this.Controls.Add(this.bossPolice);
            this.Controls.Add(this.police3);
            this.Controls.Add(this.boundary4);
            this.Controls.Add(this.boundary3);
            this.Controls.Add(this.boundary2);
            this.Controls.Add(this.boundary);
            this.Controls.Add(this.policeDown);
            this.Controls.Add(this.policeUp);
            this.Controls.Add(this.policeRight);
            this.Controls.Add(this.policeLeft);
            this.Controls.Add(this.playerLeft);
            this.Controls.Add(this.player);
            this.Controls.Add(this.score);
            this.Controls.Add(this.playerUp);
            this.Controls.Add(this.playerDown);
            this.Controls.Add(this.playerRight);
            this.Controls.Add(this.treelog2);
            this.Controls.Add(this.treelog);
            this.Controls.Add(this.police2);
            this.Controls.Add(this.police);
            this.Controls.Add(this.trees);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.trees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helicopter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treelog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treelog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.policeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundary2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundary3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boundary4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.police3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bossPolice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox trees;
        private System.Windows.Forms.PictureBox helicopter;
        private System.Windows.Forms.PictureBox police;
        private System.Windows.Forms.PictureBox police2;
        private System.Windows.Forms.PictureBox treelog;
        private System.Windows.Forms.PictureBox treelog2;
        private System.Windows.Forms.Timer movement;
        private System.Windows.Forms.PictureBox playerRight;
        private System.Windows.Forms.PictureBox playerDown;
        private System.Windows.Forms.PictureBox playerUp;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox playerLeft;
        private System.Windows.Forms.Timer police1Movement;
        private System.Windows.Forms.Timer police2Movement;
        private System.Windows.Forms.PictureBox policeLeft;
        private System.Windows.Forms.PictureBox policeRight;
        private System.Windows.Forms.PictureBox policeUp;
        private System.Windows.Forms.PictureBox policeDown;
        private System.Windows.Forms.Timer gameOver;
        private System.Windows.Forms.PictureBox boundary;
        private System.Windows.Forms.PictureBox boundary2;
        private System.Windows.Forms.PictureBox boundary3;
        private System.Windows.Forms.PictureBox boundary4;
        private System.Windows.Forms.Timer playTime;
        private System.Windows.Forms.Timer policeHeli;
        private System.Windows.Forms.PictureBox police3;
        private System.Windows.Forms.Timer police3Movement;
        private System.Windows.Forms.PictureBox bossPolice;
        private System.Windows.Forms.Timer bigPoliceMovement;
    }
}

