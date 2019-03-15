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
   
    public partial class All_Advisor : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public All_Advisor()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                if(e.ColumnIndex == 0)
                {
                    EditAdvisor edit = new EditAdvisor();
                    edit.txt_adv_id.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    edit.com_desig.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    edit.txt_adv_sal.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    edit.ShowDialog();
                }
               else if(e.ColumnIndex == 1)
                {
                    DeleteAdvisor edit = new DeleteAdvisor();
                    edit.txt_adv_id.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    edit.ShowDialog();



                }
                All_Advisor std = new All_Advisor();
                this.Hide();
                std.Show();
            }

           
           

        }

        private void All_Advisor_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from Advisor", con);
                DataTable datatab = new DataTable();
                sda.Fill(datatab);
                dataGridView1.DataSource = datatab;
                
            }

        }

        private void btn_add_adv_Click(object sender, EventArgs e)
        {
            Advisor std = new Advisor();
            this.Hide();
            std.Show();

        }
    }
}
