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
            this.SuspendLayout();
            // 
            // com_pro_id
            // 
            this.com_pro_id.FormattingEnabled = true;
            this.com_pro_id.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Lecturer",
            "Industry Professional"});
            this.com_pro_id.Location = new System.Drawing.Point(292, 116);
            this.com_pro_id.Name = "com_pro_id";
            this.com_pro_id.Size = new System.Drawing.Size(100, 21);
            this.com_pro_id.TabIndex = 25;
            // 
            // lbl_pro_id
            // 
            this.lbl_pro_id.AutoSize = true;
            this.lbl_pro_id.Location = new System.Drawing.Point(149, 116);
            this.lbl_pro_id.Name = "lbl_pro_id";
            this.lbl_pro_id.Size = new System.Drawing.Size(54, 13);
            this.lbl_pro_id.TabIndex = 24;
            this.lbl_pro_id.Text = "Project ID";
            // 
            // lbl_adv_role
            // 
            this.lbl_adv_role.AutoSize = true;
            this.lbl_adv_role.Location = new System.Drawing.Point(149, 164);
            this.lbl_adv_role.Name = "lbl_adv_role";
            this.lbl_adv_role.Size = new System.Drawing.Size(67, 13);
            this.lbl_adv_role.TabIndex = 23;
            this.lbl_adv_role.Text = "Advisor Role";
            // 
            // lbl_adv_id
            // 
            this.lbl_adv_id.AutoSize = true;
            this.lbl_adv_id.Location = new System.Drawing.Point(149, 74);
            this.lbl_adv_id.Name = "lbl_adv_id";
            this.lbl_adv_id.Size = new System.Drawing.Size(56, 13);
            this.lbl_adv_id.TabIndex = 21;
            this.lbl_adv_id.Text = "Advisor ID";
            // 
            // btn_add_pro_adv
            // 
            this.btn_add_pro_adv.Location = new System.Drawing.Point(283, 249);
            this.btn_add_pro_adv.Name = "btn_add_pro_adv";
            this.btn_add_pro_adv.Size = new System.Drawing.Size(170, 23);
            this.btn_add_pro_adv.TabIndex = 19;
            this.btn_add_pro_adv.Text = "Project Advisor Added";
            this.btn_add_pro_adv.UseVisualStyleBackColor = true;
            this.btn_add_pro_adv.Click += new System.EventHandler(this.btn_add_pro_adv_Click);
            // 
            // com_adv_id
            // 
            this.com_adv_id.FormattingEnabled = true;
            this.com_adv_id.Location = new System.Drawing.Point(292, 66);
            this.com_adv_id.Name = "com_adv_id";
            this.com_adv_id.Size = new System.Drawing.Size(100, 21);
            this.com_adv_id.TabIndex = 26;
            this.com_adv_id.SelectedIndexChanged += new System.EventHandler(this.com_adv_id_SelectedIndexChanged);
            // 
            // com_adv_role
            // 
            this.com_adv_role.FormattingEnabled = true;
            this.com_adv_role.Items.AddRange(new object[] {
            "Main Advisor",
            "Co-Advisror",
            "Industry Advisor"});
            this.com_adv_role.Location = new System.Drawing.Point(292, 164);
            this.com_adv_role.Name = "com_adv_role";
            this.com_adv_role.Size = new System.Drawing.Size(100, 21);
            this.com_adv_role.TabIndex = 27;
            // 
            // dtp_assign_date
            // 
            this.dtp_assign_date.Location = new System.Drawing.Point(283, 201);
            this.dtp_assign_date.Name = "dtp_assign_date";
            this.dtp_assign_date.Size = new System.Drawing.Size(200, 20);
            this.dtp_assign_date.TabIndex = 29;
            // 
            // lbl_assign_date
            // 
            this.lbl_assign_date.AutoSize = true;
            this.lbl_assign_date.Location = new System.Drawing.Point(149, 201);
            this.lbl_assign_date.Name = "lbl_assign_date";
            this.lbl_assign_date.Size = new System.Drawing.Size(87, 13);
            this.lbl_assign_date.TabIndex = 28;
            this.lbl_assign_date.Text = "Assignment Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Project Advisor Info";
            // 
            // ProjectAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 347);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_assign_date);
            this.Controls.Add(this.lbl_assign_date);
            this.Controls.Add(this.com_adv_role);
            this.Controls.Add(this.com_adv_id);
            this.Controls.Add(this.com_pro_id);
            this.Controls.Add(this.lbl_pro_id);
            this.Controls.Add(this.lbl_adv_role);
            this.Controls.Add(this.lbl_adv_id);
            this.Controls.Add(this.btn_add_pro_adv);
            this.Name = "ProjectAdvisor";
            this.Text = "ProjectAdvisor";
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}