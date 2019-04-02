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
    public partial class ProjectAdvisor : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public ProjectAdvisor()
        {
            InitializeComponent();
            Projectid();
            Advisorid();
        }

        private void com_adv_id_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_pro_adv_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string q = "INSERT INTO ProjectAdvisor(AdvisorId,ProjectId, AdvisorRole,AssignmentDate)VALUES('" + com_adv_id.Text + "','" + com_pro_id.Text + "', (SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_adv_role.Text) + "') ,'" + Convert.ToDateTime(dtp_assign_date.Value) + "');";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

            }
        public void Projectid()
        {
            try
            {
                com_pro_id.Items.Clear();
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string q = "Select Id FROM Project";
                    SqlCommand cmd = new SqlCommand(q, con);

                    try
                    {

                        SqlDataReader myread = cmd.ExecuteReader();
                        while (myread.Read())
                        {
                            string id = myread["Id"].ToString();
                            com_pro_id.Items.Add(id);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                //Student std = new Student();
                //this.Hide();
                //std.Show();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Advisorid()
        {
            try
            {
                com_adv_id.Items.Clear();
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    string q = "Select Id FROM Advisor";
                    SqlCommand cmd = new SqlCommand(q, con);

                    try
                    {

                        SqlDataReader myread = cmd.ExecuteReader();
                        while (myread.Read())
                        {
                            string id = myread["Id"].ToString();
                            com_adv_id.Items.Add(id);

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                //Student std = new Student();
                //this.Hide();
                //std.Show();
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
