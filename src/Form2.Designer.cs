namespace Snake
{
    partial class Form2
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPfdStn = new System.Windows.Forms.Label();
            this.lblFrtStn = new System.Windows.Forms.Label();
            this.lblSnkStn = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSnkApply = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnResetSnk = new System.Windows.Forms.Button();
            this.tbStrtLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSnkSpd = new System.Windows.Forms.TextBox();
            this.tbSnkClr = new System.Windows.Forms.TextBox();
            this.tbSnkSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbFrtGrowth = new System.Windows.Forms.TextBox();
            this.tbFrtCnt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnFrtApply = new System.Windows.Forms.Button();
            this.btnFrtReturn = new System.Windows.Forms.Button();
            this.btnFrtReset = new System.Windows.Forms.Button();
            this.tbFrtSpoil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFrtClr = new System.Windows.Forms.TextBox();
            this.tbFrtSize = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.lblPfdStn);
            this.panel4.Controls.Add(this.lblFrtStn);
            this.panel4.Controls.Add(this.lblSnkStn);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Location = new System.Drawing.Point(32, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 376);
            this.panel4.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(37, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "○";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(37, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "○ e";
            // 
            // lblPfdStn
            // 
            this.lblPfdStn.AutoSize = true;
            this.lblPfdStn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblPfdStn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPfdStn.Location = new System.Drawing.Point(37, 157);
            this.lblPfdStn.Name = "lblPfdStn";
            this.lblPfdStn.Size = new System.Drawing.Size(183, 25);
            this.lblPfdStn.TabIndex = 4;
            this.lblPfdStn.Text = "○ Playfield settings";
            // 
            // lblFrtStn
            // 
            this.lblFrtStn.AutoSize = true;
            this.lblFrtStn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFrtStn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFrtStn.Location = new System.Drawing.Point(37, 120);
            this.lblFrtStn.Name = "lblFrtStn";
            this.lblFrtStn.Size = new System.Drawing.Size(149, 25);
            this.lblFrtStn.TabIndex = 2;
            this.lblFrtStn.Text = "○ Fruit settings";
            this.lblFrtStn.Click += new System.EventHandler(this.lblFrtStn_Click);
            // 
            // lblSnkStn
            // 
            this.lblSnkStn.AutoSize = true;
            this.lblSnkStn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSnkStn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSnkStn.Location = new System.Drawing.Point(37, 83);
            this.lblSnkStn.Name = "lblSnkStn";
            this.lblSnkStn.Size = new System.Drawing.Size(161, 25);
            this.lblSnkStn.TabIndex = 1;
            this.lblSnkStn.Text = "○ Snake settings";
            this.lblSnkStn.Click += new System.EventHandler(this.lblSnkStn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(37, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnSnkApply);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnResetSnk);
            this.panel1.Controls.Add(this.tbStrtLength);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbSnkSpd);
            this.panel1.Controls.Add(this.tbSnkClr);
            this.panel1.Controls.Add(this.tbSnkSize);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(32, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 376);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // btnSnkApply
            // 
            this.btnSnkApply.Location = new System.Drawing.Point(37, 313);
            this.btnSnkApply.Name = "btnSnkApply";
            this.btnSnkApply.Size = new System.Drawing.Size(107, 23);
            this.btnSnkApply.TabIndex = 12;
            this.btnSnkApply.Text = "Apply";
            this.btnSnkApply.UseVisualStyleBackColor = true;
            this.btnSnkApply.Click += new System.EventHandler(this.btnSnkApply_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(150, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Go back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnResetSnk
            // 
            this.btnResetSnk.Location = new System.Drawing.Point(263, 313);
            this.btnResetSnk.Name = "btnResetSnk";
            this.btnResetSnk.Size = new System.Drawing.Size(107, 23);
            this.btnResetSnk.TabIndex = 10;
            this.btnResetSnk.Text = "Reset to Defaults";
            this.btnResetSnk.UseVisualStyleBackColor = true;
            // 
            // tbStrtLength
            // 
            this.tbStrtLength.Location = new System.Drawing.Point(312, 194);
            this.tbStrtLength.Name = "tbStrtLength";
            this.tbStrtLength.Size = new System.Drawing.Size(58, 23);
            this.tbStrtLength.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(37, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "○ Starting length:";
            // 
            // tbSnkSpd
            // 
            this.tbSnkSpd.Location = new System.Drawing.Point(312, 157);
            this.tbSnkSpd.Name = "tbSnkSpd";
            this.tbSnkSpd.Size = new System.Drawing.Size(58, 23);
            this.tbSnkSpd.TabIndex = 7;
            // 
            // tbSnkClr
            // 
            this.tbSnkClr.Location = new System.Drawing.Point(312, 120);
            this.tbSnkClr.Name = "tbSnkClr";
            this.tbSnkClr.Size = new System.Drawing.Size(58, 23);
            this.tbSnkClr.TabIndex = 6;
            // 
            // tbSnkSize
            // 
            this.tbSnkSize.Location = new System.Drawing.Point(312, 83);
            this.tbSnkSize.Name = "tbSnkSize";
            this.tbSnkSize.Size = new System.Drawing.Size(58, 23);
            this.tbSnkSize.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(37, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "○ Snake speed:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(37, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "○ Snake colour:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(37, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "○ Snake size:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(37, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(180, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Snake Settings";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.tbFrtGrowth);
            this.panel2.Controls.Add(this.tbFrtCnt);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnFrtApply);
            this.panel2.Controls.Add(this.btnFrtReturn);
            this.panel2.Controls.Add(this.btnFrtReset);
            this.panel2.Controls.Add(this.tbFrtSpoil);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbFrtClr);
            this.panel2.Controls.Add(this.tbFrtSize);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(13, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(737, 376);
            this.panel2.TabIndex = 15;
            this.panel2.Visible = false;
            // 
            // tbFrtGrowth
            // 
            this.tbFrtGrowth.Location = new System.Drawing.Point(312, 231);
            this.tbFrtGrowth.Name = "tbFrtGrowth";
            this.tbFrtGrowth.Size = new System.Drawing.Size(58, 23);
            this.tbFrtGrowth.TabIndex = 17;
            // 
            // tbFrtCnt
            // 
            this.tbFrtCnt.Location = new System.Drawing.Point(312, 157);
            this.tbFrtCnt.Name = "tbFrtCnt";
            this.tbFrtCnt.Size = new System.Drawing.Size(58, 23);
            this.tbFrtCnt.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(37, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "○ Fruit growth factor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(376, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 15);
            this.label14.TabIndex = 13;
            this.label14.Text = "0 for unlimited time";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label15.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(37, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 25);
            this.label15.TabIndex = 16;
            this.label15.Text = "○ Fruit count:";
            // 
            // btnFrtApply
            // 
            this.btnFrtApply.Location = new System.Drawing.Point(37, 313);
            this.btnFrtApply.Name = "btnFrtApply";
            this.btnFrtApply.Size = new System.Drawing.Size(107, 23);
            this.btnFrtApply.TabIndex = 12;
            this.btnFrtApply.Text = "Apply";
            this.btnFrtApply.UseVisualStyleBackColor = true;
            this.btnFrtApply.Click += new System.EventHandler(this.btnFrtApply_Click);
            // 
            // btnFrtReturn
            // 
            this.btnFrtReturn.Location = new System.Drawing.Point(150, 313);
            this.btnFrtReturn.Name = "btnFrtReturn";
            this.btnFrtReturn.Size = new System.Drawing.Size(107, 23);
            this.btnFrtReturn.TabIndex = 11;
            this.btnFrtReturn.Text = "Go back";
            this.btnFrtReturn.UseVisualStyleBackColor = true;
            this.btnFrtReturn.Click += new System.EventHandler(this.btnFrtReturn_Click);
            // 
            // btnFrtReset
            // 
            this.btnFrtReset.Location = new System.Drawing.Point(263, 313);
            this.btnFrtReset.Name = "btnFrtReset";
            this.btnFrtReset.Size = new System.Drawing.Size(107, 23);
            this.btnFrtReset.TabIndex = 10;
            this.btnFrtReset.Text = "Reset to Defaults";
            this.btnFrtReset.UseVisualStyleBackColor = true;
            this.btnFrtReset.Click += new System.EventHandler(this.btnFrtReset_Click);
            // 
            // tbFrtSpoil
            // 
            this.tbFrtSpoil.Location = new System.Drawing.Point(312, 194);
            this.tbFrtSpoil.Name = "tbFrtSpoil";
            this.tbFrtSpoil.Size = new System.Drawing.Size(58, 23);
            this.tbFrtSpoil.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(37, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "○ Fruit spoil time:";
            // 
            // tbFrtClr
            // 
            this.tbFrtClr.Location = new System.Drawing.Point(312, 120);
            this.tbFrtClr.Name = "tbFrtClr";
            this.tbFrtClr.Size = new System.Drawing.Size(58, 23);
            this.tbFrtClr.TabIndex = 6;
            // 
            // tbFrtSize
            // 
            this.tbFrtSize.Location = new System.Drawing.Point(312, 83);
            this.tbFrtSize.Name = "tbFrtSize";
            this.tbFrtSize.Size = new System.Drawing.Size(58, 23);
            this.tbFrtSize.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(37, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "○ Fruit colour:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(37, 83);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 25);
            this.label12.TabIndex = 1;
            this.label12.Text = "○ Fruit size:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(37, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(166, 32);
            this.label13.TabIndex = 0;
            this.label13.Text = "Fruit Settings";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(761, 392);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel4;
        private Label label3;
        private Label label6;
        private Label lblPfdStn;
        private Label lblFrtStn;
        private Label lblSnkStn;
        private Label label8;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label9;
        private Button btnResetSnk;
        private TextBox tbStrtLength;
        private Label label1;
        private TextBox tbSnkSpd;
        private TextBox tbSnkClr;
        private TextBox tbSnkSize;
        private Button button1;
        private Button button2;
        private Button btnSnkApply;
        private Panel panel2;
        private Button btnFrtApply;
        private Button btnFrtReturn;
        private Button btnFrtReset;
        private TextBox tbFrtSpoil;
        private Label label2;
        private TextBox tbFrtClr;
        private TextBox tbFrtSize;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox tbFrtGrowth;
        private TextBox tbFrtCnt;
        private Label label10;
        private Label label15;
    }
}