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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class MarkSheetReport : Form
    {
        public string conStr = "Data Source=DESKTOP-DV4QKKA;Initial Catalog=ProjectA;Integrated Security=True";

        public MarkSheetReport()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MarkSheetReport_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);
                con.Open();
                if (con.State == ConnectionState.Open)
                {

                    SqlDataAdapter sda = new SqlDataAdapter("SELECT CONCAT(p.FirstName,' ' , p.LastName) as [Name], s.RegistrationNo, B.[Value] as [Status],  e.[Name] as Evaluation_Name,ge.ObtainedMarks, e.TotalMarks, e.TotalWeightage, pr.Title as Project_Title, pr.[Description] as Project_Description FROM Person as p JOIN Student as s ON p.Id = s.Id JOIN GroupStudent as gs ON s.Id = gs.StudentId JOIN GroupEvaluation as ge ON ge.GroupId = gs.GroupId JOIN Evaluation as  e ON ge.EvaluationId = e.Id JOIN GroupProject as gp ON gs.GroupId = gp.GroupId JOIN Project as pr ON gp.ProjectId=pr.Id LEFT JOIN Lookup AS B ON (B.Id = gs.Status  ) ", con);
                    DataTable datatab = new DataTable();
                    sda.Fill(datatab);
                    dataGridView1.DataSource = datatab;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //this.reportViewer1.RefreshReport();
        }

    
        public void exportgridtopdf(DataGridView d, string fname)
        {
            try
            {
                BaseFont f = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
                PdfPTable pdftab = new PdfPTable(d.Columns.Count);
                pdftab.DefaultCell.Padding = 3;
                pdftab.WidthPercentage = 100;
                pdftab.HorizontalAlignment = Element.ALIGN_LEFT;
                pdftab.DefaultCell.BorderWidth = 1;
                iTextSharp.text.Font text = new iTextSharp.text.Font(f, 10, iTextSharp.text.Font.NORMAL);

                //For Header of Report
                foreach (DataGridViewColumn col in d.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText, text));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdftab.AddCell(cell);
                }
                //Add ROW
                foreach (DataGridViewRow r in d.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        pdftab.AddCell(new Phrase(c.Value.ToString(), text));
                    }
                }
                var savefile = new SaveFileDialog();
                savefile.FileName = fname;
                savefile.DefaultExt = ".pdf";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();
                        pdfdoc.Add(pdftab);
                        pdfdoc.Close();
                        stream.Close();
                    }

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exportgridtopdf(dataGridView1, "MarksReport");
        }

        private void btn_editstd_Click_1(object sender, EventArgs e)
        {
            Home std = new Home();
            this.Hide();
            std.Show();

        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
