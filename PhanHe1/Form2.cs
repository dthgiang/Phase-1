using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;


namespace PhanHe1
{
    public partial class Form2 : Form
    {
        OracleConnection connection = null;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(OracleConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("User");
            comboBox1.Items.Add("Role");

            OracleDataAdapter adt = new OracleDataAdapter("select * from ALL_USERS", connection);

            DataTable userTable = new DataTable();

            adt.Fill(userTable);
            dataGridView1.DataSource = userTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
