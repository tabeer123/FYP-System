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
            try
            {
               int key = Convert.ToInt32(txt_id.Text);
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string p = "UPDATE Person SET FirstName=('"+ txtfname.Text.ToString() + "'), LastName=('" + txt_lname.Text.ToString() + "'),Contact =('"+txt_contact.Text.ToString()+ "'),Email =('" + txt_email.Text.ToString() + "'),DateOfBirth=('" + Convert.ToDateTime(dtp_dob.Value) + "'), Gender= (SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_gender.Text) + "')WHERE Id = '"+Convert.ToInt32(txt_id.Text)  +"';";


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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
