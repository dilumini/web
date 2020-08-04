namespace HotelManagementSystem
{
    partial class Staff_Log_In
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
            this.lbl_slogin = new System.Windows.Forms.Label();
            this.lbl_userid = new System.Windows.Forms.Label();
            this.lbl_pw = new System.Windows.Forms.Label();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // lbl_slogin
            // 
            this.lbl_slogin.AutoSize = true;
            this.lbl_slogin.Location = new System.Drawing.Point(204, 28);
            this.lbl_slogin.Name = "lbl_slogin";
            this.lbl_slogin.Size = new System.Drawing.Size(62, 13);
            this.lbl_slogin.TabIndex = 0;
            this.lbl_slogin.Text = "Staff Log In";
            this.lbl_slogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_userid
            // 
            this.lbl_userid.AutoSize = true;
            this.lbl_userid.Location = new System.Drawing.Point(72, 87);
            this.lbl_userid.Name = "lbl_userid";
            this.lbl_userid.Size = new System.Drawing.Size(49, 13);
            this.lbl_userid.TabIndex = 1;
            this.lbl_userid.Text = "User ID :";
            this.lbl_userid.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_pw
            // 
            this.lbl_pw.AutoSize = true;
            this.lbl_pw.Location = new System.Drawing.Point(75, 129);
            this.lbl_pw.Name = "lbl_pw";
            this.lbl_pw.Size = new System.Drawing.Size(59, 13);
            this.lbl_pw.TabIndex = 2;
            this.lbl_pw.Text = "Password :";
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(236, 87);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(100, 20);
            this.txt_userid.TabIndex = 3;
            // 
            // txt_pw
            // 
            this.txt_pw.Location = new System.Drawing.Point(236, 129);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(100, 20);
            this.txt_pw.TabIndex = 4;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(207, 206);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 5;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 345);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // Staff_Log_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 345);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_userid);
            this.Controls.Add(this.lbl_pw);
            this.Controls.Add(this.lbl_userid);
            this.Controls.Add(this.lbl_slogin);
            this.Name = "Staff_Log_In";
            this.Text = "Staff Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_slogin;
        private System.Windows.Forms.Label lbl_userid;
        private System.Windows.Forms.Label lbl_pw;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Splitter splitter1;
    }
}

