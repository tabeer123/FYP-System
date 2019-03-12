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
    public partial class Form1 : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if(con.State == ConnectionState.Open)
            {
                string q = "INSERT INTO Person( FirstName, LastName, Contact, Email, DateOfBirth, Gender)VALUES( '" + txtfname.Text.ToString() + "', '" + txt_lname.Text.ToString() + "', '" + txt_contact.Text.ToString() + "','" + txt_email.Text.ToString() + "','" +Convert.ToDateTime(dtp_dob.Value) + "',(SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_gender.Text) + "'));";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");

            }
            Student std = new Student();
            this.Hide();
                std.Show();
            

        }
    }
}
