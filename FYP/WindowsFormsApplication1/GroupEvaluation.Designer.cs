namespace WindowsFormsApplication1
{
    partial class GroupEvaluation
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
            this.btn_evaluate = new System.Windows.Forms.Button();
            this.txt_obtainmark = new System.Windows.Forms.TextBox();
            this.lbl_obtmark = new System.Windows.Forms.Label();
            this.lbl_evalid = new System.Windows.Forms.Label();
            this.lbl_groid = new System.Windows.Forms.Label();
            this.lbl_evaldate = new System.Windows.Forms.Label();
            this.dtp_evaluation_date = new System.Windows.Forms.DateTimePicker();
            this.com_gro_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_evalid = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_evaluate
            // 
            this.btn_evaluate.Font = new System.Drawing.Font("Garamond", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_evaluate.Location = new System.Drawing.Point(664, 291);
            this.btn_evaluate.Name = "btn_evaluate";
            this.btn_evaluate.Size = new System.Drawing.Size(95, 32);
            this.btn_evaluate.TabIndex = 15;
            this.btn_evaluate.Text = "Evaluate ";
            this.btn_evaluate.UseVisualStyleBackColor = true;
            this.btn_evaluate.Click += new System.EventHandler(this.btn_evaluate_Click);
            // 
            // txt_obtainmark
            // 
            this.txt_obtainmark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_obtainmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_obtainmark.Location = new System.Drawing.Point(446, 99);
            this.txt_obtainmark.Name = "txt_obtainmark";
            this.txt_obtainmark.Size = new System.Drawing.Size(212, 31);
            this.txt_obtainmark.TabIndex = 12;
            // 
            // lbl_obtmark
            // 
            this.lbl_obtmark.AutoSize = true;
            this.lbl_obtmark.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_obtmark.Location = new System.Drawing.Point(198, 96);
            this.lbl_obtmark.Name = "lbl_obtmark";
            this.lbl_obtmark.Size = new System.Drawing.Size(157, 24);
            this.lbl_obtmark.TabIndex = 11;
            this.lbl_obtmark.Text = "Obtained Marks";
            // 
            // lbl_evalid
            // 
            this.lbl_evalid.AutoSize = true;
            this.lbl_evalid.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evalid.Location = new System.Drawing.Point(198, 48);
            this.lbl_evalid.Name = "lbl_evalid";
            this.lbl_evalid.Size = new System.Drawing.Size(137, 24);
            this.lbl_evalid.TabIndex = 10;
            this.lbl_evalid.Text = "Evaluation ID";
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
            // lbl_evaldate
            // 
            this.lbl_evaldate.AutoSize = true;
            this.lbl_evaldate.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_evaldate.Location = new System.Drawing.Point(198, 144);
            this.lbl_evaldate.Name = "lbl_evaldate";
            this.lbl_evaldate.Size = new System.Drawing.Size(156, 24);
            this.lbl_evaldate.TabIndex = 16;
            this.lbl_evaldate.Text = "Evaluation Date";
            // 
            // dtp_evaluation_date
            // 
            this.dtp_evaluation_date.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_evaluation_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_evaluation_date.Location = new System.Drawing.Point(446, 147);
            this.dtp_evaluation_date.Name = "dtp_evaluation_date";
            this.dtp_evaluation_date.Size = new System.Drawing.Size(212, 31);
            this.dtp_evaluation_date.TabIndex = 30;
            // 
            // com_gro_id
            // 
            this.com_gro_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.com_gro_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_gro_id.FormattingEnabled = true;
            this.com_gro_id.Location = new System.Drawing.Point(446, 3);
            this.com_gro_id.Name = "com_gro_id";
            this.com_gro_id.Size = new System.Drawing.Size(212, 33);
            this.com_gro_id.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Group Evaluation";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.9177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.31045F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.63646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.13539F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_evaldate, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.dtp_evaluation_date, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_evaluate, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.com_gro_id, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_obtainmark, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_groid, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_obtmark, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_evalid, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_evalid, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 116);
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
            this.tableLayoutPanel1.TabIndex = 38;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Garamond", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.79902F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.27451F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.70588F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.97549F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(816, 82);
            this.tableLayoutPanel2.TabIndex = 39;
            // 
            // GroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 472);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "GroupEvaluation";
            this.Text = "GroupEvaluation";
            this.Load += new System.EventHandler(this.GroupEvaluation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_evaluate;
        private System.Windows.Forms.TextBox txt_obtainmark;
        private System.Windows.Forms.Label lbl_obtmark;
        private System.Windows.Forms.Label lbl_evalid;
        private System.Windows.Forms.Label lbl_groid;
        private System.Windows.Forms.Label lbl_evaldate;
        private System.Windows.Forms.DateTimePicker dtp_evaluation_date;
        private System.Windows.Forms.ComboBox com_gro_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txt_evalid;
    }
}