namespace WindowsFormsApplication1
{
    partial class Student
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
            this.btn_addstd = new System.Windows.Forms.Button();
            this.txt_regno = new System.Windows.Forms.TextBox();
            this.lbl_regno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_sal = new System.Windows.Forms.Label();
            this.txt_adv_sal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_adv_id = new System.Windows.Forms.TextBox();
            this.com_desig = new System.Windows.Forms.ComboBox();
            this.lbl_desig = new System.Windows.Forms.Label();
            this.btn_add_adv = new System.Windows.Forms.Button();
            this.lbl_adv_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addstd
            // 
            this.btn_addstd.Location = new System.Drawing.Point(163, 198);
            this.btn_addstd.Name = "btn_addstd";
            this.btn_addstd.Size = new System.Drawing.Size(109, 23);
            this.btn_addstd.TabIndex = 0;
            this.btn_addstd.Text = "Student Added";
            this.btn_addstd.UseVisualStyleBackColor = true;
            this.btn_addstd.Click += new System.EventHandler(this.btn_addstd_Click);
            // 
            // txt_regno
            // 
            this.txt_regno.Location = new System.Drawing.Point(138, 113);
            this.txt_regno.Name = "txt_regno";
            this.txt_regno.Size = new System.Drawing.Size(100, 20);
            this.txt_regno.TabIndex = 3;
            // 
            // lbl_regno
            // 
            this.lbl_regno.AutoSize = true;
            this.lbl_regno.Location = new System.Drawing.Point(12, 116);
            this.lbl_regno.Name = "lbl_regno";
            this.lbl_regno.Size = new System.Drawing.Size(103, 13);
            this.lbl_regno.TabIndex = 4;
            this.lbl_regno.Text = "Registration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Insert Student ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.51146F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.59686F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.35079F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.48868F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_sal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_adv_sal, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_adv_id, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.com_desig, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_desig, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_add_adv, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_adv_id, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-199, -10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.37799F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.26794F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.02871F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.35407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66611F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66944F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(955, 433);
            this.tableLayoutPanel1.TabIndex = 39;
            // 
            // lbl_sal
            // 
            this.lbl_sal.AutoSize = true;
            this.lbl_sal.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sal.Location = new System.Drawing.Point(275, 223);
            this.lbl_sal.Name = "lbl_sal";
            this.lbl_sal.Size = new System.Drawing.Size(62, 24);
            this.lbl_sal.TabIndex = 9;
            this.lbl_sal.Text = "Salary";
            // 
            // txt_adv_sal
            // 
            this.txt_adv_sal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adv_sal.Location = new System.Drawing.Point(529, 226);
            this.txt_adv_sal.Name = "txt_adv_sal";
            this.txt_adv_sal.Size = new System.Drawing.Size(217, 31);
            this.txt_adv_sal.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Garamond", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_adv_id
            // 
            this.txt_adv_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_adv_id.Location = new System.Drawing.Point(529, 87);
            this.txt_adv_id.Name = "txt_adv_id";
            this.txt_adv_id.Size = new System.Drawing.Size(217, 31);
            this.txt_adv_id.TabIndex = 6;
            // 
            // com_desig
            // 
            this.com_desig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_desig.FormattingEnabled = true;
            this.com_desig.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Lecturer",
            "Industry Professional"});
            this.com_desig.Location = new System.Drawing.Point(529, 157);
            this.com_desig.Name = "com_desig";
            this.com_desig.Size = new System.Drawing.Size(217, 33);
            this.com_desig.TabIndex = 18;
            // 
            // lbl_desig
            // 
            this.lbl_desig.AutoSize = true;
            this.lbl_desig.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desig.Location = new System.Drawing.Point(275, 154);
            this.lbl_desig.Name = "lbl_desig";
            this.lbl_desig.Size = new System.Drawing.Size(120, 24);
            this.lbl_desig.TabIndex = 11;
            this.lbl_desig.Text = "Designation";
            // 
            // btn_add_adv
            // 
            this.btn_add_adv.Font = new System.Drawing.Font("Garamond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_adv.Location = new System.Drawing.Point(752, 360);
            this.btn_add_adv.Name = "btn_add_adv";
            this.btn_add_adv.Size = new System.Drawing.Size(150, 42);
            this.btn_add_adv.TabIndex = 5;
            this.btn_add_adv.Text = "Advisor Added";
            this.btn_add_adv.UseVisualStyleBackColor = true;
            // 
            // lbl_adv_id
            // 
            this.lbl_adv_id.AutoSize = true;
            this.lbl_adv_id.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adv_id.Location = new System.Drawing.Point(275, 84);
            this.lbl_adv_id.Name = "lbl_adv_id";
            this.lbl_adv_id.Size = new System.Drawing.Size(108, 24);
            this.lbl_adv_id.TabIndex = 7;
            this.lbl_adv_id.Text = "Advisor ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 39);
            this.label1.TabIndex = 36;
            this.label1.Text = "Advisor Information";
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_regno);
            this.Controls.Add(this.txt_regno);
            this.Controls.Add(this.btn_addstd);
            this.Name = "Student";
            this.Text = "Student Added";
            this.Load += new System.EventHandler(this.Student_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addstd;
        private System.Windows.Forms.TextBox txt_regno;
        private System.Windows.Forms.Label lbl_regno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_sal;
        private System.Windows.Forms.TextBox txt_adv_sal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_adv_id;
        private System.Windows.Forms.ComboBox com_desig;
        private System.Windows.Forms.Label lbl_desig;
        private System.Windows.Forms.Button btn_add_adv;
        private System.Windows.Forms.Label lbl_adv_id;
        private System.Windows.Forms.Label label1;
    }
}