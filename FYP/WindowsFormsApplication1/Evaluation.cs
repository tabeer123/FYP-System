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
    public partial class Evaluation : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public Evaluation()
        {
            InitializeComponent();
        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {
            if (val() == 0)
            {
                try
                {

              
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string q = "INSERT INTO Evaluation(Name, TotalMarks,TotalWeightage)VALUES('" +  (txt_name.Text).ToString() + "', '" + Convert.ToInt32(txt_mark.Text) + "' ,'" + Convert.ToInt32(txt_totwet.Text) + "');";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");

            }
            AllEvaluations std = new AllEvaluations();
            this.Hide();
            std.Show();

        }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                  }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Evaluation_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Home std = new Home();
            this.Hide();
            std.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
