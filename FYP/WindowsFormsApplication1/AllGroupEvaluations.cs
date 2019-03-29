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
    public partial class AllGroupEvaluations : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public AllGroupEvaluations()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    EditStudent edit = new EditStudent();
                    edit.txt_id.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    edit.txtfname.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    edit.txt_lname.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    edit.txt_contact.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    edit.txt_email.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

                    edit.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    string t = "DELETE FROM GroupEvaluation where EvaluationId = '" + row.Cells[2].Value + "';";

                    //string q = "DELETE FROM Student where Id = '" + row.Cells[2].Value + "';";
                    //string p = "DELETE FROM Person where Id = '" + row.Cells[2].Value + "';";
                    //// string t = "DELETE FROM  where Id = '" + row.Cells[2].Value + "';";
                    //SqlCommand cmt = new SqlCommand(t, con);
                    //cmt.ExecuteNonQuery();
                    //SqlCommand cm = new SqlCommand(q, con);
                    //cm.ExecuteNonQuery();
                    SqlCommand cmd = new SqlCommand(t, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Congrats! Record Recorded");
                    SqlDataAdapter sql = new SqlDataAdapter("SELECT * from GroupEvaluation", con);
                    DataTable datatab = new DataTable();
                    sql.Fill(datatab);
                    dataGridView1.DataSource = datatab;
                    con.Close();










                }
                AllStudentInfo std = new AllStudentInfo();
                this.Hide();
                std.Show();
            }
        }

        private void AllGroupEvaluations_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from GroupEvaluation;", con);
                DataTable datatab = new DataTable();
                sda.Fill(datatab);
                dataGridView1.DataSource = datatab;

            }

        }
    }
}