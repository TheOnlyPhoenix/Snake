namespace Snake
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblGame = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblLevels = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lblSaveScore1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDF = new System.Windows.Forms.Label();
            this.lblWtW = new System.Windows.Forms.Label();
            this.lblO = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblQuirks = new System.Windows.Forms.Label();
            this.lblShowLB = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblVsScore = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lvl7 = new System.Windows.Forms.Label();
            this.lvl6 = new System.Windows.Forms.Label();
            this.lvl5 = new System.Windows.Forms.Label();
            this.lvl4 = new System.Windows.Forms.Label();
            this.lvl3 = new System.Windows.Forms.Label();
            this.lvl2 = new System.Windows.Forms.Label();
            this.lvl1 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblShowScore = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblSaveScore = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.tmrFruitSpoil = new System.Windows.Forms.Timer(this.components);
            this.lblRetry = new System.Windows.Forms.Label();
            this.AITimer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.minWindow = new System.Windows.Forms.Label();
            this.MaxWindow = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.closeForm = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.ListBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.lblClearLB = new System.Windows.Forms.Label();
            this.lblLoadLB = new System.Windows.Forms.Label();
            this.lbScore = new System.Windows.Forms.ListBox();
            this.lbName = new System.Windows.Forms.ListBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.BackColor = System.Drawing.Color.Red;
            this.lblGame.Font = new System.Drawing.Font("Caecilia LT Pro 45 Light", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGame.Location = new System.Drawing.Point(188, 166);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(386, 84);
            this.lblGame.TabIndex = 0;
            this.lblGame.Text = "Game Over";
            this.lblGame.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 393);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.lblLevels);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblInstructions);
            this.panel2.Location = new System.Drawing.Point(13, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 376);
            this.panel2.TabIndex = 11;
            this.panel2.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(737, 376);
            this.panel6.TabIndex = 12;
            this.panel6.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(37, 305);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 25);
            this.label15.TabIndex = 14;
            this.label15.Text = "7 - Portals";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(37, 342);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Return";
            this.label13.Click += new System.EventHandler(this.btnLvlReturn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(37, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 25);
            this.label12.TabIndex = 7;
            this.label12.Text = "6 - AI enemy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "5 - Walls";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "4 - Duel (P2 uses Arrow Keys)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(37, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "3 - Invincible snake";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(37, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "2 - Disappearing food";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(37, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 25);
            this.label10.TabIndex = 1;
            this.label10.Text = "1 - Basic game";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(37, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(216, 32);
            this.label11.TabIndex = 0;
            this.label11.Text = "Level information";
            // 
            // lblLevels
            // 
            this.lblLevels.AutoSize = true;
            this.lblLevels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLevels.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLevels.Location = new System.Drawing.Point(37, 268);
            this.lblLevels.Name = "lblLevels";
            this.lblLevels.Size = new System.Drawing.Size(119, 25);
            this.lblLevels.TabIndex = 7;
            this.lblLevels.Text = "○ Level info";
            this.lblLevels.Click += new System.EventHandler(this.lblLevels_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "○ R - Restart the game";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "○ I - Show/Hide this screen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(393, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "○ O - Enter the settings panel while paused";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "○ P - Pauses the game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "○ Use WASD to move the Snake  ";
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInstructions.Location = new System.Drawing.Point(37, 37);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(223, 32);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Game Instructions";
            // 
            // lblSaveScore1
            // 
            this.lblSaveScore1.AutoSize = true;
            this.lblSaveScore1.BackColor = System.Drawing.Color.White;
            this.lblSaveScore1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSaveScore1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaveScore1.Location = new System.Drawing.Point(339, 309);
            this.lblSaveScore1.Name = "lblSaveScore1";
            this.lblSaveScore1.Size = new System.Drawing.Size(86, 23);
            this.lblSaveScore1.TabIndex = 20;
            this.lblSaveScore1.Text = "Save score";
            this.lblSaveScore1.Visible = false;
            this.lblSaveScore1.Click += new System.EventHandler(this.lblSaveScore1_Click);
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.BackColor = System.Drawing.Color.Red;
            this.lblP2.Font = new System.Drawing.Font("Caecilia LT Pro 45 Light", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblP2.Location = new System.Drawing.Point(102, 166);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(559, 84);
            this.lblP2.TabIndex = 16;
            this.lblP2.Text = "Player Two Wins";
            this.lblP2.Visible = false;
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.BackColor = System.Drawing.Color.Red;
            this.lblP1.Font = new System.Drawing.Font("Caecilia LT Pro 45 Light", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblP1.Location = new System.Drawing.Point(94, 166);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(574, 84);
            this.lblP1.TabIndex = 15;
            this.lblP1.Text = "Player One Wins!";
            this.lblP1.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblDF);
            this.panel4.Controls.Add(this.lblWtW);
            this.panel4.Controls.Add(this.lblO);
            this.panel4.Controls.Add(this.lblP);
            this.panel4.Controls.Add(this.lblQuirks);
            this.panel4.Controls.Add(this.lblShowLB);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.lblVsScore);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.lvl7);
            this.panel4.Controls.Add(this.lvl6);
            this.panel4.Controls.Add(this.lvl5);
            this.panel4.Controls.Add(this.lvl4);
            this.panel4.Controls.Add(this.lvl3);
            this.panel4.Controls.Add(this.lvl2);
            this.panel4.Controls.Add(this.lvl1);
            this.panel4.Controls.Add(this.lblInfo);
            this.panel4.Controls.Add(this.lblStart);
            this.panel4.Controls.Add(this.lblScore);
            this.panel4.Controls.Add(this.lblTime);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Location = new System.Drawing.Point(13, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 376);
            this.panel4.TabIndex = 7;
            // 
            // lblDF
            // 
            this.lblDF.AutoSize = true;
            this.lblDF.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblDF.Location = new System.Drawing.Point(500, 157);
            this.lblDF.Name = "lblDF";
            this.lblDF.Size = new System.Drawing.Size(106, 15);
            this.lblDF.TabIndex = 26;
            this.lblDF.Text = "Disappearing Food";
            this.lblDF.Visible = false;
            // 
            // lblWtW
            // 
            this.lblWtW.AutoSize = true;
            this.lblWtW.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblWtW.Location = new System.Drawing.Point(498, 172);
            this.lblWtW.Name = "lblWtW";
            this.lblWtW.Size = new System.Drawing.Size(110, 15);
            this.lblWtW.TabIndex = 25;
            this.lblWtW.Text = "Walk through Walls";
            this.lblWtW.Visible = false;
            // 
            // lblO
            // 
            this.lblO.AutoSize = true;
            this.lblO.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblO.Location = new System.Drawing.Point(525, 187);
            this.lblO.Name = "lblO";
            this.lblO.Size = new System.Drawing.Size(58, 15);
            this.lblO.TabIndex = 24;
            this.lblO.Text = "Obstacles";
            this.lblO.Visible = false;
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblP.Location = new System.Drawing.Point(533, 202);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(43, 15);
            this.lblP.TabIndex = 23;
            this.lblP.Text = "Portals";
            this.lblP.Visible = false;
            // 
            // lblQuirks
            // 
            this.lblQuirks.AutoSize = true;
            this.lblQuirks.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblQuirks.Location = new System.Drawing.Point(531, 142);
            this.lblQuirks.Name = "lblQuirks";
            this.lblQuirks.Size = new System.Drawing.Size(44, 15);
            this.lblQuirks.TabIndex = 22;
            this.lblQuirks.Text = "Quirks:";
            this.lblQuirks.Visible = false;
            // 
            // lblShowLB
            // 
            this.lblShowLB.AutoSize = true;
            this.lblShowLB.BackColor = System.Drawing.Color.White;
            this.lblShowLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShowLB.Location = new System.Drawing.Point(486, 268);
            this.lblShowLB.Name = "lblShowLB";
            this.lblShowLB.Size = new System.Drawing.Size(141, 21);
            this.lblShowLB.TabIndex = 21;
            this.lblShowLB.Text = "Show Leaderboard";
            this.lblShowLB.Click += new System.EventHandler(this.lblShowLB_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(558, 227);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 15);
            this.label16.TabIndex = 18;
            this.label16.Text = "Player 2";
            this.label16.Visible = false;
            // 
            // lblVsScore
            // 
            this.lblVsScore.AutoSize = true;
            this.lblVsScore.Location = new System.Drawing.Point(540, 248);
            this.lblVsScore.Name = "lblVsScore";
            this.lblVsScore.Size = new System.Drawing.Size(30, 15);
            this.lblVsScore.TabIndex = 17;
            this.lblVsScore.Text = "0 - 0";
            this.lblVsScore.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(503, 227);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "Player 1";
            this.label14.Visible = false;
            // 
            // lvl7
            // 
            this.lvl7.AutoSize = true;
            this.lvl7.Location = new System.Drawing.Point(679, 299);
            this.lvl7.Name = "lvl7";
            this.lvl7.Size = new System.Drawing.Size(13, 15);
            this.lvl7.TabIndex = 19;
            this.lvl7.Text = "7";
            this.lvl7.Click += new System.EventHandler(this.lvl7_Click);
            this.lvl7.MouseLeave += new System.EventHandler(this.lvl7_MouseLeave);
            this.lvl7.MouseHover += new System.EventHandler(this.lvl7_MouseHover);
            // 
            // lvl6
            // 
            this.lvl6.AutoSize = true;
            this.lvl6.Location = new System.Drawing.Point(635, 299);
            this.lvl6.Name = "lvl6";
            this.lvl6.Size = new System.Drawing.Size(13, 15);
            this.lvl6.TabIndex = 15;
            this.lvl6.Text = "6";
            this.lvl6.Click += new System.EventHandler(this.lvl6_Click);
            this.lvl6.MouseLeave += new System.EventHandler(this.lvl6_MouseLeave);
            this.lvl6.MouseHover += new System.EventHandler(this.lvl6_MouseHover);
            // 
            // lvl5
            // 
            this.lvl5.AutoSize = true;
            this.lvl5.Location = new System.Drawing.Point(591, 299);
            this.lvl5.Name = "lvl5";
            this.lvl5.Size = new System.Drawing.Size(13, 15);
            this.lvl5.TabIndex = 14;
            this.lvl5.Text = "5";
            this.lvl5.Click += new System.EventHandler(this.lvl5_Click);
            this.lvl5.MouseLeave += new System.EventHandler(this.lvl5_MouseLeave);
            this.lvl5.MouseHover += new System.EventHandler(this.lvl5_MouseHover);
            // 
            // lvl4
            // 
            this.lvl4.AutoSize = true;
            this.lvl4.Location = new System.Drawing.Point(547, 299);
            this.lvl4.Name = "lvl4";
            this.lvl4.Size = new System.Drawing.Size(13, 15);
            this.lvl4.TabIndex = 13;
            this.lvl4.Text = "4";
            this.lvl4.Click += new System.EventHandler(this.lvl4_Click);
            this.lvl4.MouseLeave += new System.EventHandler(this.lvl4_MouseLeave);
            this.lvl4.MouseHover += new System.EventHandler(this.lvl4_MouseHover);
            // 
            // lvl3
            // 
            this.lvl3.AutoSize = true;
            this.lvl3.Location = new System.Drawing.Point(503, 299);
            this.lvl3.Name = "lvl3";
            this.lvl3.Size = new System.Drawing.Size(13, 15);
            this.lvl3.TabIndex = 12;
            this.lvl3.Text = "3";
            this.lvl3.Click += new System.EventHandler(this.lvl3_Click);
            this.lvl3.MouseLeave += new System.EventHandler(this.lvl3_MouseLeave);
            this.lvl3.MouseHover += new System.EventHandler(this.lvl3_MouseHover);
            // 
            // lvl2
            // 
            this.lvl2.AutoSize = true;
            this.lvl2.Location = new System.Drawing.Point(459, 299);
            this.lvl2.Name = "lvl2";
            this.lvl2.Size = new System.Drawing.Size(13, 15);
            this.lvl2.TabIndex = 11;
            this.lvl2.Text = "2";
            this.lvl2.Click += new System.EventHandler(this.lvl2_Click);
            this.lvl2.MouseLeave += new System.EventHandler(this.lvl2_MouseLeave);
            this.lvl2.MouseHover += new System.EventHandler(this.lvl2_MouseHover);
            // 
            // lvl1
            // 
            this.lvl1.AutoSize = true;
            this.lvl1.Location = new System.Drawing.Point(415, 299);
            this.lvl1.Name = "lvl1";
            this.lvl1.Size = new System.Drawing.Size(13, 15);
            this.lvl1.TabIndex = 10;
            this.lvl1.Text = "1";
            this.lvl1.Click += new System.EventHandler(this.lvl1_Click);
            this.lvl1.MouseLeave += new System.EventHandler(this.lvl1_MouseLeave);
            this.lvl1.MouseHover += new System.EventHandler(this.lvl1_MouseHover);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfo.Location = new System.Drawing.Point(410, 343);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(300, 18);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = "Press \"I\" to show game information";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStart.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStart.Location = new System.Drawing.Point(524, 39);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(60, 30);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "Start";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblScore.Location = new System.Drawing.Point(530, 113);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(48, 15);
            this.lblScore.TabIndex = 8;
            this.lblScore.Text = "Score: 0";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Cyan;
            this.lblTime.Location = new System.Drawing.Point(512, 84);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(84, 15);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time passed: 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(16, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 368);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(8, 8);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.lblShowScore);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Controls.Add(this.lblSaveScore);
            this.panel7.Controls.Add(this.tbName);
            this.panel7.Location = new System.Drawing.Point(278, 133);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(206, 150);
            this.panel7.TabIndex = 15;
            this.panel7.Visible = false;
            // 
            // lblShowScore
            // 
            this.lblShowScore.AutoSize = true;
            this.lblShowScore.Location = new System.Drawing.Point(12, 72);
            this.lblShowScore.Name = "lblShowScore";
            this.lblShowScore.Size = new System.Drawing.Size(42, 15);
            this.lblShowScore.TabIndex = 3;
            this.lblShowScore.Text = "Score: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 15);
            this.label18.TabIndex = 2;
            this.label18.Text = "Name:";
            // 
            // lblSaveScore
            // 
            this.lblSaveScore.AutoSize = true;
            this.lblSaveScore.BackColor = System.Drawing.Color.White;
            this.lblSaveScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSaveScore.Location = new System.Drawing.Point(12, 116);
            this.lblSaveScore.Name = "lblSaveScore";
            this.lblSaveScore.Size = new System.Drawing.Size(84, 21);
            this.lblSaveScore.TabIndex = 1;
            this.lblSaveScore.Text = "Save score";
            this.lblSaveScore.Click += new System.EventHandler(this.lblSaveScore_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 42);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 23);
            this.tbName.TabIndex = 0;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // tmrFruitSpoil
            // 
            this.tmrFruitSpoil.Interval = 5000;
            this.tmrFruitSpoil.Tick += new System.EventHandler(this.tmrFruitSpoil_Tick);
            // 
            // lblRetry
            // 
            this.lblRetry.AutoSize = true;
            this.lblRetry.BackColor = System.Drawing.Color.Lime;
            this.lblRetry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblRetry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRetry.Location = new System.Drawing.Point(333, 278);
            this.lblRetry.Name = "lblRetry";
            this.lblRetry.Size = new System.Drawing.Size(97, 21);
            this.lblRetry.TabIndex = 14;
            this.lblRetry.Text = "Play again?";
            this.lblRetry.Visible = false;
            this.lblRetry.Click += new System.EventHandler(this.lblRetry_Click);
            // 
            // AITimer
            // 
            this.AITimer.Interval = 500;
            this.AITimer.Tick += new System.EventHandler(this.AITimer_Tick);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(11)))), ((int)(((byte)(91)))));
            this.panel5.Controls.Add(this.minWindow);
            this.panel5.Controls.Add(this.MaxWindow);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.closeForm);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(762, 24);
            this.panel5.TabIndex = 15;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel5_MouseDown);
            // 
            // minWindow
            // 
            this.minWindow.AutoSize = true;
            this.minWindow.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.minWindow.Location = new System.Drawing.Point(685, 3);
            this.minWindow.Name = "minWindow";
            this.minWindow.Padding = new System.Windows.Forms.Padding(1, 0, 0, 2);
            this.minWindow.Size = new System.Drawing.Size(23, 20);
            this.minWindow.TabIndex = 3;
            this.minWindow.Text = "🗕";
            this.minWindow.Click += new System.EventHandler(this.minWindow_Click);
            this.minWindow.MouseLeave += new System.EventHandler(this.minWindow_MouseLeave);
            this.minWindow.MouseHover += new System.EventHandler(this.minWindow_MouseHover);
            // 
            // MaxWindow
            // 
            this.MaxWindow.AutoSize = true;
            this.MaxWindow.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxWindow.Location = new System.Drawing.Point(712, 3);
            this.MaxWindow.Name = "MaxWindow";
            this.MaxWindow.Padding = new System.Windows.Forms.Padding(1, 0, 0, 2);
            this.MaxWindow.Size = new System.Drawing.Size(23, 20);
            this.MaxWindow.TabIndex = 2;
            this.MaxWindow.Text = "🗖";
            this.MaxWindow.Click += new System.EventHandler(this.MaxWindow_Click);
            this.MaxWindow.MouseLeave += new System.EventHandler(this.MaxWindow_MouseLeave);
            this.MaxWindow.MouseHover += new System.EventHandler(this.MaxWindow_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // closeForm
            // 
            this.closeForm.AutoSize = true;
            this.closeForm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeForm.Location = new System.Drawing.Point(739, 3);
            this.closeForm.Name = "closeForm";
            this.closeForm.Size = new System.Drawing.Size(20, 18);
            this.closeForm.TabIndex = 0;
            this.closeForm.Text = "X";
            this.closeForm.Click += new System.EventHandler(this.closeForm_Click);
            this.closeForm.MouseLeave += new System.EventHandler(this.closeForm_MouseLeave);
            this.closeForm.MouseHover += new System.EventHandler(this.closeForm_MouseHover);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.lbLevel);
            this.panel8.Controls.Add(this.lblClear);
            this.panel8.Controls.Add(this.lblClearLB);
            this.panel8.Controls.Add(this.lblLoadLB);
            this.panel8.Controls.Add(this.lbScore);
            this.panel8.Controls.Add(this.lbName);
            this.panel8.Controls.Add(this.label19);
            this.panel8.Controls.Add(this.label17);
            this.panel8.Location = new System.Drawing.Point(0, 24);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(286, 393);
            this.panel8.TabIndex = 10;
            this.panel8.Visible = false;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(217, 11);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "Level";
            // 
            // lbLevel
            // 
            this.lbLevel.FormattingEnabled = true;
            this.lbLevel.ItemHeight = 15;
            this.lbLevel.Location = new System.Drawing.Point(217, 29);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(54, 259);
            this.lbLevel.TabIndex = 10;
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.BackColor = System.Drawing.Color.White;
            this.lblClear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClear.Location = new System.Drawing.Point(74, 300);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(138, 21);
            this.lblClear.TabIndex = 9;
            this.lblClear.Text = "Clear Leaderboard";
            this.lblClear.Click += new System.EventHandler(this.lblClear_Click);
            // 
            // lblClearLB
            // 
            this.lblClearLB.AutoSize = true;
            this.lblClearLB.BackColor = System.Drawing.Color.White;
            this.lblClearLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClearLB.Location = new System.Drawing.Point(41, 360);
            this.lblClearLB.Name = "lblClearLB";
            this.lblClearLB.Size = new System.Drawing.Size(204, 21);
            this.lblClearLB.TabIndex = 8;
            this.lblClearLB.Text = "Clear Leaderboard from File";
            this.lblClearLB.Click += new System.EventHandler(this.lblClearLB_Click);
            // 
            // lblLoadLB
            // 
            this.lblLoadLB.AutoSize = true;
            this.lblLoadLB.BackColor = System.Drawing.Color.White;
            this.lblLoadLB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoadLB.Location = new System.Drawing.Point(42, 330);
            this.lblLoadLB.Name = "lblLoadLB";
            this.lblLoadLB.Size = new System.Drawing.Size(202, 21);
            this.lblLoadLB.TabIndex = 7;
            this.lblLoadLB.Text = "Load Leaderboard from File";
            this.lblLoadLB.Click += new System.EventHandler(this.lblLoadLB_Click);
            // 
            // lbScore
            // 
            this.lbScore.FormattingEnabled = true;
            this.lbScore.ItemHeight = 15;
            this.lbScore.Location = new System.Drawing.Point(158, 29);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(54, 259);
            this.lbScore.TabIndex = 5;
            // 
            // lbName
            // 
            this.lbName.FormattingEnabled = true;
            this.lbName.ItemHeight = 15;
            this.lbName.Location = new System.Drawing.Point(20, 29);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(133, 259);
            this.lbName.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(158, 11);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 15);
            this.label19.TabIndex = 3;
            this.label19.Text = "Score";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 15);
            this.label17.TabIndex = 2;
            this.label17.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(762, 417);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lblGame);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblRetry);
            this.Controls.Add(this.lblSaveScore1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Label lblGame;
        private System.Windows.Forms.Timer timer2;
        private Panel panel3;
        private System.Windows.Forms.Timer timer3;
        private Panel panel2;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label lblInstructions;
        private Label lblTime;
        private Label lblScore;
        private Label lblStart;
        private Panel panel1;
        private Panel panel4;
        private Label lblInfo;
        private PictureBox pictureBox1;
        private Label lvl5;
        private Label lvl4;
        private Label lvl3;
        private Label lvl2;
        private Label lvl1;
        private Panel panel6;
        private Label label3;
        private Label label6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lvl6;
        private Label lblLevels;
        private Label label13;
        private System.Windows.Forms.Timer tmrFruitSpoil;
        private Label lblRetry;
        private Label label16;
        private Label lblVsScore;
        private Label label14;
        private Label lblP1;
        private Label lblP2;
        private Label label15;
        private Label lvl7;
        private System.Windows.Forms.Timer AITimer;
        private Panel panel5;
        private Label closeForm;
        private PictureBox pictureBox2;
        private Label MaxWindow;
        private Label minWindow;
        private Label lblSaveScore1;
        private Panel panel7;
        private Label lblShowScore;
        private Label label18;
        private Label lblSaveScore;
        private TextBox tbName;
        private Panel panel8;
        private Label lblShowLB;
        private Label label19;
        private Label label17;
        private SaveFileDialog saveFileDialog1;
        private ListBox lbScore;
        private ListBox lbName;
        private Label lblClearLB;
        private Label lblLoadLB;
        private Label lblClear;
        private Label label20;
        private ListBox lbLevel;
        private Label lblDF;
        private Label lblWtW;
        private Label lblO;
        private Label lblP;
        private Label lblQuirks;
    }
}