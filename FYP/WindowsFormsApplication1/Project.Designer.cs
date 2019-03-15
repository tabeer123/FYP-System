namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.lbl_pro_descrip = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_pro_title = new System.Windows.Forms.TextBox();
            this.lbl_pro_id = new System.Windows.Forms.Label();
            this.txt_pro_id = new System.Windows.Forms.TextBox();
            this.btn_add_pro = new System.Windows.Forms.Button();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_pro_descrip
            // 
            this.lbl_pro_descrip.AutoSize = true;
            this.lbl_pro_descrip.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pro_descrip.Location = new System.Drawing.Point(223, 168);
            this.lbl_pro_descrip.Name = "lbl_pro_descrip";
            this.lbl_pro_descrip.Size = new System.Drawing.Size(116, 24);
            this.lbl_pro_descrip.TabIndex = 24;
            this.lbl_pro_descrip.Text = "Description";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(223, 224);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(52, 24);
            this.lbl_title.TabIndex = 23;
            this.lbl_title.Text = "Title";
            // 
            // txt_pro_title
            // 
            this.txt_pro_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pro_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_title.Location = new System.Drawing.Point(416, 227);
            this.txt_pro_title.Name = "txt_pro_title";
            this.txt_pro_title.Size = new System.Drawing.Size(197, 31);
            this.txt_pro_title.TabIndex = 22;
            // 
            // lbl_pro_id
            // 
            this.lbl_pro_id.AutoSize = true;
            this.lbl_pro_id.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pro_id.Location = new System.Drawing.Point(223, 112);
            this.lbl_pro_id.Name = "lbl_pro_id";
            this.lbl_pro_id.Size = new System.Drawing.Size(102, 24);
            this.lbl_pro_id.TabIndex = 21;
            this.lbl_pro_id.Text = "Project ID";
            // 
            // txt_pro_id
            // 
            this.txt_pro_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_pro_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pro_id.Location = new System.Drawing.Point(416, 115);
            this.txt_pro_id.Name = "txt_pro_id";
            this.txt_pro_id.Size = new System.Drawing.Size(197, 31);
            this.txt_pro_id.TabIndex = 20;
            // 
            // btn_add_pro
            // 
            this.btn_add_pro.Font = new System.Drawing.Font("Garamond", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_pro.Location = new System.Drawing.Point(619, 339);
            this.btn_add_pro.Name = "btn_add_pro";
            this.btn_add_pro.Size = new System.Drawing.Size(114, 32);
            this.btn_add_pro.TabIndex = 19;
            this.btn_add_pro.Text = "Advisor Added";
            this.btn_add_pro.UseVisualStyleBackColor = true;
            this.btn_add_pro.Click += new System.EventHandler(this.btn_add_pro_Click);
            // 
            // txt_descrip
            // 
            this.txt_descrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descrip.Location = new System.Drawing.Point(416, 171);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(197, 31);
            this.txt_descrip.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = " Project ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.79581F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.26178F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.63646F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.13539F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_pro_title, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_descrip, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_title, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_pro_id, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pro_descrip, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pro_id, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_add_pro, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-59, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 395);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Garamond", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(223, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Project
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Project";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Project_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_pro_descrip;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_pro_title;
        private System.Windows.Forms.Label lbl_pro_id;
        private System.Windows.Forms.TextBox txt_pro_id;
        private System.Windows.Forms.Button btn_add_pro;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}