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
    public partial class EditStudent : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public EditStudent()
        {
            InitializeComponent();
        }
        AllStudentInfo aadv = null;
        long advnum = 0;
        public EditStudent(AllStudentInfo all, long id)
        {
            InitializeComponent();
            this.aadv = all;
            this.advnum = id;

        }

        private void EditStudent_Load(object sender, EventArgs e)
        {

        }

        private void btn_editstd_Click(object sender, EventArgs e)
        {
            if (val() == 0)
            {
                try
                {
                    int key = Convert.ToInt32(txt_id.Text);
                    SqlConnection con = new SqlConnection(conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string p = "UPDATE Person SET FirstName=('" + txtfname.Text.ToString() + "'), LastName=('" + txt_lname.Text.ToString() + "'),Contact =('" + txt_contact.Text.ToString() + "'),Email =('" + txt_email.Text.ToString() + "'),DateOfBirth=('" + Convert.ToDateTime(dtp_dob.Value) + "'), Gender= (SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_gender.Text) + "')WHERE Id = '" + Convert.ToInt32(txt_id.Text) + "';";


                        SqlCommand cmd = new SqlCommand(p, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Congrats! Data Update Successfully");

                        con.Close();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private int val()
        {
            int flag = 0;
            if (string.IsNullOrEmpty(txtfname.Text))
            {

                errorProvider1.SetError(txtfname, MessageBox.Show("Please Enter Your First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txtfname.Focus();
                flag = 1;
            }
            else if (string.IsNullOrWhiteSpace(txt_lname.Text))
            {

                errorProvider1.SetError(txt_lname, MessageBox.Show("Please Enter Your Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_lname.Focus();
                flag = 1;

            }
            else if (string.IsNullOrWhiteSpace(txt_email.Text))
            {



                errorProvider1.SetError(txt_email, MessageBox.Show("Please Enter Your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_email.Focus();
                flag = 1;
            }
            else if (string.IsNullOrWhiteSpace(txt_contact.Text))
            {

                errorProvider1.SetError(txt_contact, MessageBox.Show("Please Enter Your Contact ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_lname.Focus();
                flag = 1;

            }
            return flag;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
