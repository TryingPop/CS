namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�⺻ �޼��� �ڽ�");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // Caption : �޼����ڽ� Ÿ��Ʋ
            MessageBox.Show("����� ������ �ִ� �޼��� �ڽ�", "��ư 2 Ŭ��");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("�ΰ��� ��ư�� ���� �޼��� �ڽ�", "��ư 3 Ŭ��", MessageBoxButtons.YesNo);
            
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("��?");
            }
            else
            {
                MessageBox.Show("�״Ͽ�?");
            }
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "��� : " + uid;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHp.Text;
            lbHp.Text = "��� : " + hp;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lbName.Text = "��� : " + name;
        }

        private void btnChkFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chkFruits = { chkFruit1, chkFruit2, chkFruit3, chkFruit4};
            List<string> fruits = new List<string>();

            foreach (CheckBox chk in chkFruits)
            {
                if (chk.Checked)
                {
                    fruits.Add(chk.Text);
                }
            }

            lbFruitResult.Text = "��� : " + String.Join(", ", fruits);
        }

        private void btnChkColor_Click(object sender, EventArgs e)
        {
            // bool�������� ����
            CheckBox[] chkColors = { chkColor1, chkColor2, chkColor3, chkColor4 };
            List<string> colors = new List<string>();

            
            foreach (CheckBox chk in chkColors)
            {
                if (chk.Checked)
                {
                    colors.Add(chk.Text);
                }
            }

            lbColorResult.Text = "��� : " + String.Join(", ", colors);
        }

        private void btnSF_Click(object sender, EventArgs e)
        {
            // �ڵ����� Form2�� �׷��ȴ�
            new Form2().ShowDialog();
        }

        private void btnSF2_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}