namespace HotelManagementSystem
{
    partial class Salary_Payments
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
            this.lbl_salarycal = new System.Windows.Forms.Label();
            this.lbl_dept = new System.Windows.Forms.Label();
            this.lbl_post = new System.Windows.Forms.Label();
            this.btn_checksal = new System.Windows.Forms.Button();
            this.txt_dept = new System.Windows.Forms.TextBox();
            this.txt_post = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_salarycal
            // 
            this.lbl_salarycal.AutoSize = true;
            this.lbl_salarycal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_salarycal.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salarycal.Location = new System.Drawing.Point(230, 39);
            this.lbl_salarycal.Name = "lbl_salarycal";
            this.lbl_salarycal.Size = new System.Drawing.Size(191, 30);
            this.lbl_salarycal.TabIndex = 0;
            this.lbl_salarycal.Text = "Salary Calculator";
            // 
            // lbl_dept
            // 
            this.lbl_dept.AutoSize = true;
            this.lbl_dept.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dept.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dept.ForeColor = System.Drawing.Color.White;
            this.lbl_dept.Location = new System.Drawing.Point(85, 118);
            this.lbl_dept.Name = "lbl_dept";
            this.lbl_dept.Size = new System.Drawing.Size(218, 18);
            this.lbl_dept.TabIndex = 1;
            this.lbl_dept.Text = "Enter your Department";
            // 
            // lbl_post
            // 
            this.lbl_post.AutoSize = true;
            this.lbl_post.BackColor = System.Drawing.Color.Transparent;
            this.lbl_post.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_post.ForeColor = System.Drawing.Color.White;
            this.lbl_post.Location = new System.Drawing.Point(85, 181);
            this.lbl_post.Name = "lbl_post";
            this.lbl_post.Size = new System.Drawing.Size(158, 18);
            this.lbl_post.TabIndex = 2;
            this.lbl_post.Text = "Enter your Post";
            this.lbl_post.Click += new System.EventHandler(this.lbl_post_Click);
            // 
            // btn_checksal
            // 
            this.btn_checksal.BackColor = System.Drawing.Color.White;
            this.btn_checksal.Font = new System.Drawing.Font("Lucida Sans Typewriter", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checksal.ForeColor = System.Drawing.Color.Black;
            this.btn_checksal.Location = new System.Drawing.Point(275, 276);
            this.btn_checksal.Name = "btn_checksal";
            this.btn_checksal.Size = new System.Drawing.Size(119, 23);
            this.btn_checksal.TabIndex = 3;
            this.btn_checksal.Text = "Check Salary";
            this.btn_checksal.UseVisualStyleBackColor = false;
            this.btn_checksal.Click += new System.EventHandler(this.btn_checksal_Click);
            // 
            // txt_dept
            // 
            this.txt_dept.Location = new System.Drawing.Point(343, 116);
            this.txt_dept.Name = "txt_dept";
            this.txt_dept.Size = new System.Drawing.Size(161, 20);
            this.txt_dept.TabIndex = 4;
            // 
            // txt_post
            // 
            this.txt_post.Location = new System.Drawing.Point(343, 179);
            this.txt_post.Name = "txt_post";
            this.txt_post.Size = new System.Drawing.Size(161, 20);
            this.txt_post.TabIndex = 5;
            // 
            // Salary_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.photo_1592571579973_b0a19b5aa0c6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 355);
            this.Controls.Add(this.txt_post);
            this.Controls.Add(this.txt_dept);
            this.Controls.Add(this.btn_checksal);
            this.Controls.Add(this.lbl_post);
            this.Controls.Add(this.lbl_dept);
            this.Controls.Add(this.lbl_salarycal);
            this.Name = "Salary_Payments";
            this.Text = "Salary_Payments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_salarycal;
        private System.Windows.Forms.Label lbl_dept;
        private System.Windows.Forms.Label lbl_post;
        private System.Windows.Forms.Button btn_checksal;
        private System.Windows.Forms.TextBox txt_dept;
        private System.Windows.Forms.TextBox txt_post;
    }
}