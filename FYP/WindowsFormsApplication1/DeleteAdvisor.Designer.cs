namespace WindowsFormsApplication1
{
    partial class DeleteAdvisor
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
            this.lbl_adv_id = new System.Windows.Forms.Label();
            this.txt_adv_id = new System.Windows.Forms.TextBox();
            this.btn_add_adv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_adv_id
            // 
            this.lbl_adv_id.AutoSize = true;
            this.lbl_adv_id.Location = new System.Drawing.Point(33, 101);
            this.lbl_adv_id.Name = "lbl_adv_id";
            this.lbl_adv_id.Size = new System.Drawing.Size(56, 13);
            this.lbl_adv_id.TabIndex = 28;
            this.lbl_adv_id.Text = "Advisor ID";
            // 
            // txt_adv_id
            // 
            this.txt_adv_id.Location = new System.Drawing.Point(142, 101);
            this.txt_adv_id.Name = "txt_adv_id";
            this.txt_adv_id.Size = new System.Drawing.Size(100, 20);
            this.txt_adv_id.TabIndex = 27;
            // 
            // btn_add_adv
            // 
            this.btn_add_adv.Location = new System.Drawing.Point(155, 206);
            this.btn_add_adv.Name = "btn_add_adv";
            this.btn_add_adv.Size = new System.Drawing.Size(109, 23);
            this.btn_add_adv.TabIndex = 26;
            this.btn_add_adv.Text = "Delete Advisor ";
            this.btn_add_adv.UseVisualStyleBackColor = true;
            this.btn_add_adv.Click += new System.EventHandler(this.btn_add_adv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Delete Advisor";
            // 
            // DeleteAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_adv_id);
            this.Controls.Add(this.txt_adv_id);
            this.Controls.Add(this.btn_add_adv);
            this.Name = "DeleteAdvisor";
            this.Text = "DeleteAdvisor";
            this.Load += new System.EventHandler(this.DeleteAdvisor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_adv_id;
        public System.Windows.Forms.TextBox txt_adv_id;
        private System.Windows.Forms.Button btn_add_adv;
        private System.Windows.Forms.Label label2;
    }
}