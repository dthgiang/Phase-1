using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess;
using Oracle.ManagedDataAccess.Client;

namespace PhanHe1
{
    public partial class Form1 : Form
    {
        OracleConnection connection = null;
        public Form1()
        {
            InitializeComponent();
            string connectionString = "TNS_ADMIN=C:\\Users\\ADMIN\\Oracle\\network\\admin;USER ID=GOD;Password=123;DATA SOURCE=localhost:1521/XE;PERSIST SECURITY INFO=True";
            connection = new OracleConnection(connectionString);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2= new Form2(connection);
            f2.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
