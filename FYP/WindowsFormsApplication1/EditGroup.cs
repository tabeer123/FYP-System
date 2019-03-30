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
    public partial class EditGroup : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public EditGroup()
        {
            InitializeComponent();

        }
        GroupStudent aadv = null;
        long advnum = 0;
        public EditGroup(GroupStudent std, long id)
        {
            InitializeComponent();
            this.aadv = std;
            this.advnum = id;
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_evaluate_Click(object sender, EventArgs e)
        {

            try
            {
                if (val() == 0)
                {
                    GroupStudent std = new GroupStudent();

                    
                    int key = Convert.ToInt32(txt_groupid.Text);

                    SqlConnection con = new SqlConnection(conStr);
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                     
                       string p = "UPDATE [ProjectA].[dbo].[GroupStudent] SET Status= (SELECT Id FROM [ProjectA].[dbo].[Lookup] WHERE [ProjectA].[dbo].[Lookup].Value = '" + (com_sta.Text) + "'),AssignmentDate =('" + Convert.ToDateTime(dtp_assign.Value) + "')WHERE GroupId ='" + Convert.ToInt32(txt_groupid.Text) + "';";

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
            if (string.IsNullOrEmpty(com_sta.Text))
            {


                errorProvider1.SetError(com_sta, MessageBox.Show("Please Select Group STATUS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                com_sta.Focus();
                t = 1;


            }
            else if (string.IsNullOrEmpty(dtp_assign.Text))
            {

                errorProvider1.SetError(dtp_assign, MessageBox.Show("Please Make sure you ENTER DATE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error).ToString());
                dtp_assign.Focus();
                t = 1;


            }
           
            return t;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
