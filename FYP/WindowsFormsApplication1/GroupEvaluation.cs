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
                ////string q = "INSERT INTO GroupEvaluation(GroupId, EvaluationId, ObtainedMarks, EvaluationDate )VALUES('" + com_adv_id.Text + "','" + com_pro_id.Text + "', (SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_adv_role.Text) + "') ,'" + Convert.ToDateTime(dtp_assign_date.Value) + "');";
                //SqlCommand cmd = new SqlCommand(q, con);
                //cmd.ExecuteNonQuery();
                //MessageBox.Show("Data Inserted Successfully");

            }
        }
    }
}
