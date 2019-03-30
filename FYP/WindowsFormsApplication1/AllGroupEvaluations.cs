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
    public partial class AllGroupEvaluations : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public AllGroupEvaluations()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    EditGroupEvaluation edit = new EditGroupEvaluation();
                    edit.txt_grpid.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    edit.txt_evalid.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    edit.txt_obtainmark.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    edit.dtp_evaluation_date.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
                   // edit.txt_email.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

                    edit.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    string t = "DELETE FROM GroupEvaluation where GroupId = '" + row.Cells[2].Value + "' And EvaluationId = '"+ row.Cells[3].Value +"';";

                   
                    SqlCommand cmd = new SqlCommand(t, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Congrats! Record Recorded");
                    SqlDataAdapter sql = new SqlDataAdapter("SELECT * from GroupEvaluation", con);
                    DataTable datatab = new DataTable();
                    sql.Fill(datatab);
                    dataGridView1.DataSource = datatab;
                    con.Close();










                }
                AllGroupEvaluations std = new AllGroupEvaluations();
                this.Hide();
                std.Show();
            }
        }

        private void AllGroupEvaluations_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from GroupEvaluation;", con);
                DataTable datatab = new DataTable();
                sda.Fill(datatab);
                dataGridView1.DataSource = datatab;

            }

        }

        private void btn_add_adv_Click(object sender, EventArgs e)
        {
            GroupEvaluation std = new GroupEvaluation();
            this.Hide();
            std.Show();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}