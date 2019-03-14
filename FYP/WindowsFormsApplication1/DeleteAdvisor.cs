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
    public partial class DeleteAdvisor : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public DeleteAdvisor()
        {
            InitializeComponent();
        }
        All_Advisor aadv = null;
        long advnum = 0;
        public DeleteAdvisor(All_Advisor advdel, long Id)
        {
            InitializeComponent();
            this.aadv = advdel;
            this.advnum = Id;
        }

        private void DeleteAdvisor_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_adv_Click(object sender, EventArgs e)
        {
            try
            {
                int key = Convert.ToInt32(txt_adv_id.Text);
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    // string p = "DELETE Advisor, ProjectAdvisor from Advisor INNER JOIN ProjectAdvisor where Advisor.Id = ProjectAdvisor.AdvisorId and Advisor.Id ='" + Convert.ToInt32(txt_adv_id.Text) + "';";
                    string q = "DELETE FROM ProjectAdvisor WHERE ProjectAdvisor.AdvisorId ='" + Convert.ToInt32(txt_adv_id.Text) + "';";

                    string p = "DELETE FROM Advisor WHERE Advisor.Id ='" + Convert.ToInt32(txt_adv_id.Text) + "';";
                   
                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.ExecuteNonQuery();
                    SqlCommand c = new SqlCommand(p, con);
                    c.ExecuteNonQuery();
                    MessageBox.Show("Congrats!Data Deleted Successfully");

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
}
