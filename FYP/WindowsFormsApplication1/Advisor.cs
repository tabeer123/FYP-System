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
    public partial class Advisor : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";
        public Advisor()
        {
            InitializeComponent();
        }

        private void btn_add_adv_Click(object sender, EventArgs e)
        {
            if (val() == 0)
            {
                
                {
                    try
                    {



                        SqlConnection con = new SqlConnection(conStr);
                        con.Open();
                        if (con.State == ConnectionState.Open)
                        {
                            string p = "INSERT INTO Advisor(Id, Designation, Salary)VALUES('" + (txt_adv_id.Text).ToString() + "',(SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_desig.Text) + "'), '" + (txt_adv_sal.Text).ToString() + "');";


                            SqlCommand cmd = new SqlCommand(p, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data Inserted Successfully");
                        }


                        All_Advisor std = new All_Advisor();
                        this.Hide();
                        std.Show();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }
        }
        
            
                

        private void Advisor_Load(object sender, EventArgs e)
        {

        }

        private void txt_adv_id_TextChanged(object sender, EventArgs e)
        {

          
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
                
                errorProvider1.SetError(txt_adv_sal, MessageBox.Show("Please Enter Salary", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                txt_adv_sal.Focus();
                t = 1;


            }
            return t;
        }

        private void txt_adv_sal_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void com_desig_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Home std = new Home();
            this.Hide();
           std.Show();

        }

        //private void txt_adv_id_validating(object sender, CancelEventArgs e)
        //{
        //    if (string.IsNullOrEmpty(txt_adv_id.Text)){
        //        e.Cancel = true;
        //        txt_adv_id.Focus();
        //        errorProvider1.SetError(txt_adv_id, "error");

        //    }
        //    else
        //    {
        //        e.Cancel = true;
        //        errorProvider1.SetError(txt_adv_id, "");
        //    }

        //}

        //private void txt_adv_id_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
