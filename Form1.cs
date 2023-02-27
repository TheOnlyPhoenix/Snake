using System.Drawing;
using System.Security.Policy;

namespace Snake
{
    public partial class Form1 : Form
    {
        Rectangle fruit;
        List<Rectangle> snake = new List<Rectangle>();
        Form F2;
        bool right = true;
        bool left = false;
        bool up = false;
        bool down = false;
        Random random = new Random();
        int count = 0;
        int seconds = 0;
                    
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblGame.Visible = false;
            snake.Add(new Rectangle(SettingsData.dx, SettingsData.dy, SettingsData.snakeSize, SettingsData.snakeSize));
            fruit = new Rectangle(96, 96, SettingsData.fruitSize, SettingsData.fruitSize);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            g.FillRectangle(SettingsData.fruitBrush, fruit);

            foreach (Rectangle r in snake)
            {
                g.FillRectangle(SettingsData.snakeBrush, r);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!panel2.Visible)
            {
                if (e.KeyCode == Keys.Up && SettingsData.dy >= 8 && down == false)
                {
                    right = false;
                    left = false;
                    up = true;
                    down = false;
                }
                if (e.KeyCode == Keys.Down && SettingsData.dy <= 360 && up == false)
                {
                    right = false;
                    left = false;
                    up = false;
                    down = true;
                }
                if (e.KeyCode == Keys.Right && SettingsData.dx <= 360 && left == false)
                {
                    right = true;
                    left = false;
                    up = false;
                    down = false;
                }
                if (e.KeyCode == Keys.Left && SettingsData.dx >= 8 && right == false)
                {
                    right = false;
                    left = true;
                    up = false;
                    down = false;
                }
            }
            if (panel2.Visible == false && e.KeyCode == Keys.P)
            {
                timer1.Enabled = !timer1.Enabled;
                timer3.Enabled = !timer3.Enabled;
            }
            if (timer1.Enabled == false && e.KeyCode == Keys.I)
            {
                panel2.Visible = !panel2.Visible;
            }
            if (e.KeyCode == Keys.R)
            {
                timer1.Enabled = false;
                timer3.Enabled = false;
                lblGame.Visible = false;
                right = true;
                left = false;
                up = false;
                down = false;
                count = 0;
                for (int i = 0; i < snake.Count; i++)
                {
                    snake.RemoveAt(i);
                }
                snake.Add(new Rectangle(SettingsData.dx, SettingsData.dy, SettingsData.snakeSize, SettingsData.snakeSize));
                fruit = new Rectangle(96, 96, SettingsData.fruitSize, SettingsData.fruitSize);
                panel1.Invalidate();
                panel1.Update();
            }
            if (e.KeyCode == Keys.S && timer1.Enabled == false)
            {
                timer3.Enabled = false;

                this.Hide();
                new Form2(this).ShowDialog();
                ColorUpdate();
            }
        }
        
        private void lblStart_Click(object sender, EventArgs e)
        {
            if (!panel2.Visible)
            {
                timer1.Enabled = !timer1.Enabled;
                timer3.Enabled = !timer3.Enabled;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (up == true)
            {
                SettingsData.dy = SettingsData.dy - SettingsData.snakeSize;
            }
            if (down == true)
            {
                SettingsData.dy = SettingsData.dy + SettingsData.snakeSize;
            }
            if (right == true)
            {
                SettingsData.dx = SettingsData.dx + SettingsData.snakeSize;
            }
            if (left == true)
            {
                SettingsData.dx = SettingsData.dx - SettingsData.snakeSize;
            }
            snake.Insert(0, (new Rectangle(SettingsData.dx, SettingsData.dy, SettingsData.snakeSize, SettingsData.snakeSize)));
            for (int i = 1; i < snake.Count; i++)
            {
                if (snake[0].IntersectsWith(snake[i]) || snake[0].X >= 360 || snake[0].Y >= 360 || snake[0].X <= 0 || snake[0].Y <= 0)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    timer3.Enabled = false;
                }

            }
            if (snake[0].IntersectsWith(fruit))
            {
                count++;
                int x = random.Next(45);
                int y = random.Next(45);
                for (int i = 1; i < snake.Count; i++)
                {
                    if (x == snake[i].X/8 || y == snake[i].Y/8)
                    {
                        x = random.Next(45);
                        y = random.Next(45);
                    }
                }
                fruit.X = x*8;
                fruit.Y = y*8;
                lblScore.Text = "Score: " + count;
                snake.Insert(0, (new Rectangle(SettingsData.dx, SettingsData.dy, SettingsData.snakeSize, SettingsData.snakeSize)));
            }
            
            
            if (snake[0].IntersectsWith(fruit) == false)
            {
                snake.RemoveAt(snake.Count - 1);
            }
            panel1.Invalidate();
        }

        /*int[] directionCheck()
        {
            if (up)
            {
                SettingsData.dy = SettingsData.dy + SettingsData.snakeSize;
            }
            if (down) 
            {
                SettingsData.dy = SettingsData.dy - SettingsData.snakeSize; 
            }
            if (left)
            {
                SettingsData.dx = SettingsData.dx - SettingsData.snakeSize;
            }
            if (right)
            {
                SettingsData.dx = SettingsData.dx + SettingsData.snakeSize;
            }
            int[] tailReturn = { SettingsData.dx, SettingsData.dy };
            return tailReturn;
        }*/

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblGame.Visible = !lblGame.Visible;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            seconds++;
            lblTime.Text = "Time passed: " + seconds;
        }

        private void testLabel_Click(object sender, EventArgs e)
        {

        }
        void ColorUpdate()
        {
            SettingsData.snakeColor = (Color)new ColorConverter().ConvertFrom(SettingsData.snakeColorString);
            SettingsData.snakeBrush = new SolidBrush(SettingsData.snakeColor);
            SettingsData.fruitColor = (Color)new ColorConverter().ConvertFrom(SettingsData.fruitColorString);
            SettingsData.fruitBrush = new SolidBrush(SettingsData.fruitColor);
            panel1.Invalidate();
            panel1.Update();
        }
    }

    public static class SettingsData
    {

        public static int snakeSize = 8;
        public static int snakeSpeed = 1;
        public static int startingLength = 1;
        public static string snakeColorString = "Lime";
        public static Color snakeColor = (Color)new ColorConverter().ConvertFrom(snakeColorString);
        public static SolidBrush snakeBrush = new SolidBrush(snakeColor);
        
        public static int fruitCount = 1;
        public static int fruitSize = 8;
        public static int fruitSpoilTime = 0;
        public static int fruitGrowthFactor = 1;
        public static string fruitColorString = "Red";
        public static Color fruitColor = (Color)new ColorConverter().ConvertFrom(fruitColorString);
        public static SolidBrush fruitBrush = new SolidBrush(fruitColor);

        public static int dy = 48;
        public static int dx = 48;
        public static bool right = true;
        public static bool left = false;
        public static bool up = false;
        public static bool down = false;
    }
}