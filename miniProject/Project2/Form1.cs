using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ���Ŀ� ���̺� ����� ��ũ�� �ٷ� �޾ƿ��� �ɷ� �ٲٱ�
        // ���粫 ��ȸ ��ư ������ ����Ǵ°ɷ� �ϱ�!
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            // �Է� ������ ����
            string uid = txtUid.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;

            DBAccess.Instance.InsertUser(uid, name, hp, age);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = DBAccess.Instance.SelectUsers();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUid.Text = "";
            txtName.Text = "";
            txtHp.Text = "";
            nAge.Value = 0;
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            // Console.WriteLine(row);
            DataGridViewRow dataRow = dataGrid.Rows[row];

            txtUid.Text = dataRow.Cells[0].Value.ToString();
            txtName.Text = dataRow.Cells[1].Value.ToString();
            txtHp.Text = dataRow.Cells[2].Value.ToString();
            nAge.Text = dataRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            string name = txtName.Text;
            string hp = txtHp.Text;
            string age = nAge.Text;
            DBAccess.Instance.UpdateUser(uid, name, hp, age);
            MessageBox.Show("�����Ͱ� �����Ǿ����ϴ�.", "Ȯ��");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            DialogResult result = MessageBox.Show("�����͸� �����Ͻðڽ��ϱ�?.", "Ȯ��", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DBAccess.Instance.DeleteUser(uid);
                MessageBox.Show("�����Ͱ� �����Ǿ����ϴ�.", "Ȯ��");
            }

        }
    }
}