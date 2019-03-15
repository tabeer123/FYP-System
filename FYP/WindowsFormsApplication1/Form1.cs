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
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // errorProvider1.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_dob_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void btn_addstd_Click(object sender, EventArgs e)
        {
            //if (txtfname.Text == " " || txt_lname.Text == " " || txt_email.Text == " " || txt_contact.Text) {

            if (val() == 0)
            {

                {
                    try
                    {
                        SqlConnection con = new SqlConnection(conStr);
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            string q = "INSERT INTO Person( FirstName, LastName, Contact, Email, DateOfBirth, Gender)VALUES( '" + txtfname.Text.ToString() + "', '" + txt_lname.Text.ToString() + "', '" + txt_contact.Text.ToString() + "','" + txt_email.Text.ToString() + "','" + Convert.ToDateTime(dtp_dob.Value) + "',(SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_gender.Text) + "'));";
                            SqlCommand cmd = new SqlCommand(q, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data Inserted Successfully");

                        }
                        Student std = new Student();
                        this.Hide();
                        std.Show();
                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }
        }
            

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int val()
        {
            int flag = 0;
            if (string.IsNullOrEmpty(txtfname.Text) )
            {
                
                errorProvider1.SetError(txtfname, MessageBox.Show("Please Enter Your First Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txtfname.Focus();
                flag = 1;
            }
            else if (string.IsNullOrWhiteSpace(txt_lname.Text ))
            {
                
                errorProvider1.SetError(txt_lname, MessageBox.Show("Please Enter Your Last Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_lname.Focus();
                flag = 1;

            }
            else if (string.IsNullOrWhiteSpace(txt_email.Text ))
            {



               errorProvider1.SetError(txt_email, MessageBox.Show("Please Enter Your Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_email.Focus();
                flag = 1;
            }
            else if (string.IsNullOrWhiteSpace(txt_contact.Text ))
            {
                
                errorProvider1.SetError(txt_contact, MessageBox.Show("Please Enter Your Contact ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_lname.Focus();
                flag = 1;

            }
            return flag;
        }

        private void txt_lname_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt_contact_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
        }

        private void com_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home std = new Home();
            this.Hide();
            std.Show();
        }
    }
}
