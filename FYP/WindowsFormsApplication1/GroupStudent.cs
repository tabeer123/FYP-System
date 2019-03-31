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
    public partial class GroupStudent : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public GroupStudent()
        {
            InitializeComponent();
        }

        private void GroupStudent_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * from GroupStudent;", con);
                    DataTable datatab = new DataTable();
                    sda.Fill(datatab);
                    dataGridView1.DataSource = datatab;

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_add_adv_Click(object sender, EventArgs e)
        {
            Group std = new Group();
            this.Hide();
            std.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    EditGroup edit = new EditGroup();
                    edit.txt_groupid.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    edit.com_sta.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    edit.dtp_assign.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                   
                    edit.ShowDialog();

                }
                else if (e.ColumnIndex == 1)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    string t = "DELETE FROM GroupStudent where GroupId = '" + row.Cells[2].Value + "';";
                    string h = "DELETE FROM [ProjectA].[dbo].[Group] where Id = '" + row.Cells[2].Value + "';";


                    SqlCommand cmt = new SqlCommand(t, con);
                    cmt.ExecuteNonQuery();
                    SqlCommand cmtt = new SqlCommand(h, con);
                    cmtt.ExecuteNonQuery();

                    MessageBox.Show("Congrats! Record Recorded");
                    SqlDataAdapter sql = new SqlDataAdapter("SELECT * from GroupStudent;", con);
                    DataTable datatab = new DataTable();
                    sql.Fill(datatab);
                    dataGridView1.DataSource = datatab;
                    con.Close();






                }
               GroupStudent std = new GroupStudent();
                this.Hide();
                std.Show();
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
