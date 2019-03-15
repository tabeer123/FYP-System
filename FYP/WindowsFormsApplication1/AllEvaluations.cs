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
    public partial class AllEvaluations : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public AllEvaluations()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 0)
                {
                    EditEvaluation edit = new EditEvaluation();
                    edit.txt_eval_id.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();

                    edit.txt_name.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    edit.txt_mark.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    edit.txt_totwet.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();

                    edit.ShowDialog();
                }
                else if (e.ColumnIndex == 1)
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    string q = "DELETE FROM Evaluation where Id = '" + row.Cells[2].Value + "';";

                    SqlCommand cm = new SqlCommand(q, con);
                    cm.ExecuteNonQuery();

                    MessageBox.Show("Congrats! Record Deletded");
                    SqlDataAdapter sql = new SqlDataAdapter("SELECT * from Evaluation;", con);
                    DataTable datatab = new DataTable();
                    sql.Fill(datatab);
                    dataGridView1.DataSource = datatab;
                    con.Close();

                }
                AllEvaluations std = new AllEvaluations();
                this.Hide();
                std.Show();
            }

        }

        private void AllEvaluations_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from Evaluation;", con);
                DataTable datatab = new DataTable();
                sda.Fill(datatab);
                dataGridView1.DataSource = datatab;

                
            }
          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_adv_Click(object sender, EventArgs e)
        {
           Evaluation std = new Evaluation();
            this.Hide();
            std.Show();
        }
    }
}
