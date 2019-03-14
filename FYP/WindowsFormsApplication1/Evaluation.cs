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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
