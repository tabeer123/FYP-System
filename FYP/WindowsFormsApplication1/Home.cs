using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllStudentInfo std = new AllStudentInfo();
            this.Hide();
            std.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AllProject std = new AllProject();
            this.Hide();
            std.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            All_Advisor std = new All_Advisor();
            this.Hide();
            std.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            GroupEvaluation std = new GroupEvaluation();
            this.Hide();
            std.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AllGroupEvaluations std = new AllGroupEvaluations();
            this.Hide();
            std.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProjectAdvisor std = new ProjectAdvisor();
            this.Hide();
            std.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            GroupProject std = new GroupProject();
            this.Hide();
            std.Show();
        }
    }
}
