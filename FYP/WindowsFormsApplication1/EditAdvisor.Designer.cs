namespace WindowsFormsApplication1
{
    partial class EditAdvisor
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
            this.com_desig = new System.Windows.Forms.ComboBox();
            this.lbl_desig = new System.Windows.Forms.Label();
            this.lbl_sal = new System.Windows.Forms.Label();
            this.txt_adv_sal = new System.Windows.Forms.TextBox();
            this.lbl_adv_id = new System.Windows.Forms.Label();
            this.txt_adv_id = new System.Windows.Forms.TextBox();
            this.btn_add_adv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // com_desig
            // 
            this.com_desig.FormattingEnabled = true;
            this.com_desig.Items.AddRange(new object[] {
            "Professor",
            "Associate Professor",
            "Lecturer",
            "Industry Professional"});
            this.com_desig.Location = new System.Drawing.Point(229, 97);
            this.com_desig.Name = "com_desig";
            this.com_desig.Size = new System.Drawing.Size(100, 21);
            this.com_desig.TabIndex = 25;
            // 
            // lbl_desig
            // 
            this.lbl_desig.AutoSize = true;
            this.lbl_desig.Location = new System.Drawing.Point(86, 97);
            this.lbl_desig.Name = "lbl_desig";
            this.lbl_desig.Size = new System.Drawing.Size(63, 13);
            this.lbl_desig.TabIndex = 24;
            this.lbl_desig.Text = "Designation";
            // 
            // lbl_sal
            // 
            this.lbl_sal.AutoSize = true;
            this.lbl_sal.Location = new System.Drawing.Point(86, 145);
            this.lbl_sal.Name = "lbl_sal";
            this.lbl_sal.Size = new System.Drawing.Size(36, 13);
            this.lbl_sal.TabIndex = 23;
            this.lbl_sal.Text = "Salary";
            // 
            // txt_adv_sal
            // 
            this.txt_adv_sal.Location = new System.Drawing.Point(229, 145);
            this.txt_adv_sal.Name = "txt_adv_sal";
            this.txt_adv_sal.Size = new System.Drawing.Size(100, 20);
            this.txt_adv_sal.TabIndex = 22;
            // 
            // lbl_adv_id
            // 
            this.lbl_adv_id.AutoSize = true;
            this.lbl_adv_id.Location = new System.Drawing.Point(86, 55);
            this.lbl_adv_id.Name = "lbl_adv_id";
            this.lbl_adv_id.Size = new System.Drawing.Size(56, 13);
            this.lbl_adv_id.TabIndex = 21;
            this.lbl_adv_id.Text = "Advisor ID";
            // 
            // txt_adv_id
            // 
            this.txt_adv_id.Location = new System.Drawing.Point(229, 55);
            this.txt_adv_id.Name = "txt_adv_id";
            this.txt_adv_id.Size = new System.Drawing.Size(100, 20);
            this.txt_adv_id.TabIndex = 20;
            // 
            // btn_add_adv
            // 
            this.btn_add_adv.Location = new System.Drawing.Point(262, 243);
            this.btn_add_adv.Name = "btn_add_adv";
            this.btn_add_adv.Size = new System.Drawing.Size(109, 23);
            this.btn_add_adv.TabIndex = 19;
            this.btn_add_adv.Text = "Advisor Added";
            this.btn_add_adv.UseVisualStyleBackColor = true;
            this.btn_add_adv.Click += new System.EventHandler(this.btn_add_adv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Edit Advisor";
            // 
            // EditAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 309);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.com_desig);
            this.Controls.Add(this.lbl_desig);
            this.Controls.Add(this.lbl_sal);
            this.Controls.Add(this.txt_adv_sal);
            this.Controls.Add(this.lbl_adv_id);
            this.Controls.Add(this.txt_adv_id);
            this.Controls.Add(this.btn_add_adv);
            this.Name = "EditAdvisor";
            this.Text = "EditAdvisor";
            this.Load += new System.EventHandler(this.EditAdvisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_desig;
        private System.Windows.Forms.Label lbl_sal;
        private System.Windows.Forms.Label lbl_adv_id;
        private System.Windows.Forms.Button btn_add_adv;
        public System.Windows.Forms.ComboBox com_desig;
        public System.Windows.Forms.TextBox txt_adv_sal;
        public System.Windows.Forms.TextBox txt_adv_id;
        private System.Windows.Forms.Label label2;
    }
}