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
    public partial class EditAdvisor : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public EditAdvisor()

        {

            InitializeComponent();
        }
        All_Advisor aadv = null;
        long advnum = 0;
        public EditAdvisor(All_Advisor adv, long Id)
        {
            InitializeComponent();
            this.aadv = adv;
            this.advnum = Id;

        }

        private void EditAdvisor_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_add_adv_Click(object sender, EventArgs e)
        {
            try
            {
                if (val() == 0)
                {


                    int key = Convert.ToInt32(txt_adv_id.Text);
                    SqlConnection con = new SqlConnection(conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string p = "UPDATE Advisor SET Designation= (SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_desig.Text) + "'), Salary =('" + Convert.ToDecimal(txt_adv_sal.Text) + "')WHERE Id ='" + Convert.ToInt32(txt_adv_id.Text) + "';";


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
            if (string.IsNullOrEmpty(txt_adv_id.Text))
            {


                errorProvider1.SetError(txt_adv_id, MessageBox.Show("Please Enter Id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_adv_id.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(com_desig.Text))
            {

                errorProvider1.SetError(com_desig, MessageBox.Show("Please Select  Designation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                com_desig.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(txt_adv_sal.Text))
            {

                errorProvider1.SetError(txt_adv_id, MessageBox.Show("Please Enter Salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_adv_sal.Focus();
                t = 1;


            }
            return t;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
