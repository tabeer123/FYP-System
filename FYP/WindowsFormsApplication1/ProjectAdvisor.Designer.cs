namespace WindowsFormsApplication1
{
    partial class ProjectAdvisor
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
            this.com_pro_id = new System.Windows.Forms.ComboBox();
            this.lbl_pro_id = new System.Windows.Forms.Label();
            this.lbl_adv_role = new System.Windows.Forms.Label();
            this.lbl_adv_id = new System.Windows.Forms.Label();
            this.btn_add_pro_adv = new System.Windows.Forms.Button();
            this.com_adv_id = new System.Windows.Forms.ComboBox();
            this.com_adv_role = new System.Windows.Forms.ComboBox();
            this.dtp_assign_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_assign_date = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_pro_id
            // 
            this.com_pro_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.com_pro_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_pro_id.FormattingEnabled = true;
            this.com_pro_id.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Lecturer",
            "Industry Professional"});
            this.com_pro_id.Location = new System.Drawing.Point(463, 160);
            this.com_pro_id.Name = "com_pro_id";
            this.com_pro_id.Size = new System.Drawing.Size(169, 33);
            this.com_pro_id.TabIndex = 25;
            // 
            // lbl_pro_id
            // 
            this.lbl_pro_id.AutoSize = true;
            this.lbl_pro_id.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pro_id.Location = new System.Drawing.Point(198, 157);
            this.lbl_pro_id.Name = "lbl_pro_id";
            this.lbl_pro_id.Size = new System.Drawing.Size(102, 24);
            this.lbl_pro_id.TabIndex = 24;
            this.lbl_pro_id.Text = "Project ID";
            // 
            // lbl_adv_role
            // 
            this.lbl_adv_role.AutoSize = true;
            this.lbl_adv_role.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adv_role.Location = new System.Drawing.Point(198, 210);
            this.lbl_adv_role.Name = "lbl_adv_role";
            this.lbl_adv_role.Size = new System.Drawing.Size(125, 24);
            this.lbl_adv_role.TabIndex = 23;
            this.lbl_adv_role.Text = "Advisor Role";
            // 
            // lbl_adv_id
            // 
            this.lbl_adv_id.AutoSize = true;
            this.lbl_adv_id.Font = new System.Drawing.Font("Garamond", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_adv_id.Location = new System.Drawing.Point(198, 104);
            this.lbl_adv_id.Name = "lbl_adv_id";
            this.lbl_adv_id.Size = new System.Drawing.Size(100, 21);
            this.lbl_adv_id.TabIndex = 21;
            this.lbl_adv_id.Text = "Advisor ID";
            // 
            // btn_add_pro_adv
            // 
            this.btn_add_pro_adv.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_pro_adv.Location = new System.Drawing.Point(638, 319);
            this.btn_add_pro_adv.Name = "btn_add_pro_adv";
            this.btn_add_pro_adv.Size = new System.Drawing.Size(170, 32);
            this.btn_add_pro_adv.TabIndex = 19;
            this.btn_add_pro_adv.Text = "Project Advisor Added";
            this.btn_add_pro_adv.UseVisualStyleBackColor = true;
            this.btn_add_pro_adv.Click += new System.EventHandler(this.btn_add_pro_adv_Click);
            // 
            // com_adv_id
            // 
            this.com_adv_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.com_adv_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.com_adv_id.FormattingEnabled = true;
            this.com_adv_id.Location = new System.Drawing.Point(463, 107);
            this.com_adv_id.Name = "com_adv_id";
            this.com_adv_id.Size = new System.Drawing.Size(169, 33);
            this.com_adv_id.TabIndex = 26;
            this.com_adv_id.SelectedIndexChanged += new System.EventHandler(this.com_adv_id_SelectedIndexChanged);
            // 
            // com_adv_role
            // 
            this.com_adv_role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.com_adv_role.FormattingEnabled = true;
            this.com_adv_role.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisror",
            "Industry Advisor"});
            this.com_adv_role.Location = new System.Drawing.Point(463, 213);
            this.com_adv_role.Name = "com_adv_role";
            this.com_adv_role.Size = new System.Drawing.Size(169, 21);
            this.com_adv_role.TabIndex = 27;
            // 
            // dtp_assign_date
            // 
            this.dtp_assign_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_assign_date.Location = new System.Drawing.Point(463, 266);
            this.dtp_assign_date.Name = "dtp_assign_date";
            this.dtp_assign_date.Size = new System.Drawing.Size(169, 31);
            this.dtp_assign_date.TabIndex = 29;
            // 
            // lbl_assign_date
            // 
            this.lbl_assign_date.AutoSize = true;
            this.lbl_assign_date.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_assign_date.Location = new System.Drawing.Point(198, 263);
            this.lbl_assign_date.Name = "lbl_assign_date";
            this.lbl_assign_date.Size = new System.Drawing.Size(165, 24);
            this.lbl_assign_date.TabIndex = 28;
            this.lbl_assign_date.Text = "Assignment Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Project Advisor Info";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.9177F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.47863F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.48962F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.34432F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtp_assign_date, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.com_adv_role, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_assign_date, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.com_pro_id, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.com_adv_id, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_adv_id, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_adv_role, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pro_id, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_add_pro_adv, 3, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-59, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.2938F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.738544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 371);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Garamond", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(198, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProjectAdvisor";
            this.Text = "ProjectAdvisor";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox com_pro_id;
        private System.Windows.Forms.Label lbl_pro_id;
        private System.Windows.Forms.Label lbl_adv_role;
        private System.Windows.Forms.Label lbl_adv_id;
        private System.Windows.Forms.Button btn_add_pro_adv;
        private System.Windows.Forms.ComboBox com_adv_id;
        private System.Windows.Forms.ComboBox com_adv_role;
        private System.Windows.Forms.DateTimePicker dtp_assign_date;
        private System.Windows.Forms.Label lbl_assign_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}