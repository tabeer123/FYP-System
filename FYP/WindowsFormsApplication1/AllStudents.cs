using System;
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
    public partial class AllStudents : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public AllStudents()
        {
            InitializeComponent();
        }

        private void AllStudents_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                DataGridViewCheckBoxColumn hello = new DataGridViewCheckBoxColumn();
                hello.HeaderText = "Select Students";
                hello.Name = "Select Students";
                if (con.State == ConnectionState.Open)
                {

                    SqlDataAdapter sqlda = new SqlDataAdapter("select * from Student", con);
                    DataTable datatab = new DataTable();
                    sqlda.Fill(datatab);
                    dataGridView1.DataSource = datatab;
                    dataGridView1.Columns.Add(hello);

                  
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {

                        if ((dataGridView1.Rows[i].Cells[2].Value) != null)
                        {
                            if ((Boolean)dataGridView1.Rows[i].Cells[2].Value == true)
                            {
                                String query = "INSERT INTO GroupStudent (GroupId,StudentId,Status,AssignmentDate)VALUES((select MAX(Id) FROM [Group]),('" + dataGridView1.Rows[i].Cells[0].Value + "'),(Select Id from Lookup Where Lookup.Value = '" + com_sta.Text + "'),('" + Convert.ToDateTime(dtp_assign.Text) + "'));";
                                SqlCommand cmd = new SqlCommand(query, con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Congrats! Data Recorded");
                            }


                        }
                    }
                }
                GroupStudent std = new GroupStudent();
                this.Hide();
                std.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
