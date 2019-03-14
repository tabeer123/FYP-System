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

                ////string q = "INSERT INTO GroupEvaluation(GroupId, EvaluationId, ObtainedMarks, EvaluationDate )VALUES('" + com_adv_id.Text + "','" + com_pro_id.Text + "', (SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_adv_role.Text) + "') ,'" + Convert.ToDateTime(dtp_assign_date.Value) + "');";
                //SqlCommand cmd = new SqlCommand(q, con);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Data Inserted Successfully");

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
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
                            String query = "INSERT INTO GroupStudent (GroupId,StudentId,Status,AssignmentDate)VALUES((select MAX(Id) FROM [Group]),('" + dataGridView1.Rows[i].Cells[0].Value + "'),(Select Id from Lookup Where Lookup.Value = '" + comboBox1.Text + "'),('" + Convert.ToDateTime(dateTimePicker1.Text) + "'));";
                            SqlCommand cmd = new SqlCommand(query, con);
                            cmd.ExecuteNonQuery();
                        }


                    }
                }
            }
        }
    }
}
