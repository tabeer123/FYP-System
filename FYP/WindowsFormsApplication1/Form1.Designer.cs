namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.txt_contact = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_contact = new System.Windows.Forms.Label();
            this.lbl_lname = new System.Windows.Forms.Label();
            this.lbl_fname = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_dob = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.dtp_dob = new System.Windows.Forms.DateTimePicker();
            this.com_gender = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_addstd
            // 
            this.btn_addstd.Location = new System.Drawing.Point(460, 321);
            this.btn_addstd.Name = "btn_addstd";
            this.btn_addstd.Size = new System.Drawing.Size(75, 23);
            this.btn_addstd.TabIndex = 0;
            this.btn_addstd.Text = "Add Student";
            this.btn_addstd.UseVisualStyleBackColor = true;
            this.btn_addstd.Click += new System.EventHandler(this.btn_addstd_Click);
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(343, 77);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(100, 20);
            this.txtfname.TabIndex = 1;
            this.txtfname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(343, 116);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 20);
            this.txt_lname.TabIndex = 2;
            // 
            // txt_contact
            // 
            this.txt_contact.Location = new System.Drawing.Point(343, 153);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Size = new System.Drawing.Size(100, 20);
            this.txt_contact.TabIndex = 4;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(143, 190);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(32, 13);
            this.lbl_email.TabIndex = 6;
            this.lbl_email.Text = "Email";
            this.lbl_email.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_contact
            // 
            this.lbl_contact.AutoSize = true;
            this.lbl_contact.Location = new System.Drawing.Point(143, 153);
            this.lbl_contact.Name = "lbl_contact";
            this.lbl_contact.Size = new System.Drawing.Size(44, 13);
            this.lbl_contact.TabIndex = 7;
            this.lbl_contact.Text = "Contact";
            // 
            // lbl_lname
            // 
            this.lbl_lname.AutoSize = true;
            this.lbl_lname.Location = new System.Drawing.Point(143, 116);
            this.lbl_lname.Name = "lbl_lname";
            this.lbl_lname.Size = new System.Drawing.Size(58, 13);
            this.lbl_lname.TabIndex = 8;
            this.lbl_lname.Text = "Last Name";
            // 
            // lbl_fname
            // 
            this.lbl_fname.AutoSize = true;
            this.lbl_fname.Location = new System.Drawing.Point(143, 77);
            this.lbl_fname.Name = "lbl_fname";
            this.lbl_fname.Size = new System.Drawing.Size(57, 13);
            this.lbl_fname.TabIndex = 9;
            this.lbl_fname.Text = "First Name";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Location = new System.Drawing.Point(143, 271);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(42, 13);
            this.lbl_gender.TabIndex = 11;
            this.lbl_gender.Text = "Gender";
            this.lbl_gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // lbl_dob
            // 
            this.lbl_dob.AutoSize = true;
            this.lbl_dob.Location = new System.Drawing.Point(143, 230);
            this.lbl_dob.Name = "lbl_dob";
            this.lbl_dob.Size = new System.Drawing.Size(68, 13);
            this.lbl_dob.TabIndex = 12;
            this.lbl_dob.Text = "Date Of Birth";
            this.lbl_dob.Click += new System.EventHandler(this.lbl_dob_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(343, 190);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 15;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Location = new System.Drawing.Point(296, 230);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(200, 20);
            this.dtp_dob.TabIndex = 16;
            // 
            // com_gender
            // 
            this.com_gender.FormattingEnabled = true;
            this.com_gender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.com_gender.Location = new System.Drawing.Point(343, 271);
            this.com_gender.Name = "com_gender";
            this.com_gender.Size = new System.Drawing.Size(100, 21);
            this.com_gender.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Person Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
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
            this.Controls.Add(this.btn_addstd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addstd;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.TextBox txt_contact;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_contact;
        private System.Windows.Forms.Label lbl_lname;
        private System.Windows.Forms.Label lbl_fname;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_dob;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.DateTimePicker dtp_dob;
        private System.Windows.Forms.ComboBox com_gender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

