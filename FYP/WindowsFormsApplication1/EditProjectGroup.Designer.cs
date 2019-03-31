namespace WindowsFormsApplication1
{
    partial class EditProjectGroup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_groid = new System.Windows.Forms.Label();
            this.lbl_evalid = new System.Windows.Forms.Label();
            this.txt_evalid = new System.Windows.Forms.TextBox();
            this.txt_grpid = new System.Windows.Forms.TextBox();
            this.lbl_evaldate = new System.Windows.Forms.Label();
            this.dtp_evaluation_date = new System.Windows.Forms.DateTimePicker();
            this.btn_evaluate = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.79902F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.27451F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70588F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97549F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(5, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(816, 82);
            this.tableLayoutPanel2.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Edit Group Project";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.9177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.31045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.63646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.13539F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_groid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_evalid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_evalid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_grpid, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_evaldate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dtp_evaluation_date, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_evaluate, 3, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 109);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 340);
            this.tableLayoutPanel1.TabIndex = 42;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Garamond", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_groid
            // 
            this.lbl_groid.AutoSize = true;
            this.lbl_groid.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_groid.Location = new System.Drawing.Point(198, 0);
            this.lbl_groid.Name = "lbl_groid";
            this.lbl_groid.Size = new System.Drawing.Size(96, 24);
            this.lbl_groid.TabIndex = 9;
            this.lbl_groid.Text = "Group ID";
            // 
            // lbl_evalid
            // 
            this.lbl_evalid.AutoSize = true;
            this.lbl_evalid.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evalid.Location = new System.Drawing.Point(198, 48);
            this.lbl_evalid.Name = "lbl_evalid";
            this.lbl_evalid.Size = new System.Drawing.Size(102, 24);
            this.lbl_evalid.TabIndex = 10;
            this.lbl_evalid.Text = "Project ID";
            // 
            // txt_evalid
            // 
            this.txt_evalid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_evalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_evalid.Location = new System.Drawing.Point(446, 51);
            this.txt_evalid.Name = "txt_evalid";
            this.txt_evalid.Size = new System.Drawing.Size(212, 31);
            this.txt_evalid.TabIndex = 33;
            // 
            // txt_grpid
            // 
            this.txt_grpid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_grpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grpid.Location = new System.Drawing.Point(446, 3);
            this.txt_grpid.Name = "txt_grpid";
            this.txt_grpid.Size = new System.Drawing.Size(212, 31);
            this.txt_grpid.TabIndex = 34;
            // 
            // lbl_evaldate
            // 
            this.lbl_evaldate.AutoSize = true;
            this.lbl_evaldate.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evaldate.Location = new System.Drawing.Point(198, 96);
            this.lbl_evaldate.Name = "lbl_evaldate";
            this.lbl_evaldate.Size = new System.Drawing.Size(165, 24);
            this.lbl_evaldate.TabIndex = 16;
            this.lbl_evaldate.Text = "Assignment Date";
            // 
            // dtp_evaluation_date
            // 
            this.dtp_evaluation_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_evaluation_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_evaluation_date.Location = new System.Drawing.Point(446, 99);
            this.dtp_evaluation_date.Name = "dtp_evaluation_date";
            this.dtp_evaluation_date.Size = new System.Drawing.Size(212, 31);
            this.dtp_evaluation_date.TabIndex = 30;
            // 
            // btn_evaluate
            // 
            this.btn_evaluate.Font = new System.Drawing.Font("Garamond", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_evaluate.Location = new System.Drawing.Point(664, 291);
            this.btn_evaluate.Name = "btn_evaluate";
            this.btn_evaluate.Size = new System.Drawing.Size(144, 46);
            this.btn_evaluate.TabIndex = 15;
            this.btn_evaluate.Text = "Edit Group Project";
            this.btn_evaluate.UseVisualStyleBackColor = true;
            this.btn_evaluate.Click += new System.EventHandler(this.btn_evaluate_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditProjectGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 472);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditProjectGroup";
            this.Text = "EditProjectGroup";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_evaluate;
        private System.Windows.Forms.Label lbl_groid;
        private System.Windows.Forms.Label lbl_evalid;
        public System.Windows.Forms.TextBox txt_evalid;
        public System.Windows.Forms.TextBox txt_grpid;
        private System.Windows.Forms.Label lbl_evaldate;
        public System.Windows.Forms.DateTimePicker dtp_evaluation_date;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}