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
    public partial class GroupProject : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public GroupProject()
        {
            InitializeComponent();
            projectid();
            groupid();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void GroupProject_Load(object sender, EventArgs e)
        {
            

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    String q = "INSERT INTO [ProjectA].[dbo].[GroupProject](ProjectId,GroupId,AssignmentDate)VALUES(('" + Convert.ToInt32(com_prolid.Text) + "'),(select Id from [Group] where [Group].Id = '" + com_gro_id.Text + "'),('" + Convert.ToDateTime(dtp_assign_date.Value) + "'));";
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");

                }
                AllProjectGroups std = new AllProjectGroups();
                this.Hide();
                std.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void groupid()
        {
            com_gro_id.Items.Clear();
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string q = "Select Id FROM [Group]";
                SqlCommand cmd = new SqlCommand(q, con);

                try
                {

                    SqlDataReader myread = cmd.ExecuteReader();
                    while (myread.Read())
                    {
                        string id = myread["Id"].ToString();
                        com_gro_id.Items.Add(id);

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
        public void projectid()
        {
            com_prolid.Items.Clear();
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
                        com_prolid.Items.Add(id);

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

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home std = new Home();
            this.Hide();
            std.Show();
        }
    }
}
