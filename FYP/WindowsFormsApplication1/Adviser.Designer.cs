namespace WindowsFormsApplication1
{
    partial class Adviser
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
            this.lbl_advid = new System.Windows.Forms.Label();
            this.lbl_advsal = new System.Windows.Forms.Label();
            this.txt_advsal = new System.Windows.Forms.TextBox();
            this.txt_advid = new System.Windows.Forms.TextBox();
            this.lbl_desig = new System.Windows.Forms.Label();
            this.com_desig = new System.Windows.Forms.ComboBox();
            this.btn_addstd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_advid
            // 
            this.lbl_advid.AutoSize = true;
            this.lbl_advid.Location = new System.Drawing.Point(12, 82);
            this.lbl_advid.Name = "lbl_advid";
            this.lbl_advid.Size = new System.Drawing.Size(56, 13);
            this.lbl_advid.TabIndex = 13;
            this.lbl_advid.Text = "Adviser ID";
            this.lbl_advid.Click += new System.EventHandler(this.lbl_fname_Click);
            // 
            // lbl_advsal
            // 
            this.lbl_advsal.AutoSize = true;
            this.lbl_advsal.Location = new System.Drawing.Point(12, 156);
            this.lbl_advsal.Name = "lbl_advsal";
            this.lbl_advsal.Size = new System.Drawing.Size(36, 13);
            this.lbl_advsal.TabIndex = 12;
            this.lbl_advsal.Text = "Salary";
            // 
            // txt_advsal
            // 
            this.txt_advsal.Location = new System.Drawing.Point(161, 156);
            this.txt_advsal.Name = "txt_advsal";
            this.txt_advsal.Size = new System.Drawing.Size(100, 20);
            this.txt_advsal.TabIndex = 11;
            this.txt_advsal.TextChanged += new System.EventHandler(this.txt_advsal_TextChanged);
            // 
            // txt_advid
            // 
            this.txt_advid.Location = new System.Drawing.Point(161, 82);
            this.txt_advid.Name = "txt_advid";
            this.txt_advid.Size = new System.Drawing.Size(100, 20);
            this.txt_advid.TabIndex = 10;
            // 
            // lbl_desig
            // 
            this.lbl_desig.AutoSize = true;
            this.lbl_desig.Location = new System.Drawing.Point(13, 121);
            this.lbl_desig.Name = "lbl_desig";
            this.lbl_desig.Size = new System.Drawing.Size(63, 13);
            this.lbl_desig.TabIndex = 17;
            this.lbl_desig.Text = "Designation";
            // 
            // com_desig
            // 
            this.com_desig.FormattingEnabled = true;
            this.com_desig.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Lecturer",
            "Industry Professional"});
            this.com_desig.Location = new System.Drawing.Point(161, 121);
            this.com_desig.Name = "com_desig";
            this.com_desig.Size = new System.Drawing.Size(100, 21);
            this.com_desig.TabIndex = 18;
            // 
            // btn_addstd
            // 
            this.btn_addstd.Location = new System.Drawing.Point(152, 214);
            this.btn_addstd.Name = "btn_addstd";
            this.btn_addstd.Size = new System.Drawing.Size(109, 23);
            this.btn_addstd.TabIndex = 19;
            this.btn_addstd.Text = "Adviser Added";
            this.btn_addstd.UseVisualStyleBackColor = true;
            this.btn_addstd.Click += new System.EventHandler(this.btn_addstd_Click);
            // 
            // Adviser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_addstd);
            this.Controls.Add(this.com_desig);
            this.Controls.Add(this.lbl_desig);
            this.Controls.Add(this.lbl_advid);
            this.Controls.Add(this.lbl_advsal);
            this.Controls.Add(this.txt_advsal);
            this.Controls.Add(this.txt_advid);
            this.Name = "Adviser";
            this.Text = "Adviser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_advid;
        private System.Windows.Forms.Label lbl_advsal;
        private System.Windows.Forms.TextBox txt_advsal;
        private System.Windows.Forms.TextBox txt_advid;
        private System.Windows.Forms.Label lbl_desig;
        private System.Windows.Forms.ComboBox com_desig;
        private System.Windows.Forms.Button btn_addstd;
    }
}