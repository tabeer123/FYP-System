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
    public partial class EditEvaluation : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public EditEvaluation()
        {
            InitializeComponent();
        }
       AllEvaluations aadv = null;
        long advnum = 0;


        public EditEvaluation(AllEvaluations all, long id)
        {
            InitializeComponent();
            this.aadv = all;
            this.advnum = id;
        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {
            if (val() == 0)
            {


                try
                {
                    int key = Convert.ToInt32(txt_eval_id.Text);
                    SqlConnection con = new SqlConnection(conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string p = "UPDATE Evaluation SET Name=('" + txt_name.Text.ToString() + "'),TotalMarks =('" + Convert.ToInt32(txt_mark.Text) + "'), TotalWeightage=('" + Convert.ToInt32(txt_totwet.Text) + "')WHERE Id = '" + Convert.ToInt32(txt_eval_id.Text) + "';";


                        SqlCommand cmd = new SqlCommand(p, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Congrats! Data Update Successfully");

                        con.Close();
                    }
                    // Student std = new Student();
                    //this.Hide();
                    //    std.Show();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void EditEvaluation_Load(object sender, EventArgs e)
        {

        }
        private int val()
        {
            int t = 0;
            if (string.IsNullOrEmpty(txt_name.Text))
            {


                errorProvider1.SetError(txt_name, MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_name.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(txt_mark.Text))
            {

                errorProvider1.SetError(txt_mark, MessageBox.Show("Please Select  Total Marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_mark.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(txt_totwet.Text))
            {

                errorProvider1.SetError(txt_totwet, MessageBox.Show("Please Enter Total Weightage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_totwet.Focus();
                t = 1;


            }
            return t;
        }

    }
}
