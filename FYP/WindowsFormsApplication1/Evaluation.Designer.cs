namespace WindowsFormsApplication1
{
    partial class Evaluation
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_totmar = new System.Windows.Forms.Label();
            this.lbl_totwei = new System.Windows.Forms.Label();
            this.txt_totwet = new System.Windows.Forms.TextBox();
            this.txt_mark = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_evaluate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(80, 80);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_totmar
            // 
            this.lbl_totmar.AutoSize = true;
            this.lbl_totmar.Location = new System.Drawing.Point(80, 129);
            this.lbl_totmar.Name = "lbl_totmar";
            this.lbl_totmar.Size = new System.Drawing.Size(63, 13);
            this.lbl_totmar.TabIndex = 2;
            this.lbl_totmar.Text = "Total Marks";
            // 
            // lbl_totwei
            // 
            this.lbl_totwei.AutoSize = true;
            this.lbl_totwei.Location = new System.Drawing.Point(80, 175);
            this.lbl_totwei.Name = "lbl_totwei";
            this.lbl_totwei.Size = new System.Drawing.Size(90, 13);
            this.lbl_totwei.TabIndex = 3;
            this.lbl_totwei.Text = "Total Weight Age";
            // 
            // txt_totwet
            // 
            this.txt_totwet.Location = new System.Drawing.Point(234, 175);
            this.txt_totwet.Name = "txt_totwet";
            this.txt_totwet.Size = new System.Drawing.Size(100, 20);
            this.txt_totwet.TabIndex = 5;
            // 
            // txt_mark
            // 
            this.txt_mark.Location = new System.Drawing.Point(234, 129);
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(100, 20);
            this.txt_mark.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(234, 80);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 7;
            // 
            // btn_evaluate
            // 
            this.btn_evaluate.Location = new System.Drawing.Point(274, 264);
            this.btn_evaluate.Name = "btn_evaluate";
            this.btn_evaluate.Size = new System.Drawing.Size(75, 23);
            this.btn_evaluate.TabIndex = 8;
            this.btn_evaluate.Text = "Evaluate ";
            this.btn_evaluate.UseVisualStyleBackColor = true;
            this.btn_evaluate.Click += new System.EventHandler(this.btn_evaluate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Brush Script MT", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 39);
            this.label2.TabIndex = 36;
            this.label2.Text = "Evaluation";
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 331);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_evaluate);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_mark);
            this.Controls.Add(this.txt_totwet);
            this.Controls.Add(this.lbl_totwei);
            this.Controls.Add(this.lbl_totmar);
            this.Controls.Add(this.lbl_name);
            this.Name = "Evaluation";
            this.Text = "Evaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_totmar;
        private System.Windows.Forms.Label lbl_totwei;
        private System.Windows.Forms.TextBox txt_totwet;
        private System.Windows.Forms.TextBox txt_mark;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_evaluate;
        private System.Windows.Forms.Label label2;
    }
}