namespace WindowsFormsApplication1
{
    partial class EditEvaluation
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_mark = new System.Windows.Forms.TextBox();
            this.txt_totwet = new System.Windows.Forms.TextBox();
            this.lbl_totwei = new System.Windows.Forms.Label();
            this.lbl_totmar = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_eval_id = new System.Windows.Forms.Label();
            this.txt_eval_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_evaluate
            // 
            this.btn_evaluate.Location = new System.Drawing.Point(256, 235);
            this.btn_evaluate.Name = "btn_evaluate";
            this.btn_evaluate.Size = new System.Drawing.Size(75, 23);
            this.btn_evaluate.TabIndex = 15;
            this.btn_evaluate.Text = "Evaluate ";
            this.btn_evaluate.UseVisualStyleBackColor = true;
            this.btn_evaluate.Click += new System.EventHandler(this.btn_evaluate_Click);
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(216, 51);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 14;
            // 
            // txt_mark
            // 
            this.txt_mark.Location = new System.Drawing.Point(216, 100);
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(100, 20);
            this.txt_mark.TabIndex = 13;
            // 
            // txt_totwet
            // 
            this.txt_totwet.Location = new System.Drawing.Point(216, 146);
            this.txt_totwet.Name = "txt_totwet";
            this.txt_totwet.Size = new System.Drawing.Size(100, 20);
            this.txt_totwet.TabIndex = 12;
            // 
            // lbl_totwei
            // 
            this.lbl_totwei.AutoSize = true;
            this.lbl_totwei.Location = new System.Drawing.Point(62, 146);
            this.lbl_totwei.Name = "lbl_totwei";
            this.lbl_totwei.Size = new System.Drawing.Size(90, 13);
            this.lbl_totwei.TabIndex = 11;
            this.lbl_totwei.Text = "Total Weight Age";
            // 
            // lbl_totmar
            // 
            this.lbl_totmar.AutoSize = true;
            this.lbl_totmar.Location = new System.Drawing.Point(62, 100);
            this.lbl_totmar.Name = "lbl_totmar";
            this.lbl_totmar.Size = new System.Drawing.Size(63, 13);
            this.lbl_totmar.TabIndex = 10;
            this.lbl_totmar.Text = "Total Marks";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(62, 51);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name";
            // 
            // lbl_eval_id
            // 
            this.lbl_eval_id.AutoSize = true;
            this.lbl_eval_id.Location = new System.Drawing.Point(62, 12);
            this.lbl_eval_id.Name = "lbl_eval_id";
            this.lbl_eval_id.Size = new System.Drawing.Size(21, 13);
            this.lbl_eval_id.TabIndex = 30;
            this.lbl_eval_id.Text = " ID";
            // 
            // txt_eval_id
            // 
            this.txt_eval_id.Location = new System.Drawing.Point(216, 12);
            this.txt_eval_id.Name = "txt_eval_id";
            this.txt_eval_id.Size = new System.Drawing.Size(100, 20);
            this.txt_eval_id.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Edit Evaluation";
            // 
            // EditEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_eval_id);
            this.Controls.Add(this.txt_eval_id);
            this.Controls.Add(this.btn_evaluate);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_mark);
            this.Controls.Add(this.txt_totwet);
            this.Controls.Add(this.lbl_totwei);
            this.Controls.Add(this.lbl_totmar);
            this.Controls.Add(this.lbl_name);
            this.Name = "EditEvaluation";
            this.Text = "EditEvaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_evaluate;
        public System.Windows.Forms.TextBox txt_name;
        public System.Windows.Forms.TextBox txt_mark;
        public System.Windows.Forms.TextBox txt_totwet;
        private System.Windows.Forms.Label lbl_totwei;
        private System.Windows.Forms.Label lbl_totmar;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_eval_id;
        public System.Windows.Forms.TextBox txt_eval_id;
        private System.Windows.Forms.Label label2;
    }
}