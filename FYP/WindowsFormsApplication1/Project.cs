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
    public partial class Project : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public Project()
        {
            InitializeComponent();
        }

        private void btn_add_pro_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string p = "INSERT INTO Project( Description, Title)VALUES( '" + (txt_descrip.Text).ToString() + "', '" + (txt_pro_title.Text).ToString() + "');";


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
