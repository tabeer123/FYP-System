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
    public partial class EditGroupEvaluation : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public EditGroupEvaluation()
        {
            InitializeComponent();
        }
        GroupEvaluation aadv = null;
        long advnum = 0;
        public EditGroupEvaluation(GroupEvaluation adv, long Id)
        {
            InitializeComponent();
            this.aadv = adv;
            this.advnum = Id;

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {

            try
            {
                if (val() == 0)
                {


                    int key = Convert.ToInt32(txt_evalid.Text);
                    SqlConnection con = new SqlConnection(conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string p = "UPDATE GroupEvaluation SET Designation= (SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_gro_id.Text) + "'), Salary =('" + Convert.ToDecimal(txt_evalid.Text) + "')WHERE Id ='" + Convert.ToInt32(txt_obtainmark.Text) + "';";

                       // "INSERT INTO GroupEvaluation(GroupId,EvaluationId,ObtainedMarks,EvaluationDate)VALUES((select Id from [Group] where [Group].Id = '" + com_gro_id.Text + "'),(select MAX(Id) from Evaluation),('" + Convert.ToInt32(txt_evalid.Text) + "'),('" + Convert.ToDateTime(dtp_evaluation_date.Text) + "'));"
                        SqlCommand cmd = new SqlCommand(p, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Congrats! Data Update Successfully");

                        con.Close();
                    }
                    // Student std = new Student();
                    //this.Hide();
                    //    std.Show();



                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private int val()
        {
            int t = 0;
            if (string.IsNullOrEmpty(com_gro_id.Text))
            {


                errorProvider1.SetError(com_gro_id, MessageBox.Show("Please Select Group Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                com_gro_id.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(txt_evalid.Text))
            {

                errorProvider1.SetError(txt_evalid, MessageBox.Show("Please Make sure you have evaluation Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
               txt_evalid.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(txt_obtainmark.Text))
            {

               errorProvider1.SetError(txt_obtainmark, MessageBox.Show("Please Enter Obtain Marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_obtainmark.Focus();
                t = 1;


            }
            return t;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
