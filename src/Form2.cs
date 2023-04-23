using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form2 : Form
    {
        Form1 F1;
        Random random = new Random();
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 Form1)
        {
            F1 = Form1;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            F1.Show();
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            F1.Show();
        }

        private void lblSnkStn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void btnSnkApply_Click(object sender, EventArgs e)
        {
            CheckTextFieldSnake();
            if (comboBox1.SelectedIndex == 0)
            {
                SettingsData.rainbowSnake = true;
                SettingsData.randomSnake = false;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                SettingsData.randomSnake = true;
                SettingsData.rainbowSnake = false;
            }
            if (checkBox2.Checked)
            {
                SettingsData.invincibleSnake = true;
            }
            else if (!checkBox2.Checked)
            {
                SettingsData.invincibleSnake = false;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void lblFrtStn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
        private void btnFrtReturn_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
        private void btnFrtApply_Click(object sender, EventArgs e)
        {
            CheckTextFieldFruit();
        }


        private void CheckTextFieldFruit()
        {
            if (tbFrtSize.Text != "")
            {
                SettingsData.fruitSize = int.Parse(tbFrtSize.Text);
            }
            if (tbFrtCnt.Text != "")
            {
                SettingsData.fruitCount = int.Parse(tbFrtCnt.Text);
            }
            if (tbFrtSpoil.Text != "")
            {
                SettingsData.fruitSpoilTime = int.Parse(tbFrtSpoil.Text);
            }
            if (tbFrtGrowth.Text != "")
            {
                SettingsData.fruitGrowthFactor = int.Parse(tbFrtGrowth.Text);
            }
        }

        private void CheckTextFieldSnake()
        {
            if (tbSnkSize.Text != "")
            {
                SettingsData.snakeSize = int.Parse(tbSnkSize.Text);
            }
            if (tbSnkSpd.Text != "")
            {
                SettingsData.snakeSpeed = int.Parse(tbSnkSpd.Text);
            }
            if (tbStrtLength.Text != "")
            {
                SettingsData.startingLength = int.Parse(tbStrtLength.Text);
            }
        }

        private void btnFrtReset_Click(object sender, EventArgs e)
        {
            SettingsData.fruitSize = 8;
            SettingsData.fruitColor = Color.Red;
            SettingsData.fruitCount = 1;
            SettingsData.fruitSpoilTime = 0;
            SettingsData.fruitGrowthFactor = 1;
        }

        private void label16_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            SettingsData.fruitColor = colorDialog1.Color;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                colorDialog2.ShowDialog();
                SettingsData.snakeColor = colorDialog2.Color;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            colorDialog3.ShowDialog();
            SettingsData.playfieldColor = colorDialog3.Color;
        }

        private void lblPfdStn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblScaleNum.Text = (0 + (double)trackBar1.Value / 4).ToString() + "x";
            SettingsData.playfieldScale = (0 + (double)trackBar1.Value / 4);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox1.Visible = true;
            }
            else if (checkBox1.Checked == false)
            {
                comboBox1.Visible = false;
            }
        }
    }
}
