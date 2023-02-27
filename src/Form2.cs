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

        }
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void lblSnkStn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void btnSnkApply_Click(object sender, EventArgs e)
        {
            CheckTextFieldSnake();
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
            if (tbFrtClr.Text != "")
            {
                SettingsData.fruitColorString = tbFrtClr.Text;
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
            if (tbSnkClr.Text != "")
            {
                SettingsData.snakeColorString = tbSnkClr.Text;
            }
            if (tbStrtLength.Text != "")
            {
                SettingsData.startingLength = int.Parse(tbStrtLength.Text);
            }
        }

        private void btnFrtReset_Click(object sender, EventArgs e)
        {
            SettingsData.fruitSize = 8;
            SettingsData.fruitColorString = "Red";
            SettingsData.fruitCount = 1;
            SettingsData.fruitSpoilTime = 0;
            SettingsData.fruitGrowthFactor = 1;
        }
    }
}
