﻿namespace WindowsFormsApplication1
{
    partial class Project
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
            this.lbl_pro_descrip = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_pro_title = new System.Windows.Forms.TextBox();
            this.lbl_pro_id = new System.Windows.Forms.Label();
            this.txt_pro_id = new System.Windows.Forms.TextBox();
            this.btn_add_pro = new System.Windows.Forms.Button();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_pro_descrip
            // 
            this.lbl_pro_descrip.AutoSize = true;
            this.lbl_pro_descrip.Location = new System.Drawing.Point(21, 73);
            this.lbl_pro_descrip.Name = "lbl_pro_descrip";
            this.lbl_pro_descrip.Size = new System.Drawing.Size(60, 13);
            this.lbl_pro_descrip.TabIndex = 24;
            this.lbl_pro_descrip.Text = "Description";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(21, 121);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(27, 13);
            this.lbl_title.TabIndex = 23;
            this.lbl_title.Text = "Title";
            // 
            // txt_pro_title
            // 
            this.txt_pro_title.Location = new System.Drawing.Point(164, 121);
            this.txt_pro_title.Name = "txt_pro_title";
            this.txt_pro_title.Size = new System.Drawing.Size(100, 20);
            this.txt_pro_title.TabIndex = 22;
            // 
            // lbl_pro_id
            // 
            this.lbl_pro_id.AutoSize = true;
            this.lbl_pro_id.Location = new System.Drawing.Point(21, 31);
            this.lbl_pro_id.Name = "lbl_pro_id";
            this.lbl_pro_id.Size = new System.Drawing.Size(54, 13);
            this.lbl_pro_id.TabIndex = 21;
            this.lbl_pro_id.Text = "Project ID";
            // 
            // txt_pro_id
            // 
            this.txt_pro_id.Location = new System.Drawing.Point(164, 31);
            this.txt_pro_id.Name = "txt_pro_id";
            this.txt_pro_id.Size = new System.Drawing.Size(100, 20);
            this.txt_pro_id.TabIndex = 20;
            // 
            // btn_add_pro
            // 
            this.btn_add_pro.Location = new System.Drawing.Point(155, 206);
            this.btn_add_pro.Name = "btn_add_pro";
            this.btn_add_pro.Size = new System.Drawing.Size(109, 23);
            this.btn_add_pro.TabIndex = 19;
            this.btn_add_pro.Text = "Advisor Added";
            this.btn_add_pro.UseVisualStyleBackColor = true;
            this.btn_add_pro.Click += new System.EventHandler(this.btn_add_pro_Click);
            // 
            // txt_descrip
            // 
            this.txt_descrip.Location = new System.Drawing.Point(164, 73);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(100, 20);
            this.txt_descrip.TabIndex = 25;
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_descrip);
            this.Controls.Add(this.lbl_pro_descrip);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.txt_pro_title);
            this.Controls.Add(this.lbl_pro_id);
            this.Controls.Add(this.txt_pro_id);
            this.Controls.Add(this.btn_add_pro);
            this.Name = "Project";
            this.Text = "Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_pro_descrip;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_pro_title;
        private System.Windows.Forms.Label lbl_pro_id;
        private System.Windows.Forms.TextBox txt_pro_id;
        private System.Windows.Forms.Button btn_add_pro;
        private System.Windows.Forms.TextBox txt_descrip;
    }
}