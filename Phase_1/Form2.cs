﻿using System;
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


        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Get the size of the primary screen
            Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

            // Calculate the location of the form to be centered on the screen
            int x = (workingArea.Width - this.Width) / 2;
            int y = (workingArea.Height - this.Height) / 2;

            // Set the location of the form
            this.Location = new Point(x, y);

            OracleDataAdapter adt = new OracleDataAdapter("select * from sys.USER_INFO", connection);

            DataTable userTable = new DataTable();

            adt.Fill(userTable);
            dataGridView1.DataSource = userTable;
        }
         private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                UserTextBox.Text = selectedRow.Cells["USERNAME"].Value.ToString();

            }
        }
        private void userProfileButton_Click(object sender, EventArgs e)
        {
            string username = UserTextBox.Text;
            System.Diagnostics.Debug.WriteLine(username);
        }

 

        // for searching user
        private void searchField_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchname = searchField.Text;
            searchField.Text = "";
            System.Diagnostics.Debug.WriteLine(searchname);
        }

       
    }
}
