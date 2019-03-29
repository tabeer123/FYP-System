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
        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                String q = "INSERT INTO GroupEvaluation(GroupId,EvaluationId,ObtainedMarks,EvaluationDate)VALUES((select Id from [Group] where [Group].Id = '" + com_gro_id.Text + "'),(select MAX(Id) from Evaluation),('" + Convert.ToInt32(txt_evalid.Text) + "'),('" + Convert.ToDateTime(dtp_evaluation_date.Text) + "'));";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");

            }
            AllGroupEvaluations std = new AllGroupEvaluations();
            this.Hide();
            std.Show();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
