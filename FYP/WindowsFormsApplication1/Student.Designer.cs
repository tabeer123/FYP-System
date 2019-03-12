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
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_regno);
            this.Controls.Add(this.txt_regno);
            this.Controls.Add(this.btn_addstd);
            this.Name = "Student";
            this.Text = "Student Added";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addstd;
        private System.Windows.Forms.TextBox txt_regno;
        private System.Windows.Forms.Label lbl_regno;
    }
}