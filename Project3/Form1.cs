

namespace Project3
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Pen pen;
        private Brush wBrush, bBrush;

        private const int margin = 40;
        private const int sizeNun = 30;
        private const int sizeDol = 28;

        private bool isWhite = false;
        private bool isWin = false;
        // enum STONE { none, black, white };
        // STONE[,] dataSet = new STONE[19, 19];

        private Omok omok = new Omok();

        public Form1()
        {
            InitializeComponent();

            // �׷��� ��ü �ʱ�ȭ
            this.g = this.CreateGraphics();
            this.pen = new Pen(Color.Black);
            this.wBrush = new SolidBrush(Color.White);
            this.bBrush = new SolidBrush(Color.Black);

            // �ٵ��� ��, ũ�� ����
            this.BackColor = Color.DarkOrange;
            this.ClientSize = new Size(2 * margin + 18 * sizeNun, 2 * margin + 18 * sizeNun);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        // ���� main?
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (e.X - margin + sizeNun / 2) / sizeNun;
            int y = (e.Y - margin + sizeNun / 2) / sizeNun;

            Omok.chkidx(x, y);
            // Console.WriteLine($"x : {x}, y : {y}");

            // ���� �����ִ��� Ȯ��
            if (Omok.dataSet[x, y] != Omok.STONE.none)
            {
                MessageBox.Show("�̹� ���� �����ֽ��ϴ�.");
                return;
            }

            // ������, �� �׸���
            Rectangle dol = new Rectangle(Form1.margin + (Form1.sizeNun * x) - (Form1.sizeNun / 2), 
                                          Form1.margin + (Form1.sizeNun * y) - (Form1.sizeNun / 2), 
                                          Form1.sizeNun, Form1.sizeNun);
            
            if (isWhite)
            {
                g.FillEllipse(wBrush, dol);
                Omok.dataSet[x, y] = Omok.STONE.white;
            }
            else
            { 
                g.FillEllipse(bBrush, dol); 
                Omok.dataSet[x, y] = Omok.STONE.black;
            }

            // ���� ����
            this.isWin = Omok.chkNum(x, y, 5);
            
            if (this.isWin)
            {
                DialogResult result = MessageBox.Show("�����Դϴ�! ���ο� ������ �����ұ��?", "�¸�", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Action NewGame = new Action(() =>
                    {
                        this.Invalidate();
                        for (int i = 0; i < 19; i++)
                        {
                            for (int j = 0; j < 19; j++)
                            {
                                Omok.Set_dataSet();
                            }
                        }
                    });
                    NewGame();
                    return;
                }
                else
                {
                    this.Close();
                }
            }

            // ���� ����
            this.isWhite = (this.isWhite == true? false:true);
        }

        // ȭ���� ���̰� �ø��� ��� update�Ѵ�
        protected override void OnPaint(PaintEventArgs e)
        {
            Console.WriteLine("On Paint!");
            for (int i = 0; i < 19; i++)
            {
                this.g.DrawLine(pen, new Point(Form1.margin, Form1.margin + (i * Form1.sizeNun)), new Point(Form1.margin + (18 * Form1.sizeNun), Form1.margin + (i * Form1.sizeNun)));
                this.g.DrawLine(pen, new Point(Form1.margin + (i * Form1.sizeNun), Form1.margin), new Point(Form1.margin + (i * Form1.sizeNun), Form1.margin + (18 * Form1.sizeNun)));
            }
        }
    }
}