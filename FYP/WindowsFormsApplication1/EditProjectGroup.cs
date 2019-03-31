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
    public partial class EditProjectGroup : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public EditProjectGroup()
        {
            InitializeComponent();
        }
        AllProjectGroups aadv = null;
        long advnum = 0;
        public EditProjectGroup(AllProjectGroups all, long id)
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
                    int key = Convert.ToInt32(txt_grpid.Text);
                    int key1 = Convert.ToInt32(txt_evalid.Text);
                    SqlConnection con = new SqlConnection(conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string p = "UPDATE [ProjectA].[dbo].[GroupProject] SET AssignmentDate=('" + Convert.ToDateTime(dtp_evaluation_date.Value) + "')WHERE ProjectId = '" + (txt_evalid.Text) + "' And GroupId = '" + (txt_grpid.Text) + "'  ;";


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
        private int val()
        {
            int t = 0;
            if (string.IsNullOrEmpty(txt_grpid.Text))
            {


                errorProvider1.SetError(txt_grpid, MessageBox.Show("Please Enter Group ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_grpid.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(txt_evalid.Text))
            {

                errorProvider1.SetError(txt_evalid, MessageBox.Show("Please Enter Evaluation ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_evalid.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(dtp_evaluation_date.Text))
            {

                errorProvider1.SetError(dtp_evaluation_date, MessageBox.Show("Please Enter Date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                dtp_evaluation_date.Focus();
                t = 1;


            }
            return t;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
