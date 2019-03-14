namespace WindowsFormsApplication1
{
    partial class EditStudent
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
            this.com_gender = new System.Windows.Forms.ComboBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.btn_editstd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // com_gender
            // 
            this.com_gender.FormattingEnabled = true;
            this.com_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.com_gender.Location = new System.Drawing.Point(229, 265);
            this.com_gender.Name = "com_gender";
            this.com_gender.Size = new System.Drawing.Size(100, 21);
            this.com_gender.TabIndex = 31;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(182, 200);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(200, 20);
            this.dtp_dob.TabIndex = 30;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(229, 160);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 29;
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(29, 200);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(68, 13);
            this.lbl_dob.TabIndex = 28;
            this.lbl_dob.Text = "Date Of Birth";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(29, 241);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 27;
            this.lbl_gender.Text = "Gender";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(29, 47);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(57, 13);
            this.lbl_fname.TabIndex = 26;
            this.lbl_fname.Text = "First Name";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(29, 86);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(58, 13);
            this.lbl_lname.TabIndex = 25;
            this.lbl_lname.Text = "Last Name";
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(29, 123);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(44, 13);
            this.lbl_contact.TabIndex = 24;
            this.lbl_contact.Text = "Contact";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(29, 160);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 23;
            this.lbl_email.Text = "Email";
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(229, 123);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(100, 20);
            this.txt_contact.TabIndex = 22;
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(229, 86);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 20);
            this.txt_lname.TabIndex = 21;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(229, 47);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 20;
            // 
            // btn_editstd
            // 
            this.btn_editstd.Location = new System.Drawing.Point(307, 313);
            this.btn_editstd.Name = "btn_editstd";
            this.btn_editstd.Size = new System.Drawing.Size(75, 23);
            this.btn_editstd.TabIndex = 19;
            this.btn_editstd.Text = "Edit Student";
            this.btn_editstd.UseVisualStyleBackColor = true;
            this.btn_editstd.Click += new System.EventHandler(this.btn_editstd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Id";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(229, 19);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 39);
            this.label2.TabIndex = 34;
            this.label2.Text = "Edit Student Data";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 451);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.com_gender);
            this.Controls.Add(this.dtp_dob);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_dob);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.lbl_fname);
            this.Controls.Add(this.lbl_lname);
            this.Controls.Add(this.lbl_contact);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.txt_contact);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.btn_editstd);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.Load += new System.EventHandler(this.EditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_editstd;
        public System.Windows.Forms.ComboBox com_gender;
        public System.Windows.Forms.DateTimePicker dtp_dob;
        public System.Windows.Forms.TextBox txt_email;
        public System.Windows.Forms.TextBox txt_contact;
        public System.Windows.Forms.TextBox txt_lname;
        public System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
    }
}