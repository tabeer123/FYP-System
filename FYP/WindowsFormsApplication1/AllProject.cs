﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class AllProject : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public AllProject()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    EditProject edit = new EditProject();
                    edit.txt_pro_id.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    edit.txt_descrip.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    edit.txt_pro_title.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();

                    edit.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    string q = "DELETE FROM Project where Id = '" + row.Cells[2].Value + "';";

                    SqlCommand cm = new SqlCommand(q, con);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Congrats! Record Recorded");
                    SqlDataAdapter sql = new SqlDataAdapter("SELECT Id, Description, Title from Project;", con);
                    DataTable datatab = new DataTable();
                    sql.Fill(datatab);
                    dataGridView1.DataSource = datatab;
                    con.Close();

                }
                AllProject std = new AllProject();
                this.Hide();
                std.Show();
            }
        }

        private void AllProject_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Project;", con);
                DataTable datatab = new DataTable();
                sda.Fill(datatab);
                dataGridView1.DataSource = datatab;
               
            }
            
        }
    }
}