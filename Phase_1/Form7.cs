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
    public partial class Form7 : Form
    {
        OracleConnection con = null;

        String objselect;
        public Form7(OracleConnection connection)
        {
            InitializeComponent();
            this.con = connection;
        }
        private void Form7_Load(object sender, EventArgs e)
        {
            // Get the size of the primary screen
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Calculate the location of the form to be centered on the screen
            int x = (workingArea.Width - this.Width) / 2;
            int y = (workingArea.Height - this.Height) / 2;

            // Set the location of the form
            this.Location = new Point(x, y);

            dgv.Hide();
        }



  

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        { 
            dgv.Show();
            objselect = comboBox1.Text;
            String strsql = null;
            if (objselect == "Role")
            {
                strsql = "SELECT grantee, granted_role, admin_option FROM dba_role_privs";
            }
            else if (objselect == "User")
            {
                strsql = "SELECT grantee, owner, table_name, privilege, grantable  FROM dba_tab_privs";
            }

            OracleDataAdapter da = new OracleDataAdapter(strsql, con);
            //OracleCommandBuilder builder = new OracleCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
    }
}
