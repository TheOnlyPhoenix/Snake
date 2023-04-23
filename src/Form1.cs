namespace Snake
{
    public partial class Form1 : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        List<Rectangle> fruit = new List<Rectangle>();
        List<Rectangle> snake = new List<Rectangle>();
        List<Rectangle> snake2 = new List<Rectangle>();
        List<Rectangle> enemySnake = new List<Rectangle>();
        List<Rectangle> wall = new List<Rectangle>();
        List<Rectangle> portal1 = new List<Rectangle>();
        List<Rectangle> portal2 = new List<Rectangle>();
        List<Color> color = new List<Color>();
        Rectangle check;
        Rectangle wallCheck;
        Rectangle portalCheck;

        bool right = true;
        bool left = false;
        bool up = false;
        bool down = false;
        bool right2 = false;
        bool left2 = true;
        bool up2 = false;
        bool down2 = false;
        bool enemyRight = false;
        bool enemyLeft = true;
        bool enemyUp = false;
        bool enemyDown = false;
        bool aiCanMove = true;

        bool p1 = false;
        bool p2 = false;
        bool debounce = false;
        bool debounce2 = false;
        bool eat = true;
        bool start = false;
        bool maximised = false;

        Random random = new Random();
        
        int count = 0; 
        int seconds = 0;
        int colorCount = 0;
        int colorCount2 = 0;
        int removeStop = 0;
        int removeStop2 = 0;
        int fruitCounter;
        int fruitCounter2;
        int playerOne = 0;
        int playerTwo = 0;
        int directionCount = 0;
        int eatCount = 0;
        int updateCount = 0;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            lblGame.Visible = false;
            lblQuirks.Visible = true;
            panel1.Width = (int)(368 * SettingsData.playfieldScale);
            panel1.Height = (int)(368 * SettingsData.playfieldScale);

            lvl1.ForeColor = Color.Orange;
            // Adds a rectangle to each snake
            for (int i = 0; i < SettingsData.startingLength; i++)
            {
                snake.Add(new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize));
            }
            for (int i = 0; i < SettingsData.startingLength; i++)
            {
                snake2.Add(new Rectangle(SettingsData.x2, SettingsData.y2, SettingsData.snakeSize, SettingsData.snakeSize));
            }
            for (int i = 0; i < SettingsData.startingLength; i++)
            {
                enemySnake.Add(new Rectangle(SettingsData.x2, SettingsData.y2, SettingsData.snakeSize, SettingsData.snakeSize));
            }
            color.AddRange(new Color[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Blue, Color.Purple, Color.Magenta });
            
            int x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
            int y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
            fruit.Add(new Rectangle(x, y, SettingsData.fruitSize, SettingsData.fruitSize));
            for (int i = 0; i < SettingsData.fruitCount - 1; i++)
            {
                bool ok = true;
                while (ok)
                {
                    x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    ok = false;

                    for (int j = 0; j < fruit.Count - 1; j++)
                    {
                        if ((check = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(fruit[j]))// || check.IntersectsWith(snake[i]))
                        {
                            ok = true;
                        }
                    }
                }
                fruit.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
            }
        }
        void MoveWindow()
        {
            // Method to move the titlebar-less window
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Moves window
            if (e.Button == MouseButtons.Left)
            {
                MoveWindow();
            }
        }
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            // Moves window
            if (e.Button == MouseButtons.Left)
            {
                MoveWindow();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Gives food, walls and snake color and shape
            Graphics g = e.Graphics;
            foreach (Rectangle f in fruit)
            {
                using (SettingsData.fruitBrush = new SolidBrush(SettingsData.fruitColor))
                {
                    // Uses a brush and a color which are then discarded so that they dont lay around and take up memory
                    g.FillRectangle(SettingsData.fruitBrush, f);
                }
            }

            foreach (Rectangle w in wall)
            {
                using (SettingsData.fruitBrush = new SolidBrush(Color.White))
                {
                    g.FillRectangle(SettingsData.fruitBrush, w);
                }
            }

            foreach (Rectangle p1 in portal1)
            {
                using (SettingsData.fruitBrush = new SolidBrush(Color.Turquoise))
                {
                    g.FillRectangle(SettingsData.fruitBrush, p1);
                }
            }
            foreach (Rectangle p2 in portal2)
            {
                using (SettingsData.fruitBrush = new SolidBrush(Color.Orange))
                {
                    g.FillRectangle(SettingsData.fruitBrush, p2);
                }
            }

            colorCount = 0;
            foreach (Rectangle r in snake)
            {

                if (SettingsData.rainbowSnake == true)
                {
                    // Rainbow snake
                    if (colorCount % 7 == 0)
                    {
                        SettingsData.snakeColor = color[0];
                    }
                    else if (colorCount % 7 == 1)
                    {
                        SettingsData.snakeColor = color[1];
                    }
                    else if (colorCount % 7 == 2)
                    {
                        SettingsData.snakeColor = color[2];
                    }
                    else if (colorCount % 7 == 3)
                    {
                        SettingsData.snakeColor = color[3];
                    }
                    else if (colorCount % 7 == 4)
                    {
                        SettingsData.snakeColor = color[4];
                    }
                    else if (colorCount % 7 == 5)
                    {
                        SettingsData.snakeColor = color[5];
                    }
                    else if (colorCount % 7 == 6)
                    {
                        SettingsData.snakeColor = color[6];
                    }
                }
                else if (SettingsData.randomSnake == true)
                {
                    // Randomised snake colors
                    SettingsData.snakeColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                }
                else SettingsData.snakeColor = Color.Lime;
                using (SettingsData.snakeBrush = new SolidBrush(SettingsData.snakeColor))
                {
                    g.FillRectangle(SettingsData.snakeBrush, r);
                }
                colorCount++;
            }
            if (SettingsData.level4)
            {
                // Same as before but for opponent's snake in duel mode
                colorCount2 = 0;
                foreach (Rectangle r in snake2)
                {
                    if (SettingsData.rainbowSnake == true)
                    {
                        if (colorCount % 7 == 0)
                        {
                            SettingsData.snakeColor = color[0];
                        }
                        else if (colorCount % 7 == 1)
                        {
                            SettingsData.snakeColor = color[1];
                        }
                        else if (colorCount % 7 == 2)
                        {
                            SettingsData.snakeColor = color[2];
                        }
                        else if (colorCount % 7 == 3)
                        {
                            SettingsData.snakeColor = color[3];
                        }
                        else if (colorCount % 7 == 4)
                        {
                            SettingsData.snakeColor = color[4];
                        }
                        else if (colorCount % 7 == 5)
                        {
                            SettingsData.snakeColor = color[5];
                        }
                        else if (colorCount % 7 == 6)
                        {
                            SettingsData.snakeColor = color[6];
                        }
                    }
                    else if (SettingsData.randomSnake == true)
                    {
                        SettingsData.snakeColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                    }
                    using (SettingsData.snakeBrush = new SolidBrush(SettingsData.snakeColor))
                    {
                        g.FillRectangle(SettingsData.snakeBrush, r);
                    }
                    colorCount2++;
                }
            }
            if (SettingsData.level6)
            {
                // Same as before but for AI snake
                colorCount2 = 0;
                foreach (Rectangle r in enemySnake)
                {
                    if (SettingsData.rainbowSnake == true)
                    {
                        if (colorCount % 7 == 0)
                        {
                            SettingsData.snakeColor = color[0];
                        }
                        else if (colorCount % 7 == 1)
                        {
                            SettingsData.snakeColor = color[1];
                        }
                        else if (colorCount % 7 == 2)
                        {
                            SettingsData.snakeColor = color[2];
                        }
                        else if (colorCount % 7 == 3)
                        {
                            SettingsData.snakeColor = color[3];
                        }
                        else if (colorCount % 7 == 4)
                        {
                            SettingsData.snakeColor = color[4];
                        }
                        else if (colorCount % 7 == 5)
                        {
                            SettingsData.snakeColor = color[5];
                        }
                        else if (colorCount % 7 == 6)
                        {
                            SettingsData.snakeColor = color[6];
                        }
                    }
                    else if (SettingsData.randomSnake == true)
                    {
                        SettingsData.snakeColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
                    }
                    else
                    {
                        SettingsData.snakeColor = Color.Orange;
                    }
                    using (SettingsData.snakeBrush = new SolidBrush(SettingsData.snakeColor))
                    {
                        g.FillRectangle(SettingsData.snakeBrush, r);
                    }
                    colorCount2++;
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!panel2.Visible && !debounce)
            {
                // Key controls for player 1
                if (e.KeyCode == Keys.W && down == false)
                {
                    debounce = true;
                    right = false;
                    left = false;
                    up = true;
                    down = false;
                }
                if (e.KeyCode == Keys.S && up == false)
                {
                    debounce = true;
                    right = false;
                    left = false;
                    up = false;
                    down = true;
                }
                if (e.KeyCode == Keys.D && left == false)
                {
                    debounce = true;
                    right = true;
                    left = false;
                    up = false;
                    down = false;
                }
                if (e.KeyCode == Keys.A && right == false)
                {
                    debounce = true;
                    right = false;
                    left = true;
                    up = false;
                    down = false;
                }
                if (SettingsData.level4)
                {
                    // key controls for player 2
                    if (e.KeyCode == Keys.Up && down2 == false)
                    {
                        debounce2 = true;
                        right2 = false;
                        left2 = false;
                        up2 = true;
                        down2 = false;
                    }
                    if (e.KeyCode == Keys.Down && up2 == false)
                    {
                        debounce2 = true;
                        right2 = false;
                        left2 = false;
                        up2 = false;
                        down2 = true;
                    }
                    if (e.KeyCode == Keys.Right && left2 == false)
                    {
                        debounce2 = true;
                        right2 = true;
                        left2 = false;
                        up2 = false;
                        down2 = false;
                    }
                    if (e.KeyCode == Keys.Left && right2 == false)
                    {
                        debounce2 = true;
                        right2 = false;
                        left2 = true;
                        up2 = false;
                        down2 = false;
                    }
                }
            }
            if (panel2.Visible == false && e.KeyCode == Keys.P)
            {
                // Pauses the game
                timer1.Enabled = !timer1.Enabled;
                timer3.Enabled = !timer3.Enabled;
                start = !start;
                if (start && !timer2.Enabled)
                {
                    lblStart.Text = "Stop";
                    lblStart.BackColor = Color.Red;
                }
                if (!start && !timer2.Enabled)
                {
                    lblStart.Text = "Start";
                    lblStart.BackColor = Color.FromArgb(0, 192, 0);
                }
            }
            if (timer1.Enabled == false && e.KeyCode == Keys.I && !panel6.Visible)
            {
                // Shows game information
                panel2.Visible = !panel2.Visible;
            }
            if (timer1.Enabled == false && e.KeyCode == Keys.U && panel2.Visible)
            {
                // Shows level information
                panel6.Visible = !panel6.Visible;
            }
            if (e.KeyCode == Keys.R)
            {
                // Restarts the game
                timer1.Stop();
                timer3.Stop();
                lblGame.Visible = false;
                right = true;
                left = false;
                up = false;
                down = false;
                lblRetry.Visible = false;
                lblSaveScore1.Visible = false;
                lblDF.Visible = false;
                lblWtW.Visible = false;
                lblO.Visible = false;
                lblP.Visible = false;
                count = 0;
                seconds = 0;
                lblScore.Text = "Score: " + count.ToString();
                lblTime.Text = "Time passed: " + seconds;
                SettingsData.x =48;
                SettingsData.y = 48;
                SettingsData.x2 = 304;
                SettingsData.y2 = 304;
                snake.Clear();
                snake.Add(new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize));
                fruit.Clear();
                int x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                int y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                fruit.Add(new Rectangle(x, y, SettingsData.fruitSize, SettingsData.fruitSize));
                for (int i = 0; i < SettingsData.fruitCount - 1; i++)
                {

                    bool ok = true;
                    while (ok)
                    {
                        x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        ok = false;

                        for (int j = 0; j < fruit.Count - 1; j++)
                        {
                            if ((check = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(fruit[j]))// || check.IntersectsWith(snake[i]))
                            {
                                ok = true;
                            }
                        }
                    }
                    fruit.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                }
                if (SettingsData.level1)
                {
                    SettingsData.level7 = false;
                    SettingsData.level5 = false; 
                    SettingsData.level3 = false;
                    SettingsData.level2 = false;
                }
                if (SettingsData.level2)
                {
                    tmrFruitSpoil.Enabled = true;
                }
                if (SettingsData.level4)
                {
                    snake2.Clear();
                    snake2.Add(new Rectangle(SettingsData.x2, SettingsData.y2, SettingsData.snakeSize, SettingsData.snakeSize));
                }
                if (SettingsData.level5)
                {
                    wall.Clear();
                    x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    wall.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                    for (int i = 0; i < 9; i++)
                    {
                        bool ok = true;
                        while (ok)
                        {
                            x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                            y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                            ok = false;
                            
                            for (int j = 0; j < 10; j++)
                            {
                                if ((wallCheck = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(wall[i]))// || wallCheck.IntersectsWith(snake[i]))
                                {
                                    ok = true;
                                }
                            }
                        }
                        wall.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                    }
                }
                if (SettingsData.level6)
                {
                    enemySnake.Clear();
                    enemySnake.Add(new Rectangle(SettingsData.x2, SettingsData.y2, SettingsData.snakeSize, SettingsData.snakeSize));
                }
                if (SettingsData.level7)
                {
                    portal1.Clear();
                    portal2.Clear();
                    x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    portal1.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                    x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    portal2.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                    for (int i = 0; i < 1; i++)
                    {
                        bool ok = true;
                        while (ok)
                        {
                            x = random.Next((int)(5 * SettingsData.playfieldScale), (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                            y = random.Next((int)(5 * SettingsData.playfieldScale), (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                            ok = false;

                            for (int j = 0; j < 2; j++)
                            {
                                if ((portalCheck = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(portal1[i]))// || wallCheck.IntersectsWith(snake[i]))
                                {
                                    ok = true;
                                }
                            }
                        }
                        portal1.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                    }
                    for (int i = 0; i < 1; i++)
                    {
                        bool ok = true;
                        while (ok)
                        {
                            x = random.Next((int)(5 * SettingsData.playfieldScale), (int)(40 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                            y = random.Next((int)(5 * SettingsData.playfieldScale), (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                            ok = false;

                            for (int j = 0; j < 2; j++)
                            {
                                if ((portalCheck = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(portal1[i]) || portalCheck.IntersectsWith(portal2[i]))// || wallCheck.IntersectsWith(snake[i]))
                                {
                                    ok = true;
                                }
                            }
                        }
                        portal2.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                    }
                }

                panel1.Invalidate();
                panel1.Update();
            }
            if (e.KeyCode == Keys.O && timer1.Enabled == false)
            {
                // Opens settings window
                timer3.Enabled = false;

                this.Hide();
                new Form2(this).ShowDialog();
                SettingsUpdate();
            }
        }
        
        private void lblStart_Click(object sender, EventArgs e)
        {
            if (!lblGame.Visible)
            {
                // Starts/Stops the game, functions the same as P
                start = !start;
                if (start && !timer2.Enabled)
                {
                    lblStart.Text = "Stop";
                    lblStart.BackColor = Color.Red;
                }
                if (!start && !timer2.Enabled)
                {
                    lblStart.Text = "Start";
                    lblStart.BackColor = Color.FromArgb(0, 192, 0);
                }
                if (!panel2.Visible)
                {
                    timer1.Enabled = !timer1.Enabled;
                    timer3.Enabled = !timer3.Enabled;
                }
                if (SettingsData.level6)
                {
                    AITimer.Enabled = true;
                }
            }
        }
        private void lblRetry_Click(object sender, EventArgs e)
        {
            // Restarts the game after you've died/lost/won
            timer1.Stop();
            timer2.Stop();  
            timer3.Stop();

            lblGame.Visible = false;
            lblRetry.Visible = false;
            lblSaveScore1.Visible = false;
            lblP1.Visible = false;
            lblP2.Visible = false;
            panel7.Visible = false;
            lblDF.Visible = false;
            lblWtW.Visible = false;
            lblO.Visible = false;
            lblP.Visible = false;
            lblStart.Text = "Start";
            lblStart.BackColor = Color.FromArgb(0, 192, 0);

            right = true;
            left = false;
            up = false;
            down = false;

            right2 = false;
            left2 = true;
            up2 = false;
            down2 = false;

            enemyRight = false;
            enemyLeft = true;
            enemyUp = false;
            enemyDown = false;
            
            count = 0;
            seconds = 0;
            removeStop = 0;
            removeStop2 = 0;
            lblScore.Text = "Score: " + count.ToString();
            lblTime.Text = "Time passed: " + seconds;
            SettingsData.x = 48;
            SettingsData.y = 48;
            SettingsData.x2 = 304;
            SettingsData.y2 = 304;
            snake.Clear();
            snake.Add(new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize));
            fruit.Clear();
            int x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
            int y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
            fruit.Add(new Rectangle(x, y, SettingsData.fruitSize, SettingsData.fruitSize));
            for (int i = 0; i < SettingsData.fruitCount - 1; i++)
            {

                bool ok = true;
                while (ok)
                {
                    x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                    ok = false;

                    for (int j = 0; j < fruit.Count; j++)
                    {
                        if ((check = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(fruit[j]))// || check.IntersectsWith(snake[i]))
                        {
                            ok = true;
                        }
                    }
                }
                fruit.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
            }
            if (SettingsData.level1)
            {
                SettingsData.level7 = false;
                SettingsData.level5 = false;
                SettingsData.level3 = false;
                SettingsData.level2 = false;
            }
            if (SettingsData.level4)
            {
                snake2.Clear();
                snake2.Add(new Rectangle(SettingsData.x2, SettingsData.y2, SettingsData.snakeSize, SettingsData.snakeSize));
            }
            if (SettingsData.level5)
            {
                wall.Clear();
                x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                wall.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                for (int i = 0; i < 9; i++)
                {
                    bool ok = true;
                    while (ok)
                    {
                        x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        ok = false;

                        for (int j = 0; j < 10; j++)
                        {
                            if ((wallCheck = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(wall[i]))// || wallCheck.IntersectsWith(snake[i]))
                            {
                                ok = true;
                            }
                        }
                    }
                    wall.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                }
            }
            if (SettingsData.level6)
            {
                enemySnake.Clear();
                enemySnake.Add(new Rectangle(SettingsData.x2, SettingsData.y2, SettingsData.snakeSize, SettingsData.snakeSize));
            }
            if (SettingsData.level7)
            {
                portal1.Clear();
                portal2.Clear();
                x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                portal1.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                portal2.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                for (int i = 0; i < 1; i++)
                {
                    bool ok = true;
                    while (ok)
                    {
                        x = random.Next((int)(5 * SettingsData.playfieldScale), (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        y = random.Next((int)(5 * SettingsData.playfieldScale), (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        ok = false;

                        for (int j = 0; j < 2; j++)
                        {
                            if ((portalCheck = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(portal1[i]))// || wallCheck.IntersectsWith(snake[i]))
                            {
                                ok = true;
                            }
                        }
                    }
                    portal1.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                }
                for (int i = 0; i < 1; i++)
                {
                    bool ok = true;
                    while (ok)
                    {
                        x = random.Next((int)(5 * SettingsData.playfieldScale), (int)(40 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        y = random.Next((int)(5 * SettingsData.playfieldScale), (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        ok = false;

                        for (int j = 0; j < 2; j++)
                        {
                            if ((portalCheck = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(portal1[i]) || portalCheck.IntersectsWith(portal2[i]))// || wallCheck.IntersectsWith(snake[i]))
                            {
                                ok = true;
                            }
                        }
                    }
                    portal2.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                }
            }

            panel1.Invalidate();
            panel1.Update();
        }
        private void lblLevels_Click(object sender, EventArgs e)
        {
            // Shows level information
            panel6.Visible = true;
        }
        private void btnLvlReturn_Click(object sender, EventArgs e)
        {
            // Closes level information
            panel6.Visible = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // The game itself
            if (SettingsData.level1)
            {
                //level 1 base game + level ups
                //level 2 disappearing fruit
                //level 3 no boundaries
                //level 4 1v1
                //level 5 walls
                //level 6 ai
                //level 7 portals
                if (count >= 12 && updateCount < 4)
                {
                    SettingsData.level7 = true;
                    SettingsData.level5 = true;
                    SettingsData.level3 = true;
                    SettingsData.level2 = true;    
                    SettingsUpdate();
                    updateCount++;
                    lblP.Visible = true;
                }
                else if (count >= 9 && updateCount < 3)
                {
                    SettingsData.level5 = true;
                    SettingsData.level3 = true;
                    SettingsData.level2 = true;
                    SettingsUpdate();
                    updateCount++;
                    lblO.Visible = true;
                }
                else if (count >= 6 && updateCount < 2)
                {
                    SettingsData.level3 = true;
                    SettingsData.level2 = true;
                    SettingsUpdate();
                    updateCount++;
                    lblWtW.Visible = true;
                }
                else if (count >= 3 && updateCount < 1)
                {
                    SettingsData.level2 = true;
                    SettingsUpdate();
                    updateCount++;
                    lblDF.Visible = true;
                }
            }
            debounce = false;
            if (up == true) // Moves player 1 snake
            {
                SettingsData.y = SettingsData.y - SettingsData.snakeSize; ;
            }
            if (down == true)
            {
                SettingsData.y = SettingsData.y + SettingsData.snakeSize; ;
            }
            if (right == true)
            {
                SettingsData.x = SettingsData.x + SettingsData.snakeSize; ;
            }
            if (left == true)
            {
                SettingsData.x = SettingsData.x - SettingsData.snakeSize; ;
            }
            debounce2 = false;
            if (SettingsData.level4)
            {
                // Moves player 2 snake
                if (up2 == true)
                {
                    SettingsData.y2 = SettingsData.y2 - SettingsData.snakeSize;
                }
                if (down2 == true)
                {
                    SettingsData.y2 = SettingsData.y2 + SettingsData.snakeSize;
                }
                if (right2 == true)
                {
                    SettingsData.x2 = SettingsData.x2 + SettingsData.snakeSize;
                }
                if (left2 == true)
                {
                    SettingsData.x2 = SettingsData.x2 - SettingsData.snakeSize;
                }
            }
            if (SettingsData.level6)
            {
                // Moves AI snake
                if (enemyUp)
                {
                    SettingsData.y2 = SettingsData.y2 - SettingsData.snakeSize;
                }
                if (enemyDown)
                {
                    SettingsData.y2 = SettingsData.y2 + SettingsData.snakeSize;
                }
                if (enemyRight)
                {
                    SettingsData.x2 = SettingsData.x2 + SettingsData.snakeSize;
                }
                if (enemyLeft)
                {
                    SettingsData.x2 = SettingsData.x2 - SettingsData.snakeSize;
                }
            }

            snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
            fruitCounter = 0;
            if (fruit.Count > 1)
            {
                // Runs if more than 1 fruit
                for (int i = 0; i < fruit.Count; i++)
                {
                    if (removeStop > SettingsData.startingLength - 2)
                    {
                        if (snake[0].IntersectsWith(fruit[i]) == false)
                        {
                            fruitCounter++;
                            if (fruitCounter == fruit.Count)
                            {
                                snake.RemoveAt(snake.Count - 1);
                            }
                        }
                    }
                }
            }
            else if (fruit.Count <= 1)
            {
                if (removeStop > SettingsData.startingLength - 2)
                {
                    if (snake[0].IntersectsWith(fruit[0]) == false)
                    {
                        snake.RemoveAt(snake.Count - 1);
                    }
                }
            }

            removeStop++;
            if (SettingsData.level4)
            {
                // Moves player2 snake
                fruitCounter2 = 0;
                snake2.Insert(0, (new Rectangle(SettingsData.x2, SettingsData.y2, SettingsData.snakeSize, SettingsData.snakeSize)));
                if (fruit.Count > 1)
                {
                    for (int i = 0; i < fruit.Count; i++)
                    {
                        if (removeStop2 > SettingsData.startingLength - 2)
                        {
                            if (snake2[0].IntersectsWith(fruit[i]) == false)
                            {
                                fruitCounter2++;
                                if (fruitCounter2 == fruit.Count)
                                {
                                    snake2.RemoveAt(snake2.Count - 1);
                                }
                            }
                        }
                    }
                }
                else if (fruit.Count <= 1)
                {
                    if (removeStop2 > SettingsData.startingLength - 2)
                    {
                        if (snake2[0].IntersectsWith(fruit[0]) == false)
                        {
                            snake2.RemoveAt(snake2.Count - 1);
                        }
                    }
                }
                removeStop2++;
            }
            if (SettingsData.level6)
            {
                // moves AI snake
                enemySnake.Insert(0, (new Rectangle(SettingsData.x2, SettingsData.y2, SettingsData.snakeSize, SettingsData.snakeSize)));
                if (removeStop2 > SettingsData.startingLength - 2)
                {
                    if (enemySnake[0].IntersectsWith(fruit[0]) == false)
                    {
                        enemySnake.RemoveAt(enemySnake.Count - 1);
                    }
                }
                removeStop2++;
            }
            if (SettingsData.level3)
            {
                // Disables boundaries; snake wont die from going out
                if (snake[0].X >= panel1.Width)
                {
                    SettingsData.x = 0;
                    snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                    snake.RemoveAt(snake.Count - 1);
                }
                else if (snake[0].X < 0)
                {
                    SettingsData.x = panel1.Width - SettingsData.snakeSize;
                    snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                    snake.RemoveAt(snake.Count - 1);
                }
                else if (snake[0].Y >= panel1.Height)
                {
                    SettingsData.y = 0;
                    snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                    snake.RemoveAt(snake.Count - 1);
                }
                else if (snake[0].Y < 0)
                {
                    SettingsData.y = panel1.Height - SettingsData.snakeSize;
                    snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                    snake.RemoveAt(snake.Count - 1);
                }
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake[0].IntersectsWith(snake[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
            }
            if (SettingsData.invincibleSnake)
            { 
                // completely invincible snake, can't die from crashing or going out of bounds
                if (snake[0].X >= panel1.Width)
                {
                    SettingsData.x = 0;
                    snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                    snake.RemoveAt(snake.Count - 1);
                }
                else if (snake[0].X < 0)
                {
                    SettingsData.x = panel1.Width - SettingsData.snakeSize;
                    snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                    snake.RemoveAt(snake.Count - 1);
                }
                else if (snake[0].Y >= panel1.Height)
                {
                    SettingsData.y = 0;
                    snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                    snake.RemoveAt(snake.Count - 1);
                }
                else if (snake[0].Y < 0)
                {
                    SettingsData.y = panel1.Height - SettingsData.snakeSize;
                    snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                    snake.RemoveAt(snake.Count - 1);
                }
            }
            if (SettingsData.level4)
            {
                // Checks for collisions in player1's and player2's snakes
                for (int i = 1; i < snake2.Count; i++)
                {
                    if (snake2[0].IntersectsWith(snake2[i]))
                    {
                        timer1.Enabled = false;
                        timer3.Enabled = false;
                        lblP1.Visible = true;
                        lblRetry.Visible = true;
                        p1 = true;
                    }
                }
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake2[0].IntersectsWith(snake[i]))
                    {
                        timer1.Enabled = false;
                        timer3.Enabled = false;
                        lblP1.Visible = true;
                        lblRetry.Visible = true;
                        p1 = true;
                    }
                }
                for (int i = 0; i < snake2.Count; i++)
                {
                    if (snake2[0].X > panel1.Width - SettingsData.snakeSize || snake2[0].Y > panel1.Height - SettingsData.snakeSize || snake2[0].X < 0 || snake2[0].Y < 0)
                    {
                        timer1.Enabled = false;
                        timer3.Enabled = false;
                        lblP1.Visible = true;
                        lblRetry.Visible = true;
                        p1 = true;
                    }
                }
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake[0].IntersectsWith(snake[i]))
                    {
                        timer1.Enabled = false;
                        timer3.Enabled = false;
                        lblP2.Visible = true;
                        lblRetry.Visible = true;
                        p2 = true;
                    }
                }
                for (int i = 1; i < snake2.Count; i++)
                {
                    if (snake[0].IntersectsWith(snake2[i]))
                    {
                        timer1.Enabled = false;
                        timer3.Enabled = false;
                        lblP2.Visible = true;
                        lblRetry.Visible = true;
                        p2 = true;
                    }
                }
                for (int i = 0; i < snake.Count; i++)
                {
                    if (snake[0].X > panel1.Width - SettingsData.snakeSize || snake[0].Y > panel1.Height - SettingsData.snakeSize || snake[0].X < 0 || snake[0].Y < 0)
                    {
                        timer1.Enabled = false;
                        timer3.Enabled = false;
                        lblP2.Visible = true;
                        lblRetry.Visible = true;
                        p2 = true;
                    }
                }
                if (snake[0].IntersectsWith(snake2[0]))
                {
                    timer1.Enabled = false;
                    timer3.Enabled = false;
                    lblGame.Visible = true;
                    lblRetry.Visible = true;
                }
                // 2 player scoring system
                if (p1)
                {
                    p1 = false;
                    p2 = false;
                    playerOne++;
                }
                else if (p2)
                {
                    p1 = false;
                    p2 = false;
                    playerTwo++;
                }
                lblVsScore.Text = playerOne.ToString() + " - " + playerTwo.ToString();
            }
            if (SettingsData.level5)
            {
                // checks for collisions between player snake and walls
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake[0].IntersectsWith(snake[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
                for (int i = 0; i < snake.Count; i++)
                {
                    if (snake[0].X > panel1.Width - SettingsData.snakeSize || snake[0].Y > panel1.Height - SettingsData.snakeSize || snake[0].X < 0 || snake[0].Y < 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
                for (int i = 0; i < wall.Count; i++)
                {
                    if (snake[0].IntersectsWith(wall[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
            }
            if (SettingsData.level6)
            {
                // Checks for collisions with player snake and AI snake (and out of bounds for both)
                enemyMove();
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake[0].IntersectsWith(snake[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
                for (int i = 0; i < snake.Count; i++)
                {
                    if (snake[0].X > panel1.Width - SettingsData.snakeSize || snake[0].Y > panel1.Height - SettingsData.snakeSize || snake[0].X < 0 || snake[0].Y < 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
                for (int i = 1; i < enemySnake.Count; i++)
                {
                    if (snake[0].IntersectsWith(enemySnake[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
                for (int i = 1; i < snake.Count; i++)
                {
                    if (enemySnake[0].IntersectsWith(snake[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
                for (int i = 1; i < enemySnake.Count; i++)
                {
                    if (enemySnake[0].IntersectsWith(enemySnake[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
                if (snake[0].IntersectsWith(enemySnake[0]))
                {
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    timer3.Enabled = false;
                    lblRetry.Visible = true;
                    lblSaveScore1.Visible = true;
                }
                if (enemySnake[0].X > panel1.Width - SettingsData.snakeSize || enemySnake[0].Y > panel1.Height - SettingsData.snakeSize || enemySnake[0].X < 0 || enemySnake[0].Y < 0)
                {
                    timer1.Enabled = false;
                    timer2.Enabled = true;
                    timer3.Enabled = false;
                    lblRetry.Visible = true;
                    lblSaveScore1.Visible = true;
                }
                for (int i = 1; i < enemySnake.Count; i++)
                {
                    if (snake[0].IntersectsWith(enemySnake[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
            }
            if (SettingsData.level7)
            {
                // Does nothing special here, just calls the portal teleport method and checks for collision and out of bounds
                PortalMove();
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake[0].IntersectsWith(snake[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
                for (int i = 0; i < snake.Count; i++)
                {
                    if (snake[0].X > panel1.Width - SettingsData.snakeSize || snake[0].Y > panel1.Height - SettingsData.snakeSize || snake[0].X < 0 || snake[0].Y < 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
            }
            else
            {
                // checks for collision and out of bounds
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake[0].IntersectsWith(snake[i]))
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
                for (int i = 0; i < snake.Count; i++)
                {
                    if (snake[0].X > panel1.Width - SettingsData.snakeSize || snake[0].Y > panel1.Height - SettingsData.snakeSize || snake[0].X < 0 || snake[0].Y < 0)
                    {
                        timer1.Enabled = false;
                        timer2.Enabled = true;
                        timer3.Enabled = false;
                        lblRetry.Visible = true;
                        lblSaveScore1.Visible = true;
                    }
                }
            }


            for (int i = 0; i < fruit.Count; i++)
            {
                // checks if a fruit has been eaten, generates a new fruit in a non-occupied location
                if (snake[0].IntersectsWith(fruit[i]))
                {
                    if (SettingsData.level2)
                    {
                        tmrFruitSpoil.Enabled = true;
                    }
                    eat = true;
                    fruit.RemoveAt(i);
                    pictureBox1.Visible = true;
                    pictureBox1.Left = snake[0].X - SettingsData.snakeSize;
                    pictureBox1.Top = snake[0].Y - SettingsData.snakeSize;
                    for (int j = 0; j < 5; j++)
                    { // a little animation for when you eat a fruit
                        Thread.Sleep(1);
                        pictureBox1.Width += (int)(pictureBox1.Width * 0.5);
                        pictureBox1.Height += (int)(pictureBox1.Height * 0.5);
                        pictureBox1.Update();
                    }

                    count++;
                    int x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                    int y = random.Next(3, (int)(45 * SettingsData.playfieldScale));

                    for (int j = 0; j < snake.Count; j++)
                    {
                        if (SettingsData.level4)
                        { //checks for player 1 and 2's snakes
                            for (int k = 0; k < snake2.Count; k++)
                            {
                                if (x == snake[j].X / SettingsData.snakeSize || y == snake[j].Y / SettingsData.snakeSize)
                                {
                                    x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                    y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                }
                                if (x == snake2[k].X / SettingsData.snakeSize || y == snake2[k].Y / SettingsData.snakeSize)
                                {
                                    x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                    y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                }
                            }
                        }
                        if (SettingsData.level5)
                        { //checks for walls
                            for (int k = 0; k < wall.Count; k++)
                            {
                                if (x == snake[j].X / SettingsData.snakeSize || y == snake[j].Y / SettingsData.snakeSize)
                                {
                                    if (x == wall[k].X / SettingsData.snakeSize || y == wall[k].Y / SettingsData.snakeSize)
                                    {
                                        x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                        y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                    }
                                    else
                                    {
                                        x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                        y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                    }
                                }
                                if (x == snake[j].X / SettingsData.snakeSize || y == snake[j].Y / SettingsData.snakeSize)
                                {
                                    x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                    y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                }
                                if (x == wall[k].X / SettingsData.snakeSize || y == wall[k].Y / SettingsData.snakeSize)
                                {
                                    x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                    y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                }
                            }
                        }
                        if (SettingsData.level6)
                        { // checks for AI snake and player snake
                            for (int k = 0; k < enemySnake.Count; k++)
                            {
                                if (x == snake[j].X / SettingsData.snakeSize || y == snake[j].Y / SettingsData.snakeSize)
                                {
                                    if (x == enemySnake[k].X / SettingsData.snakeSize || y == enemySnake[k].Y / SettingsData.snakeSize)
                                    {
                                        x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                        y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                    }
                                    else
                                    {
                                        x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                        y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                    }
                                }
                            }
                        }
                        else
                        {
                            // checks for player snake
                            if (x == snake[j].X / SettingsData.snakeSize || y == snake[j].Y / SettingsData.snakeSize)
                            {
                                x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                            }
                        }
                    }

                    fruit.Add(new Rectangle(x * SettingsData.snakeSize, y * SettingsData.snakeSize, SettingsData.fruitSize, SettingsData.fruitSize));
                    if (SettingsData.level2)
                    {
                        // code for "spoiling" fruit (disappearing) based on distance to snake head
                        tmrFruitSpoil.Stop();
                        tmrFruitSpoil.Start();
                        if (snake[0].X - fruit[0].X > snake[0].Y - fruit[0].Y)
                        {
                            SettingsData.fruitSpoilTime = 350 * (Math.Abs(snake[0].X - fruit[0].X) / 8);
                        }
                        else if (snake[0].Y - fruit[0].Y > snake[0].X - fruit[0].X)
                        {
                            SettingsData.fruitSpoilTime = 350 * (Math.Abs(snake[0].Y - fruit[0].Y) / 8);
                        }

                        tmrFruitSpoil.Interval = SettingsData.fruitSpoilTime;
                    }
                    lblScore.Text = "Score: " + count;
                }
                if (snake2[0].IntersectsWith(fruit[i]))
                { 
                    // checks if player 2's snake eats
                    fruit.RemoveAt(i);
                    pictureBox1.Visible = true;
                    pictureBox1.Left = snake2[0].X - SettingsData.snakeSize;
                    pictureBox1.Top = snake2[0].Y - SettingsData.snakeSize;
                    for (int j = 0; j < 5; j++)
                    {
                        Thread.Sleep(1);
                        pictureBox1.Width += (int)(pictureBox1.Width * 0.5);
                        pictureBox1.Height += (int)(pictureBox1.Height * 0.5);
                        pictureBox1.Update();
                    }

                    count++;
                    int x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                    int y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                    for (int j = 0; j < snake.Count; j++)
                    {
                        for (int k = 0; k < snake2.Count; k++)
                        {
                            if (x == snake[j].X / SettingsData.snakeSize || y == snake[j].Y / SettingsData.snakeSize)
                            {
                                x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                            }
                            if (x == snake2[k].X / SettingsData.snakeSize || y == snake2[k].Y / SettingsData.snakeSize)
                            {
                                x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                                y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                            }
                        }
                    }
                    fruit.Add(new Rectangle(x * SettingsData.snakeSize, y * SettingsData.snakeSize, SettingsData.fruitSize, SettingsData.fruitSize));
                    lblScore.Text = "Score: " + count;
                }
                if (enemySnake[0].IntersectsWith(fruit[i]))
                {
                    // checks if AI snake eats
                    fruit.RemoveAt(i);
                    pictureBox1.Visible = true;
                    pictureBox1.Left = enemySnake[0].X - SettingsData.snakeSize;
                    pictureBox1.Top = enemySnake[0].Y - SettingsData.snakeSize;
                    for (int j = 0; j < 5; j++)
                    {
                        Thread.Sleep(1);
                        pictureBox1.Width += (int)(pictureBox1.Width * 0.5);
                        pictureBox1.Height += (int)(pictureBox1.Height * 0.5);
                        pictureBox1.Update();
                    }

                    count++;
                    int x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                    int y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                    for (int j = 1; j < enemySnake.Count; j++)
                    {
                        if (x == enemySnake[j].X / SettingsData.snakeSize || y == enemySnake[j].Y / SettingsData.snakeSize)
                        {
                            x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                            y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                        }
                    }
                    fruit.Add(new Rectangle(x * SettingsData.snakeSize, y * SettingsData.snakeSize, SettingsData.fruitSize, SettingsData.fruitSize));
                    lblScore.Text = "Score: " + count;
                }
                pictureBox1.Visible = false;
                pictureBox1.Width = 8;
                pictureBox1.Height = 8;
            }
            panel1.Invalidate();
        }
        private void tmrFruitSpoil_Tick(object sender, EventArgs e)
        {
            // timer for spoiling
            //removes fruit and generates new if time runs out
            if (eat == false)
            {
                // resets timer to original time if you miss 3 consecutive fruits
                eatCount++;
                if (eatCount == 3)
                {
                    SettingsData.fruitSpoilTime = 6500;
                    eatCount = 0;
                }
            }
            if (eat)
            {
                fruit.Clear();
                int x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                int y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                for (int j = 1; j < snake.Count; j++)
                {
                    if (x == snake[j].X / SettingsData.snakeSize || y == snake[j].Y / SettingsData.snakeSize)
                    {
                        x = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                        y = random.Next(3, (int)(45 * SettingsData.playfieldScale));
                    }
                }
                fruit.Add(new Rectangle(x * SettingsData.snakeSize, y * SettingsData.snakeSize, SettingsData.fruitSize, SettingsData.fruitSize));
                eat = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //blinking "game over" sign
            lblGame.Visible = !lblGame.Visible;
            
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            // simply a clock
            seconds++;
            lblTime.Text = "Time passed: " + seconds;
        }

        // the following events are related to selecting level. 
        // if you select level x, the rest of the levels will get reset and the number of the level turn orange. 
        // if you select a different level, the previous level's number will turn black.
        // if you hover over a level, that number will turn orange temporarily
        // the SettingsUpdate() method is also called
        private void lvl1_Click(object sender, EventArgs e)
        {
            SettingsData.level1 = true;
            SettingsData.level2 = false;
            SettingsData.level3 = false;
            SettingsData.level4 = false;
            SettingsData.level5 = false;
            SettingsData.level6 = false;
            SettingsData.level7 = false;
            lvl1.ForeColor = Color.Orange;
            lvl2.ForeColor = Color.Black;
            lvl3.ForeColor = Color.Black;
            lvl4.ForeColor = Color.Black;
            lvl5.ForeColor = Color.Black;
            lvl6.ForeColor = Color.Black;
            lvl7.ForeColor = Color.Black;
            SettingsUpdate();
            label14.Visible = false;
            lblVsScore.Visible = false;
            label16.Visible = false;
            lblQuirks.Visible = true;
        }
        private void lvl1_MouseHover(object sender, EventArgs e)
        {
            lvl1.ForeColor = Color.Orange;
        }
        private void lvl1_MouseLeave(object sender, EventArgs e)
        {
            if (!SettingsData.level1)
            {
                lvl1.ForeColor = Color.Black;
            }
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            SettingsData.level1 = false;
            SettingsData.level2 = true;
            SettingsData.level3 = false;
            SettingsData.level4 = false;
            SettingsData.level5 = false;
            SettingsData.level6 = false;
            SettingsData.level7 = false;
            lvl1.ForeColor = Color.Black;
            lvl2.ForeColor = Color.Orange; 
            lvl3.ForeColor = Color.Black;
            lvl4.ForeColor = Color.Black;
            lvl5.ForeColor = Color.Black;
            lvl6.ForeColor = Color.Black;
            lvl7.ForeColor = Color.Black;
            SettingsUpdate();
            label14.Visible = false;
            lblVsScore.Visible = false;
            label16.Visible = false;
            lblQuirks.Visible = false;

        }
        private void lvl2_MouseHover(object sender, EventArgs e)
        {
            lvl2.ForeColor = Color.Orange;
        }
        private void lvl2_MouseLeave(object sender, EventArgs e)
        {
            if (!SettingsData.level2)
            {
                lvl2.ForeColor = Color.Black;
            }
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            SettingsData.level1 = false;
            SettingsData.level2 = false;
            SettingsData.level3 = true;
            SettingsData.level4 = false;
            SettingsData.level5 = false;
            SettingsData.level6 = false;
            SettingsData.level7 = false;
            lvl1.ForeColor = Color.Black;
            lvl2.ForeColor = Color.Black;
            lvl3.ForeColor = Color.Orange;
            lvl4.ForeColor = Color.Black;
            lvl5.ForeColor = Color.Black;
            lvl6.ForeColor = Color.Black;
            lvl7.ForeColor = Color.Black;
            SettingsUpdate();
            label14.Visible = false;
            lblVsScore.Visible = false;
            label16.Visible = false;
            lblQuirks.Visible = false;

        }
        private void lvl3_MouseHover(object sender, EventArgs e)
        {
            lvl3.ForeColor = Color.Orange;
        }
        private void lvl3_MouseLeave(object sender, EventArgs e)
        {
            if (!SettingsData.level3)
            {
                lvl3.ForeColor = Color.Black;
            }
        }

        private void lvl4_Click(object sender, EventArgs e)
        {
            SettingsData.level1 = false;
            SettingsData.level2 = false;
            SettingsData.level3 = false;
            SettingsData.level4 = true;
            SettingsData.level5 = false;
            SettingsData.level6 = false;
            SettingsData.level7 = false;
            lvl1.ForeColor = Color.Black;
            lvl2.ForeColor = Color.Black;
            lvl3.ForeColor = Color.Black;
            lvl4.ForeColor = Color.Orange;
            lvl5.ForeColor = Color.Black;
            lvl6.ForeColor = Color.Black;
            lvl7.ForeColor = Color.Black;
            label14.Visible = true;
            lblVsScore.Visible = true;
            label16.Visible = true;
            SettingsUpdate();
            lblQuirks.Visible = false;

        }
        private void lvl4_MouseHover(object sender, EventArgs e)
        {
            lvl4.ForeColor = Color.Orange;
        }
        private void lvl4_MouseLeave(object sender, EventArgs e)
        {
            if (!SettingsData.level4)
            {
                lvl4.ForeColor = Color.Black;
            }
        }

        private void lvl5_Click(object sender, EventArgs e)
        {
            SettingsData.level1 = false;
            SettingsData.level2 = false;
            SettingsData.level3 = false;
            SettingsData.level4 = false;
            SettingsData.level5 = true;
            SettingsData.level6 = false;
            SettingsData.level7 = false;
            lvl1.ForeColor = Color.Black;
            lvl2.ForeColor = Color.Black;
            lvl3.ForeColor = Color.Black;
            lvl4.ForeColor = Color.Black;
            lvl5.ForeColor = Color.Orange;
            lvl6.ForeColor = Color.Black;
            lvl7.ForeColor = Color.Black;
            SettingsUpdate();
            label14.Visible = false;
            lblVsScore.Visible = false;
            label16.Visible = false;
            lblQuirks.Visible = false;

        }
        private void lvl5_MouseHover(object sender, EventArgs e)
        {
            lvl5.ForeColor = Color.Orange;
        }
        private void lvl5_MouseLeave(object sender, EventArgs e)
        {
            if (!SettingsData.level5)
            {
                lvl5.ForeColor = Color.Black;
            }
        }

        private void lvl6_Click(object sender, EventArgs e)
        {
            SettingsData.level1 = false;
            SettingsData.level2 = false;
            SettingsData.level3 = false;
            SettingsData.level4 = false;
            SettingsData.level5 = false;
            SettingsData.level6 = true;
            SettingsData.level7 = false;
            lvl1.ForeColor = Color.Black;
            lvl2.ForeColor = Color.Black;
            lvl3.ForeColor = Color.Black;
            lvl4.ForeColor = Color.Black;
            lvl5.ForeColor = Color.Black;
            lvl6.ForeColor = Color.Orange;
            lvl7.ForeColor = Color.Black;
            SettingsUpdate();
            label14.Visible = false;
            lblVsScore.Visible = false;
            label16.Visible = false;
            lblQuirks.Visible = false;

        }

        private void lvl6_MouseHover(object sender, EventArgs e)
        {
            lvl6.ForeColor = Color.Orange;
        }

        private void lvl6_MouseLeave(object sender, EventArgs e)
        {
            if (!SettingsData.level6)
            {
                lvl6.ForeColor = Color.Black;
            }
        }
        private void lvl7_Click(object sender, EventArgs e)
        {
            SettingsData.level1 = false;
            SettingsData.level2 = false;
            SettingsData.level3 = false;
            SettingsData.level4 = false;
            SettingsData.level5 = false;
            SettingsData.level6 = false;
            SettingsData.level7 = true;
            lvl1.ForeColor = Color.Black;
            lvl2.ForeColor = Color.Black;
            lvl3.ForeColor = Color.Black;
            lvl4.ForeColor = Color.Black;
            lvl5.ForeColor = Color.Black;
            lvl6.ForeColor = Color.Black;
            lvl7.ForeColor = Color.Orange;
            SettingsUpdate();
            label14.Visible = false;
            lblVsScore.Visible = false;
            label16.Visible = false;
            lblQuirks.Visible = false;

        }
        private void lvl7_MouseHover(object sender, EventArgs e)
        {
            lvl7.ForeColor = Color.Orange;
        }
        private void lvl7_MouseLeave(object sender, EventArgs e)
        {
            if (!SettingsData.level7)
            {
                lvl7.ForeColor = Color.Black;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        void SettingsUpdate()
        {
            // this method will try to update (almost) all of the possible variables, changes, you can make to the game
            // it will also remove any remains from previous levels if you change level, e.g. remove the walls if you 
            // switch from level 5
            SettingsData.snakeBrush = new SolidBrush(SettingsData.snakeColor);
            SettingsData.fruitBrush = new SolidBrush(SettingsData.fruitColor);
            panel1.BackColor = SettingsData.playfieldColor;
            this.Size = new Size((int)(762 * SettingsData.playfieldScale), (int)(417 * SettingsData.playfieldScale));
            this.CenterToScreen();
            panel3.Width = (int)(762 * SettingsData.playfieldScale);
            panel3.Height = (int)(393 * SettingsData.playfieldScale);
            panel4.Width = (int)(737 * SettingsData.playfieldScale);
            panel4.Height = (int)(376 * SettingsData.playfieldScale);
            panel1.Width = (int)(368 * SettingsData.playfieldScale);
            panel1.Height = (int)(368 * SettingsData.playfieldScale);
            int xDiff = (int)(368 * SettingsData.playfieldScale) - 368;
            int yDiff = (int)(368 * SettingsData.playfieldScale) - 368;
            lblStart.Left = 524 + xDiff;
            lblStart.Top = 39 + yDiff;
            lblScore.Left = 530 + xDiff;
            lblScore.Top = 128 + yDiff;
            lblTime.Left = 512 + xDiff;
            lblTime.Top = 93 + yDiff;
            lblInfo.Left = 410 + xDiff;
            lblInfo.Top = 343 + yDiff;

            if (SettingsData.level5 && updateCount < 3)
            { 
                // clears and generates 10 new walls
                wall.Clear();
                int x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                int y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                wall.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                for (int i = 0; i < 9; i++)
                {
                    bool ok = true;
                    while (ok)
                    {
                        x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        ok = false;

                        for (int j = 0; j < 10; j++)
                        {
                            if ((wallCheck = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(wall[i]))// || wallCheck.IntersectsWith(snake[i]))
                            {
                                ok = true;
                            }
                        }
                    }
                    wall.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                }

            }
            if (SettingsData.level7)
            {
                // clears and generates 2 new sets of portals
                portal1.Clear();
                portal2.Clear();
                int x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                int y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                portal1.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                x = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                y = random.Next(3, (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                portal2.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                for (int i = 0; i < 1; i++)
                {
                    bool ok = true;
                    while (ok)
                    {
                        x = random.Next((int)(5 * SettingsData.playfieldScale), (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        y = random.Next((int)(5 * SettingsData.playfieldScale), (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        ok = false;

                        for (int j = 0; j < 2; j++)
                        {
                            if ((portalCheck = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(portal1[i]))// || wallCheck.IntersectsWith(snake[i]))
                            {
                                ok = true;
                            }
                        }
                    }
                    portal1.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                }
                for (int i = 0; i < 1; i++)
                {
                    bool ok = true;
                    while (ok)
                    {
                        x = random.Next((int)(5 * SettingsData.playfieldScale), (int)(40 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        y = random.Next((int)(5 * SettingsData.playfieldScale), (int)(45 * SettingsData.playfieldScale)) * SettingsData.snakeSize;
                        ok = false;

                        for (int j = 0; j < 2; j++)
                        {
                            if ((portalCheck = new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize)).IntersectsWith(portal1[i]) || portalCheck.IntersectsWith(portal2[i]))// || wallCheck.IntersectsWith(snake[i]))
                            {
                                ok = true;
                            }
                        }
                    }
                    portal2.Add(new Rectangle(x, y, SettingsData.snakeSize, SettingsData.snakeSize));
                }
            }
            if (!SettingsData.level7)
            {
                // removes portals
                portal1.Clear();
                portal2.Clear();
            }
            if (!SettingsData.level5)
            {
                // removes walls
                wall.Clear();
            }
            panel1.Invalidate();
            panel1.Update();
            timer1.Interval = 100 / SettingsData.snakeSpeed; //changes the snake speed based on a multiplier (inverse but yeah)
            
        }
        void PortalMove()
        {
            // the actual method through which the portals function. 
            // if you go in through one side of a portal, you will emerge in the opposite direction from the other por
            // portal1 0 --> portal1 1
            if (snake[0].IntersectsWith(portal1[0]) && right)
            {
                down = false;
                up = false;
                right = false;
                left = true;
                SettingsData.x = portal1[1].X - SettingsData.snakeSize;
                SettingsData.y = portal1[1].Y;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);

            }
            if (snake[0].IntersectsWith(portal1[0]) && left)
            {
                down = false;
                up = false;
                right = true;
                left = false;
                SettingsData.x = portal1[1].X + SettingsData.snakeSize;
                SettingsData.y = portal1[1].Y;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            if (snake[0].IntersectsWith(portal1[0]) && up)
            {
                down = true;
                up = false;
                right = false;
                left = false;
                SettingsData.x = portal1[1].X;
                SettingsData.y = portal1[1].Y + SettingsData.snakeSize;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            if (snake[0].IntersectsWith(portal1[0]) && down)
            {
                down = false;
                up = true;
                right = false;
                left = false;
                SettingsData.x = portal1[1].X;
                SettingsData.y = portal1[1].Y - SettingsData.snakeSize;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            // portal1 1 --> portal1 0
            if (snake[0].IntersectsWith(portal1[1]) && right)
            {
                down = false;
                up = false;
                right = false;
                left = true;
                SettingsData.x = portal1[0].X - SettingsData.snakeSize;
                SettingsData.y = portal1[0].Y;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
;
            }
            if (snake[0].IntersectsWith(portal1[1]) && left)
            {
                down = false;
                up = false;
                right = true;
                left = false;
                SettingsData.x = portal1[0].X + SettingsData.snakeSize;
                SettingsData.y = portal1[0].Y;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            if (snake[0].IntersectsWith(portal1[1]) && up)
            {
                down = true;
                up = false;
                right = false;
                left = false;
                SettingsData.x = portal1[0].X;
                SettingsData.y = portal1[0].Y + SettingsData.snakeSize;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            if (snake[0].IntersectsWith(portal1[1]) && down)
            {
                down = false;
                up = true;
                right = false;
                left = false;
                SettingsData.x = portal1[0].X;
                SettingsData.y = portal1[0].Y - SettingsData.snakeSize;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }

            // portal2 0 --> portal2 1
            if (snake[0].IntersectsWith(portal2[0]) && right)
            {
                down = false;
                up = false;
                right = false;
                left = true;
                SettingsData.x = portal2[1].X - SettingsData.snakeSize;
                SettingsData.y = portal2[1].Y;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);

            }
            if (snake[0].IntersectsWith(portal2[0]) && left)
            {
                down = false;
                up = false;
                right = true;
                left = false;
                SettingsData.x = portal2[1].X + SettingsData.snakeSize;
                SettingsData.y = portal2[1].Y;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            if (snake[0].IntersectsWith(portal2[0]) && up)
            {
                down = true;
                up = false;
                right = false;
                left = false;
                SettingsData.x = portal2[1].X;
                SettingsData.y = portal2[1].Y + SettingsData.snakeSize;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            if (snake[0].IntersectsWith(portal2[0]) && down)
            {
                down = false;
                up = true;
                right = false;
                left = false;
                SettingsData.x = portal2[1].X;
                SettingsData.y = portal2[1].Y - SettingsData.snakeSize;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            // portal2 1 --> portal2 0
            if (snake[0].IntersectsWith(portal2[1]) && right)
            {
                down = false;
                up = false;
                right = false;
                left = true;
                SettingsData.x = portal2[0].X - SettingsData.snakeSize;
                SettingsData.y = portal2[0].Y;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            if (snake[0].IntersectsWith(portal2[1]) && left)
            {
                down = false;
                up = false;
                right = true;
                left = false;
                SettingsData.x = portal2[0].X + SettingsData.snakeSize;
                SettingsData.y = portal2[0].Y;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            if (snake[0].IntersectsWith(portal2[1]) && up)
            {
                down = true;
                up = false;
                right = false;
                left = false;
                SettingsData.x = portal2[0].X;
                SettingsData.y = portal2[0].Y + SettingsData.snakeSize;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
            if (snake[0].IntersectsWith(portal2[1]) && down)
            {
                down = false;
                up = true;
                right = false;
                left = false;
                SettingsData.x = portal2[0].X;
                SettingsData.y = portal2[0].Y - SettingsData.snakeSize;
                snake.Insert(0, (new Rectangle(SettingsData.x, SettingsData.y, SettingsData.snakeSize, SettingsData.snakeSize)));
                snake.RemoveAt(snake.Count - 1);
            }
        }

        void enemyMove()
        {
            // the math and logic through which the AI moves
            if ((Math.Abs(enemySnake[0].X - fruit[0].X) <= 3 * SettingsData.snakeSize && enemySnake[0].Y - fruit[0].Y == 0) || (Math.Abs(enemySnake[0].Y - fruit[0].Y) <= 3 * SettingsData.snakeSize && enemySnake[0].X - fruit[0].X == 0))
            {
                //checks if the snake is within 3 * the snake´s head size (24 by default)
                //and then switches to a different type of movement which can actually go for the fruit
                if (enemySnake[0].X - fruit[0].X == -3 * SettingsData.snakeSize || enemySnake[0].X - fruit[0].X == -2 * SettingsData.snakeSize || enemySnake[0].X - fruit[0].X == -SettingsData.snakeSize && enemySnake[0].Y - fruit[0].Y == 0)
                {
                    enemyRight = true;
                    enemyLeft = false;
                    enemyUp = false;
                    enemyDown = false;
                }
                else if (enemySnake[0].X - fruit[0].X == 3 * SettingsData.snakeSize || enemySnake[0].X - fruit[0].X == 2 * SettingsData.snakeSize || enemySnake[0].X - fruit[0].X == SettingsData.snakeSize && enemySnake[0].Y - fruit[0].Y == 0)
                {
                    enemyRight = false;
                    enemyLeft = true;
                    enemyUp = false;
                    enemyDown = false;
                }
                if (enemySnake[0].Y - fruit[0].Y == -3 * SettingsData.snakeSize || enemySnake[0].Y - fruit[0].Y == -2 * SettingsData.snakeSize || enemySnake[0].Y - fruit[0].Y == -SettingsData.snakeSize && enemySnake[0].X - fruit[0].X == 0)
                {
                    enemyRight = false;
                    enemyLeft = false;
                    enemyUp = false;
                    enemyDown = true;
                }
                else if (enemySnake[0].Y - fruit[0].Y == 3 * SettingsData.snakeSize || enemySnake[0].Y - fruit[0].Y == 2 * SettingsData.snakeSize || enemySnake[0].Y - fruit[0].Y == SettingsData.snakeSize && enemySnake[0].X - fruit[0].X == 0)
                {
                    enemyRight = false;
                    enemyLeft = false;
                    enemyUp = true;
                    enemyDown = false;
                }
            }
            else
            {
                // regular movement method for the AI snake, still towards fruit
                // works by comparing y-diff and x-diff between fruit and snake head.
                // if x-diff is larger, it will go horizontally until x-diff is smaller
                // than y-diff, and vice versa
                if ((fruit[0].Y < enemySnake[0].Y) && (fruit[0].X > enemySnake[0].X))
                {
                    if (!enemyDown && enemySnake[0].Y - fruit[0].Y > fruit[0].X - enemySnake[0].X)
                    {
                        enemyUp = true; 
                        enemyRight = false;
                        enemyLeft = false;
                        enemyDown = false;
                    }
                    else if (!enemyLeft && enemySnake[0].Y - fruit[0].Y < fruit[0].X - enemySnake[0].X)
                    {
                        enemyRight = true;
                        enemyUp = false;
                        enemyLeft = false;
                        enemyDown = false;
                    }

                }
                else if ((fruit[0].Y > enemySnake[0].Y) && (fruit[0].X > enemySnake[0].X))
                {
                    if (!enemyUp && fruit[0].Y - enemySnake[0].Y > fruit[0].X - enemySnake[0].X)
                    {
                        enemyDown = true;
                        enemyRight = false;
                        enemyLeft = false;
                        enemyUp = false;
                    }
                    else if (!enemyLeft && fruit[0].Y - enemySnake[0].Y < fruit[0].X - enemySnake[0].X)
                    {
                        enemyRight = true;
                        enemyDown = false;
                        enemyLeft = false;
                        enemyUp = false;
                    }
                }
                else if ((fruit[0].Y > enemySnake[0].Y) && (fruit[0].X < enemySnake[0].X))
                {
                    if (!enemyUp && fruit[0].Y - enemySnake[0].Y > enemySnake[0].X - fruit[0].X)
                    {
                        enemyDown = true;
                        enemyLeft = false;
                        enemyRight = false;
                        enemyUp = false;
                    }
                    else if (!enemyRight && fruit[0].Y - enemySnake[0].Y < enemySnake[0].X - fruit[0].X)
                    {
                        enemyLeft = true;
                        enemyDown = false;
                        enemyRight = false;
                        enemyUp = false;
                    }
                }
                else if ((fruit[0].Y < enemySnake[0].Y) && (fruit[0].X < enemySnake[0].X))
                {
                    if (!enemyDown && enemySnake[0].Y - fruit[0].Y > enemySnake[0].X - fruit[0].X)
                    {
                        enemyUp = true;
                        enemyLeft = false;
                        enemyRight = false;
                        enemyDown = false;
                    }
                    else if (!enemyRight && enemySnake[0].Y - fruit[0].Y < enemySnake[0].X - fruit[0].X)
                    {
                        enemyLeft = true;
                        enemyUp = false;
                        enemyRight = false;
                        enemyDown = false;
                    }
                }
                // code that should prevent the ai snake from going out of bounds
                if (enemySnake[0].X <= SettingsData.snakeSize)
                { 
                    if (enemySnake[0].Y >= panel1.Height / 2)
                    {
                        if (directionCount <= 0)
                        {
                            directionCount++;
                            enemyUp = true;
                            enemyLeft = false;
                            enemyRight = false;
                            enemyDown = false;
                        }
                        else if (directionCount > 0 && directionCount < 4)
                        {
                            directionCount++;
                        }
                        else if (directionCount >= 4)
                        {
                            directionCount = 0;
                            enemyRight = true;
                            enemyUp = false;
                            enemyDown = false;
                            enemyLeft = false;
                        }
                    }
                    else if (enemySnake[0].Y < panel1.Height / 2)
                    {
                        if (directionCount <= 0)
                        {
                            directionCount++;
                            enemyDown = true;
                            enemyLeft = false;
                            enemyUp = false;
                            enemyRight = false;
                        }
                        else if (directionCount > 0 && directionCount < 4)
                        {
                            directionCount++;
                        }
                        else if (directionCount >= 4)
                        {
                            directionCount = 0;
                            enemyRight = true;
                            enemyDown = false;
                            enemyLeft = false;
                            enemyUp = false;
                        }
                    }
                }
                else if (enemySnake[0].X >= panel1.Width - SettingsData.snakeSize)
                {
                    if (enemySnake[0].Y >= panel1.Height / 2)
                    {
                        if (directionCount <= 0)
                        {
                            directionCount++;
                            enemyUp = true; 
                            enemyRight = false;
                            enemyLeft = false;
                            enemyDown = false;
                        }
                        else if (directionCount > 0 && directionCount < 4)
                        {
                            directionCount++;
                        }
                        else if (directionCount >= 4)
                        {
                            directionCount = 0;
                            enemyLeft = true;
                            enemyUp = false;
                            enemyDown = false;
                            enemyLeft = false;
                        }
                    }
                    else if (enemySnake[0].Y < panel1.Height / 2)
                    {
                        if (directionCount <= 0)
                        {
                            directionCount++;
                            enemyDown = true;
                            enemyRight = false;
                            enemyLeft = false;
                            enemyUp = false;
                        }
                        else if (directionCount > 0 && directionCount < 4)
                        {
                            directionCount++;
                        }
                        else if (directionCount >= 4)
                        {
                            directionCount = 0;
                            enemyDown = false;
                            enemyLeft = true;
                            enemyUp = false;
                            enemyRight = false;
                        }
                    }
                }
                else if (enemySnake[0].Y <= SettingsData.snakeSize)
                {
                    if (enemySnake[0].X >= panel1.Width / 2)
                    {
                        if (directionCount <= 0)
                        {
                            directionCount++;
                            enemyLeft = true;
                            enemyUp = false;
                            enemyRight = false;
                            enemyDown = false;
                        }
                        else if (directionCount > 0 && directionCount < 4)
                        {
                            directionCount++;
                        }
                        else if (directionCount >= 4)
                        {
                            directionCount = 0;
                            enemyDown = true;
                            enemyLeft = false;
                            enemyUp = false;
                            enemyRight = false;
                        }
                    }
                    else if (enemySnake[0].X < panel1.Width / 2)
                    {
                        if (directionCount <= 0)
                        {
                            directionCount++;
                            enemyRight = true;
                            enemyUp = false;
                            enemyLeft = false;
                            enemyDown = false;
                        }
                        else if (directionCount > 0 && directionCount < 4)
                        {
                            directionCount++;
                        }
                        else if (directionCount >= 4)
                        {
                            directionCount = 0;
                            enemyDown = true;
                            enemyRight = false;
                            enemyUp = false;
                            enemyLeft = false;
                        }
                    }
                }
                else if (enemySnake[0].Y >= panel1.Height - SettingsData.snakeSize)
                {
                    if (enemySnake[0].X >= panel1.Width / 2)
                    {
                        if (directionCount <= 0)
                        {
                            directionCount++;
                            enemyLeft = true;
                            enemyDown = false;
                            enemyUp = false;
                            enemyRight = false;
                        }
                        else if (directionCount > 0 && directionCount < 4)
                        {
                            directionCount++;
                        }
                        else if (directionCount >= 4)
                        {
                            directionCount = 0;
                            enemyUp = true;
                            enemyLeft = false;
                            enemyRight = false;
                            enemyDown = false;
                        }
                    }
                    else if (enemySnake[0].X < panel1.Width / 2)
                    {
                        if (directionCount <= 0)
                        {
                            directionCount++;
                            enemyRight = true;
                            enemyDown = false;
                            enemyUp = false;
                            enemyLeft = false;
                        }
                        else if (directionCount > 0 && directionCount < 4)
                        {
                            directionCount++;
                        }
                        else if (directionCount >= 4)
                        {
                            directionCount = 0;
                            enemyUp = true;
                            enemyRight = false;
                            enemyDown = false;
                            enemyLeft = false;
                        }
                    }
                }
            }
            
        }

        private void AITimer_Tick(object sender, EventArgs e)
        {
            // I dont remember why this is here but it is probably important
            enemyMove();
        }


        private void closeForm_Click(object sender, EventArgs e)
        {
            // X button for custom title bar
            Application.Exit();
        }

        private void closeForm_MouseHover(object sender, EventArgs e)
        {
            // makes close button red when hovering
            closeForm.BackColor = Color.Red;
        }

        private void closeForm_MouseLeave(object sender, EventArgs e)
        {
            // removes color when moving away
            closeForm.BackColor = Color.Transparent;
        }

        private void MaxWindow_Click(object sender, EventArgs e)
        {
            // maxismises window
            // some elements scale. Not fully implemented, takes too much time
            if (!maximised)
            {
                this.WindowState = FormWindowState.Maximized;
                maximised = true;
                MaxWindow.Text = "🗗";
                this.Size = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                panel5.Width = Screen.PrimaryScreen.Bounds.Width;
                closeForm.Left = Screen.PrimaryScreen.Bounds.Width - 23;
                MaxWindow.Left = Screen.PrimaryScreen.Bounds.Width - 50;
                minWindow.Left = Screen.PrimaryScreen.Bounds.Width - 79;
            }
            //unmaximises window
            else if (maximised)
            {
                this.WindowState = FormWindowState.Normal;
                maximised = false;
                MaxWindow.Text = "🗖";
                this.Size = new Size(762, 417);
                panel5.Width = 762;
                closeForm.Left = 739;
                MaxWindow.Left = 712;
                minWindow.Left = 685;
            }
        }

        private void MaxWindow_MouseHover(object sender, EventArgs e)
        {
            // changes color of (un)maximise button when hovering
            MaxWindow.BackColor = Color.FromArgb(50, 64, 231);
        }

        private void MaxWindow_MouseLeave(object sender, EventArgs e)
        {
            // reverts previous when leaving
            MaxWindow.BackColor = Color.Transparent;
        }

        private void minWindow_Click(object sender, EventArgs e)
        {
            // minimises the window
            this.WindowState = FormWindowState.Minimized;
        }

        private void minWindow_MouseHover(object sender, EventArgs e)
        {
            // changes color of minimise button when hovering
            minWindow.BackColor = Color.FromArgb(50, 64, 231);
        }

        private void minWindow_MouseLeave(object sender, EventArgs e)
        {
            // reverts previous when leaving
            minWindow.BackColor = Color.Transparent;
        }

        private void lblSaveScore1_Click(object sender, EventArgs e)
        {
            // opens the save score dialogue
            if (!panel7.Visible)
            {
                panel7.Visible = true;
                lblShowScore.Text = lblScore.Text;
                timer2.Enabled = false;
                lblGame.Visible = false;
                lblSaveScore1.Text = "Hide Dialog";
            }
            //closes if open
            else if (panel7.Visible)
            {
                panel7.Visible = false;
                timer2.Enabled = true;
                lblSaveScore1.Text = "Save Score";
            }
        }

        private void lblSaveScore_Click(object sender, EventArgs e)
        {
            // saves score, name, and level to a file which can be retrieved later.
            if (tbName.Text != "")
            {
                lbName.Items.Add(tbName.Text);
                lbScore.Items.Add(count.ToString());
                panel7.Visible = false;
                timer2.Enabled = true;
                lblSaveScore1.Text = "Save Score";
                if (SettingsData.level1)
                {
                    lbLevel.Items.Add("1");
                }
                else if (SettingsData.level2)
                {
                    lbLevel.Items.Add("2");
                }
                else if (SettingsData.level3)
                {
                    lbLevel.Items.Add("3");
                }
                else if (SettingsData.level4)
                {
                    lbLevel.Items.Add("4");
                }
                else if (SettingsData.level5)
                {
                    lbLevel.Items.Add("5");
                }
                else if (SettingsData.level6)
                {
                    lbLevel.Items.Add("6");
                }
                else if (SettingsData.level7)
                {
                    lbLevel.Items.Add("7");
                }
                    SaveLB();
            }
            this.ActiveControl = null;
        }

        private void lblShowLB_Click(object sender, EventArgs e)
        {
            //shows/hides leaderboard window
            if (!panel8.Visible)
            {
                panel8.Visible = true;
                lblShowLB.Text = "Hide Leaderboard";
            }
            else if (panel8.Visible)
            {
                lblShowLB.Text = "Show Leaderboard";
                panel8.Visible = false;
            }
        }
        void SaveLB()
        {
            // saves leaderboard to file under %localappdata%\Snake\
            string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Snake");
            string leaderboardFile = "/leaderboard.txt";
            List<string> combined = new List<string>();
            for (int i = 0; i < lbName.Items.Count; i++)
            {
                combined.Insert(i, (lbName.Items[i].ToString() + " " + lbScore.Items[i].ToString() + " " + lbLevel.Items[i].ToString()));
            }
            if (Directory.Exists(docPath))
            {
                try
                {
                    StreamWriter file = new StreamWriter(Path.Combine(docPath + leaderboardFile));

                    foreach (string combo in combined)
                    {
                        file.WriteLine(combo);

                    }

                    file.Close();
                }
                catch (Exception t)
                {
                    //lblStatus.Text = "Filen gick inte att skriva ! " + t.Message;
                }
            }
            else
            {
                //creates %localappdata%\Snake\ if it doesnt exist
                Directory.CreateDirectory(Path.Combine(docPath));
                try
                {
                    StreamWriter file = new StreamWriter(Path.Combine(docPath + leaderboardFile));

                    foreach (string combo in combined)
                    {
                        file.WriteLine(combo);

                    }

                    file.Close();
                }
                catch (Exception t)
                {
                    //lblStatus.Text = "Filen gick inte att skriva ! " + t.Message;
                }
            }
        }
        void ClearLB()
        {
            //clears everything from the leaderboard file
            string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Snake");
            string leaderboardFile = "/leaderboard.txt";
            File.WriteAllText(Path.Combine(docPath + leaderboardFile), String.Empty);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            // cant get rid of
        }

        private void lblClearLB_Click(object sender, EventArgs e)
        {
            ClearLB();
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            //clears from the ingame leaderboard, not file
            lbName.Items.Clear();
            lbScore.Items.Clear();
            lbLevel.Items.Clear();
        }

        private void lblLoadLB_Click(object sender, EventArgs e)
        {
            // loads the saved leaderboard file into separate columns for name, score and level
            List<string> names = new List<string>();
            List<string> scores = new List<string>();
            List<string> levels = new List<string>();
            int index;
            int index2;
            string docPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/Snake");
            string leaderboardFile = "/leaderboard.txt";
            lbName.Items.Clear();
            lbScore.Items.Clear();
            lbLevel.Items.Clear();
            foreach (string line in File.ReadLines(Path.Combine(docPath + leaderboardFile)))
            {
                index = line.IndexOf(" ");
                index2 = line.IndexOf(" ", index + 1);
                names.Add(line.Substring(0, index));
                scores.Add(line.Substring(index, index + 1));
                levels.Add(line.Substring(index2));
            }
            foreach (string name in names)
            {
                lbName.Items.Add(name);
            }
            foreach (string score in scores)
            {
                lbScore.Items.Add(score);
            }
            foreach (string level in levels)
            {
                lbLevel.Items.Add(level);
            }
        }
        private void testLabel_Click(object sender, EventArgs e)
        {
            //cant get rid of this idk
        }

        private void timerX_Tick(object sender, EventArgs e)
        {
            // same thing
        }
        private void timerY_Tick(object sender, EventArgs e)
        {
            // see above
        }
    }

    public static class SettingsData
    {
        // class created in order to efficiently and easily be able to
        // transfer settings between Form1 and Form2, the settings form
        public static Random rand = new Random();
        public static int snakeSize = 8;
        public static int snakeSpeed = 1;
        public static int startingLength = 1;
        public static bool rainbowSnake = false;
        public static bool randomSnake = false;
        public static bool invincibleSnake = false;
        public static Color snakeColor = Color.Lime;
        public static SolidBrush snakeBrush;
        
        
        public static int fruitCount = 1;
        public static int fruitSize = 8;
        public static int fruitSpoilTime = 6500;
        public static int fruitGrowthFactor = 1;
        public static bool rainbowFruit = false;
        public static Color fruitColor = Color.Red;
        public static SolidBrush fruitBrush;

        public static int y = 48;
        public static int x = 48;
        public static int x2 = 304;
        public static int y2 = 304;
        public static bool right = true;
        public static bool left = false;
        public static bool up = false;
        public static bool down = false;

        public static Color playfieldColor = Color.Black;
        public static double playfieldScale = 1;
        public static int pWidth;
        public static int pHeight;

        public static bool level1 = true;
        public static bool level2 = false;
        public static bool level3 = false;
        public static bool level4 = false;
        public static bool level5 = false;
        public static bool level6 = false;
        public static bool level7 = false;
    }

}