namespace Project4
{
    public partial class Form1 : Form
    {
        Graphics g;
        Brush racketBrush = new SolidBrush(Color.Red);
        Brush blockBrush = new SolidBrush(Color.Orange);
        Brush ballBrush = new SolidBrush(Color.Gold);
        Pen pen = new Pen(Color.Black);

        Rectangle racket = new Rectangle();
        Rectangle[] blocks = new Rectangle[100];
        Rectangle ball = new Rectangle();

        const int nBlock = 12;
        int lines = 1;
        
        int racketW = 480;
        int racketH = 10;
        int racketY = 50;
        
        const int blockW = 30;
        const int blockH = 10;
        const int blockY = 10;

        const int ballW = 10;
        const int ballH = 10;

        const int frameW = 5;

        int diry = 0;
        int dirx = 1;
        double slope = 0;
        int speed = 10;

        int bNum = 0;
        int score = 0;
        Random rand = new Random();

        // ����ȭ��
        public Form1()
        {
            InitializeComponent();

            // �� ������
            this.Text = "�������� v1.0";
            // this.ClientSize = new Size(480, 480);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            g = this.CreateGraphics();

            // ��� �ʱ�ȭ
            initBlock();

            // ���� �ʱ�ȭ
            initRacket();

            // �� �ʱ�ȭ
            initBall();
        }

        public void initBlock()
        {
            /*
            for (int i = 0; i < nBlock; i++)
            {
                blocks[i] = new Rectangle(blockW * (i % 10),
                                          blockY + blockH * (i/10),
                                          blockW - 1, blockH -1);
            }
            */

            for (int j = 0; j < lines; j++)
            {
                for (int i = 0; i < nBlock; i++)
                {
                    blocks[nBlock * j + i] = new Rectangle((4 * (2 * i + 1)) + i * blockW, 
                                                    20 + blockY*(j + 1) + j * blockH, 
                                                    blockW, 
                                                    blockH
                                                    );
                } 
            }
            bNum = lines * nBlock;
        }

        public void initRacket()
        {
            racket.X = ((this.Width - frameW) - racketW) / 2;
            racket.Y = this.Height - racketH - racketY;
            racket.Width = racketW;
            racket.Height = racketH;
        }

        public void initBall()
        {
            ball.X = ((this.Width - frameW) - ballW) / 2;
            ball.Y = this.Height / 2 ;
            ball.Width = ballW;
            ball.Height = ballH;

            // ���� �ʱ�ȭ
            Setslope();

            if (rand.Next(2) % 2 == 1)
            {
                dirx = -1;
            }

            diry = 1;

            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            // ���� ǥ��
            lbSc.Text = score.ToString();

            // ���� �׸���
            for (int i = 0; i < blocks.Length; i++)
            {
                g.FillRectangle(blockBrush, blocks[i]);
            }

            // ���� �׸���
            g.FillRectangle(racketBrush, racket);

            // �� �׸���
            g.FillEllipse(ballBrush, ball);
            
            g.DrawEllipse(pen, ball);
        }

        // Ÿ�̸� �ð����� 
        private void myTimer_Tick(object sender, EventArgs e)
        {
            // ��� ���� 0 ���� �¸�
            if (bNum == 0)
            {
                Victory();
            }

            // ���� ������
            double dx = speed / slope * dirx;
            double dy = speed * slope * diry;

            int x = (int)dx;
            int y = (int)dy;

            ball.Y += y;
            ball.X += x;
            // ���� ��ǥ �ʱ�ȭ
            SetRacket();
            // ball�� �¿� ���� �浹���� ��
            WallCollision();
            // ball�� racket�� �浹������
            RacketCollision();
            // ball�� ������ �浹���� ��
            BlockCollision();



            this.Invalidate();
        }

        public void GameOver()
        {
            // ���� ����
            myTimer.Stop();

            DialogResult result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?", "���� ����", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                initBlock();
                initBall();
                initRacket();

                myTimer.Start();
            }
            else
            {
                // this.Close();
            }
        }
        
        public void Victory()
        {
            myTimer.Stop();

            DialogResult result = MessageBox.Show("�ٽ� �����Ͻðڽ��ϱ�?", "���� �¸�", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                lines++;
                racketW--;
                if (lines > 8)
                {
                    lines = 8;
                }
                if (racket.Width < 30)
                {
                    racket.Width = 20;
                }
                initBlock();
                initBall();
                initRacket();

                myTimer.Start();
            }
            else
            {
                // this.Close();
            }
        }
        // �� �� �浹 ����
        public void WallCollision()
        {
            if (ball.X < 0) 
            {
                dirx *= -1;
                ball.X = 0;
            }
            else if (ball.X >= (this.Width - frameW) - ball.Width) 
            {
                dirx *= -1;
                ball.X = (this.Width - frameW) - 3 * ball.Width;
            }
            if (ball.Y < 0)
            {
                ball.Y = 0;
                diry *= -1;
            }
            else if (ball.Y >= this.Height)
            {
                GameOver();
            }
        }
        // �� ���� �浹 ����
        public void RacketCollision()
        {
            if (Collision(ball, racket))
            {
                ball.Y = racket.Y - ball.Height;
                diry *= -1;
                Setslope();
            }
        }
        // �� �� �浹 ����
        public void BlockCollision()
        {
            for (int i = 0; i < blocks.Length; i++)
            {
                if (Collision(ball, blocks[i]))
                {
                    diry *= -1;
                    blocks[i] = new Rectangle();
                    Setslope();
                    bNum--;
                    score++;
                }
            }
        }

        // �浹
        public bool Collision(Rectangle rect1, Rectangle rect2)
        {
            if (rect1.X < rect2.X + rect2.Width 
                && rect1.X + rect1.Width > rect2.X 
                && rect1.Y < rect2.Y + rect2.Height
                && rect1.Y + rect1.Height > rect2.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Setslope()
        {
            // ���� �ʱ�ȭ
            slope = rand.Next(5, 20) / 10.0;
        }

        public void SetRacket()
        {
            if (racket.X < 0)
            {
                racket.X = 0;
            }
            if (racket.X >= (this.Width - frameW) - racket.Width)
            {
                racket.X = (this.Width - frameW) - racket.Width;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                racket.X -= 10;

            }
            if (e.KeyCode == Keys.Right)
            {
                racket.X += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                bNum = 0;
                MessageBox.Show("ġƮŰ�� ����ϼ̽��ϴ�.", "���");
                score = int.MinValue;
            }
        }
    }
}