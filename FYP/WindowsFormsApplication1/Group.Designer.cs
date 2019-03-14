namespace WindowsFormsApplication1
{
    partial class Group
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
            this.lbl_Create = new System.Windows.Forms.Label();
            this.dtp_create = new System.Windows.Forms.DateTimePicker();
            this.btn_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Create
            // 
            this.lbl_Create.AutoSize = true;
            this.lbl_Create.Location = new System.Drawing.Point(67, 109);
            this.lbl_Create.Name = "lbl_Create";
            this.lbl_Create.Size = new System.Drawing.Size(61, 13);
            this.lbl_Create.TabIndex = 1;
            this.lbl_Create.Text = "Created On";
            // 
            // dtp_create
            // 
            this.dtp_create.Location = new System.Drawing.Point(197, 109);
            this.dtp_create.Name = "dtp_create";
            this.dtp_create.Size = new System.Drawing.Size(200, 20);
            this.dtp_create.TabIndex = 2;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(294, 238);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(75, 23);
            this.btn_create.TabIndex = 3;
            this.btn_create.Text = "Group Create";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Groups";
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 321);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dtp_create);
            this.Controls.Add(this.lbl_Create);
            this.Name = "Group";
            this.Text = "Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Create;
        private System.Windows.Forms.DateTimePicker dtp_create;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label2;
    }
}