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
    public partial class EditProject : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public EditProject()
        {
            InitializeComponent();
        }
        AllProject aadv = null;
        long advnum = 0;
        public EditProject(AllProject all, long id)
        {
            InitializeComponent();
            this.aadv = all;
            this.advnum = id;

        }

        private void btn_add_pro_Click(object sender, EventArgs e)
        {
            if (val() == 0)
            {
                try
                {
                    int key = Convert.ToInt32(txt_pro_id.Text);
                    SqlConnection con = new SqlConnection(conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        string p = "UPDATE Project SET Description=('" + txt_descrip.Text.ToString() + "'),Title =('" + txt_pro_title.Text.ToString() + "')WHERE Id = '" + Convert.ToInt32(txt_pro_id) + "';";


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

        private void EditProject_Load(object sender, EventArgs e)
        {

        }
        private int val()
        {
            int t = 0;
            if (string.IsNullOrEmpty(txt_pro_title.Text))
            {


                errorProvider1.SetError(txt_pro_title, MessageBox.Show("Please Enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_pro_title.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(txt_descrip.Text))
            {

                errorProvider1.SetError(txt_descrip, MessageBox.Show("Please Select  Total Marks", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_descrip.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(txt_pro_id.Text))
            {

                errorProvider1.SetError(txt_pro_id, MessageBox.Show("Please Enter Total Weightage", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_pro_id.Focus();
                t = 1;


            }
            return t;
        }

    }
}
