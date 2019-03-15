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
            this.com_eval_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_evaluate
            // 
            this.btn_evaluate.Location = new System.Drawing.Point(244, 235);
            this.btn_evaluate.Name = "btn_evaluate";
            this.btn_evaluate.Size = new System.Drawing.Size(75, 23);
            this.btn_evaluate.TabIndex = 15;
            this.btn_evaluate.Text = "Evaluate ";
            this.btn_evaluate.UseVisualStyleBackColor = true;
            this.btn_evaluate.Click += new System.EventHandler(this.btn_evaluate_Click);
            // 
            // txt_obtainmark
            // 
            this.txt_obtainmark.Location = new System.Drawing.Point(204, 146);
            this.txt_obtainmark.Name = "txt_obtainmark";
            this.txt_obtainmark.Size = new System.Drawing.Size(100, 20);
            this.txt_obtainmark.TabIndex = 12;
            // 
            // lbl_obtmark
            // 
            this.lbl_obtmark.AutoSize = true;
            this.lbl_obtmark.Location = new System.Drawing.Point(50, 146);
            this.lbl_obtmark.Name = "lbl_obtmark";
            this.lbl_obtmark.Size = new System.Drawing.Size(82, 13);
            this.lbl_obtmark.TabIndex = 11;
            this.lbl_obtmark.Text = "Obtained Marks";
            // 
            // lbl_evalid
            // 
            this.lbl_evalid.AutoSize = true;
            this.lbl_evalid.Location = new System.Drawing.Point(50, 100);
            this.lbl_evalid.Name = "lbl_evalid";
            this.lbl_evalid.Size = new System.Drawing.Size(71, 13);
            this.lbl_evalid.TabIndex = 10;
            this.lbl_evalid.Text = "Evaluation ID";
            // 
            // lbl_groid
            // 
            this.lbl_groid.AutoSize = true;
            this.lbl_groid.Location = new System.Drawing.Point(50, 51);
            this.lbl_groid.Name = "lbl_groid";
            this.lbl_groid.Size = new System.Drawing.Size(50, 13);
            this.lbl_groid.TabIndex = 9;
            this.lbl_groid.Text = "Group ID";
            // 
            // lbl_evaldate
            // 
            this.lbl_evaldate.AutoSize = true;
            this.lbl_evaldate.Location = new System.Drawing.Point(50, 190);
            this.lbl_evaldate.Name = "lbl_evaldate";
            this.lbl_evaldate.Size = new System.Drawing.Size(83, 13);
            this.lbl_evaldate.TabIndex = 16;
            this.lbl_evaldate.Text = "Evaluation Date";
            // 
            // dtp_evaluation_date
            // 
            this.dtp_evaluation_date.Location = new System.Drawing.Point(156, 190);
            this.dtp_evaluation_date.Name = "dtp_evaluation_date";
            this.dtp_evaluation_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_evaluation_date.TabIndex = 30;
            // 
            // com_gro_id
            // 
            this.com_gro_id.FormattingEnabled = true;
            this.com_gro_id.Location = new System.Drawing.Point(204, 43);
            this.com_gro_id.Name = "com_gro_id";
            this.com_gro_id.Size = new System.Drawing.Size(100, 21);
            this.com_gro_id.TabIndex = 32;
            // 
            // com_eval_id
            // 
            this.com_eval_id.FormattingEnabled = true;
            this.com_eval_id.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Lecturer",
            "Industry Professional"});
            this.com_eval_id.Location = new System.Drawing.Point(204, 93);
            this.com_eval_id.Name = "com_eval_id";
            this.com_eval_id.Size = new System.Drawing.Size(100, 21);
            this.com_eval_id.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Group Evaluation";
            // 
            // GroupEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.com_gro_id);
            this.Controls.Add(this.com_eval_id);
            this.Controls.Add(this.dtp_evaluation_date);
            this.Controls.Add(this.lbl_evaldate);
            this.Controls.Add(this.btn_evaluate);
            this.Controls.Add(this.txt_obtainmark);
            this.Controls.Add(this.lbl_obtmark);
            this.Controls.Add(this.lbl_evalid);
            this.Controls.Add(this.lbl_groid);
            this.Name = "GroupEvaluation";
            this.Text = "GroupEvaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox com_eval_id;
        private System.Windows.Forms.Label label2;
    }
}