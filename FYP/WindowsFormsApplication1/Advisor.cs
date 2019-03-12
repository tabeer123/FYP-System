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
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string p = "INSERT INTO Advisor(Id, Designation, Salary)VALUES('" + (txt_adv_id.Text).ToString() + "',(SELECT Id FROM Lookup WHERE Lookup.Value = '" + (com_desig.Text) + "'), '"+(txt_adv_sal.Text).ToString() +"');";


                SqlCommand cmd = new SqlCommand(p, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");
            }
            // Student std = new Student();
            //this.Hide();
            //    std.Show();
        }
    }
}
