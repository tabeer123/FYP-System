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
    public partial class GroupEvaluation : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public GroupEvaluation()
        {
            InitializeComponent();
            evaluationid();
            groupid();
        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                String q = "INSERT INTO GroupEvaluation(GroupId,EvaluationId,ObtainedMarks,EvaluationDate)VALUES((select Id from [Group] where [Group].Id = '" + com_gro_id.Text + "'),('"+ Convert.ToInt32(com_evalid.Text)+"'),('" + Convert.ToInt32(txt_obtainmark.Text) + "'),('" + Convert.ToDateTime(dtp_evaluation_date.Value) + "'));";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");

            }
           AllGroupEvaluations  std = new AllGroupEvaluations();
            this.Hide();
            std.Show();
        }
        public void groupid()
        {
            com_gro_id.Items.Clear();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string q = "Select Id FROM [Group]";
                SqlCommand cmd = new SqlCommand(q, con);

                try
                {

                    SqlDataReader myread = cmd.ExecuteReader();
                    while (myread.Read())
                    {
                        string id = myread["Id"].ToString();
                        com_gro_id.Items.Add(id);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Student std = new Student();
            //this.Hide();
            //std.Show();
            con.Close();


        }
        public void evaluationid()
        {
            com_evalid.Items.Clear();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string q = "Select Id FROM Evaluation";
                SqlCommand cmd = new SqlCommand(q, con);

                try
                {

                    SqlDataReader myread = cmd.ExecuteReader();
                    while (myread.Read())
                    {
                        string id = myread["Id"].ToString();
                        com_evalid.Items.Add(id);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //Student std = new Student();
            //this.Hide();
            //std.Show();
            con.Close();


        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
