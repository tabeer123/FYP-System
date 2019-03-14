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
    public partial class EditAdvisor : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public EditAdvisor()

        {

            InitializeComponent();
        }
        All_Advisor aadv = null;
        long advnum = 0;
        public EditAdvisor(All_Advisor adv, long Id)
        {
            InitializeComponent();
            this.aadv = adv;
            this.advnum = Id;

        }

        private void EditAdvisor_Load(object sender, EventArgs e)
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
                    string p = "UPDATE Advisor SET Designation= (SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_desig.Text) + "'), Salary =('" + Convert.ToDecimal(txt_adv_sal.Text) + "')WHERE Id ='" + Convert.ToInt32(txt_adv_id.Text) + "';";


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
}
