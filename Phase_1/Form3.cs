using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Phase_1
{
    public partial class Form3 : Form
    {
        OracleConnection connection = null;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(OracleConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

        }
        private void raiseTable(string SQLCommand)
        {
            OracleDataAdapter adt = new OracleDataAdapter(SQLCommand, connection);

            DataTable userTable = new DataTable();

            adt.Fill(userTable);
            dataGridView1.DataSource = userTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            if (selectedValue == "Role")
            {
                raiseTable("select * from god.USER_PRIVS");
            }
            else
            {
                raiseTable("select * from god.ROLE_PRIVS");
            }
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            // Get the size of the primary screen
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Calculate the location of the form to be centered on the screen
            int x = (workingArea.Width - this.Width) / 2;
            int y = (workingArea.Height - this.Height) / 2;

            // Set the location of the form
            this.Location = new Point(x, y);
            raiseTable("select * from god.USER_PRIVS");
        }
    }
}
