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
            this.components = new System.ComponentModel.Container();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_evaluate
            // 
            this.btn_evaluate.Font = new System.Drawing.Font("Garamond", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_evaluate.Location = new System.Drawing.Point(643, 369);
            this.btn_evaluate.Name = "btn_evaluate";
            this.btn_evaluate.Size = new System.Drawing.Size(132, 32);
            this.btn_evaluate.TabIndex = 15;
            this.btn_evaluate.Text = "Evaluate ";
            this.btn_evaluate.UseVisualStyleBackColor = true;
            this.btn_evaluate.Click += new System.EventHandler(this.btn_evaluate_Click);
            // 
            // txt_name
            // 
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(464, 161);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(173, 31);
            this.txt_name.TabIndex = 14;
            // 
            // txt_mark
            // 
            this.txt_mark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mark.Location = new System.Drawing.Point(464, 232);
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(173, 31);
            this.txt_mark.TabIndex = 13;
            // 
            // txt_totwet
            // 
            this.txt_totwet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_totwet.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totwet.Location = new System.Drawing.Point(464, 295);
            this.txt_totwet.Name = "txt_totwet";
            this.txt_totwet.Size = new System.Drawing.Size(173, 31);
            this.txt_totwet.TabIndex = 12;
            // 
            // lbl_totwei
            // 
            this.lbl_totwei.AutoSize = true;
            this.lbl_totwei.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totwei.Location = new System.Drawing.Point(252, 292);
            this.lbl_totwei.Name = "lbl_totwei";
            this.lbl_totwei.Size = new System.Drawing.Size(167, 24);
            this.lbl_totwei.TabIndex = 11;
            this.lbl_totwei.Text = "Total Weight Age";
            // 
            // lbl_totmar
            // 
            this.lbl_totmar.AutoSize = true;
            this.lbl_totmar.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totmar.Location = new System.Drawing.Point(252, 229);
            this.lbl_totmar.Name = "lbl_totmar";
            this.lbl_totmar.Size = new System.Drawing.Size(118, 24);
            this.lbl_totmar.TabIndex = 10;
            this.lbl_totmar.Text = "Total Marks";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(252, 158);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 24);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name";
            // 
            // lbl_eval_id
            // 
            this.lbl_eval_id.AutoSize = true;
            this.lbl_eval_id.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_eval_id.Location = new System.Drawing.Point(252, 86);
            this.lbl_eval_id.Name = "lbl_eval_id";
            this.lbl_eval_id.Size = new System.Drawing.Size(39, 24);
            this.lbl_eval_id.TabIndex = 30;
            this.lbl_eval_id.Text = " ID";
            // 
            // txt_eval_id
            // 
            this.txt_eval_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_eval_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eval_id.Location = new System.Drawing.Point(464, 89);
            this.txt_eval_id.Name = "txt_eval_id";
            this.txt_eval_id.Size = new System.Drawing.Size(173, 31);
            this.txt_eval_id.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Edit Evaluation";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.48617F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.83544F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.65823F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.78989F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_totwei, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_eval_id, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_totmar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_name, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_evaluate, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_eval_id, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_totwet, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_mark, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_name, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-86, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.50197F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.37202F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.13126F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.44591F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.77274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.77609F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 443);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // EditEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "EditEvaluation";
            this.Text = "EditEvaluation";
            this.Load += new System.EventHandler(this.EditEvaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}