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
    public partial class Group : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";


        public Group()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                string q = "INSERT INTO [Group](Created_On)VALUES('"+ Convert.ToDateTime(dtp_create.Value) + "');";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Successfully");

            }

        }
    }
}
