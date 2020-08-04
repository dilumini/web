namespace HotelManagementSystem
{
    partial class Staff_Welcome
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
            this.lbl_swelcome = new System.Windows.Forms.Label();
            this.lbl_srequirement = new System.Windows.Forms.Label();
            this.radbtn_salary = new System.Windows.Forms.RadioButton();
            this.radbtn_leaves = new System.Windows.Forms.RadioButton();
            this.radbtn_transport = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lbl_swelcome
            // 
            this.lbl_swelcome.AutoSize = true;
            this.lbl_swelcome.BackColor = System.Drawing.Color.Transparent;
            this.lbl_swelcome.Font = new System.Drawing.Font("Castellar", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_swelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_swelcome.Location = new System.Drawing.Point(70, 50);
            this.lbl_swelcome.Name = "lbl_swelcome";
            this.lbl_swelcome.Size = new System.Drawing.Size(427, 29);
            this.lbl_swelcome.TabIndex = 0;
            this.lbl_swelcome.Text = "Staff Management System";
            this.lbl_swelcome.UseWaitCursor = true;
            // 
            // lbl_srequirement
            // 
            this.lbl_srequirement.AutoSize = true;
            this.lbl_srequirement.BackColor = System.Drawing.Color.Transparent;
            this.lbl_srequirement.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_srequirement.Location = new System.Drawing.Point(157, 114);
            this.lbl_srequirement.Name = "lbl_srequirement";
            this.lbl_srequirement.Size = new System.Drawing.Size(265, 30);
            this.lbl_srequirement.TabIndex = 1;
            this.lbl_srequirement.Text = "Select your Requirement";
            // 
            // radbtn_salary
            // 
            this.radbtn_salary.AutoSize = true;
            this.radbtn_salary.BackColor = System.Drawing.Color.Transparent;
            this.radbtn_salary.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radbtn_salary.Location = new System.Drawing.Point(198, 183);
            this.radbtn_salary.Name = "radbtn_salary";
            this.radbtn_salary.Size = new System.Drawing.Size(153, 24);
            this.radbtn_salary.TabIndex = 2;
            this.radbtn_salary.TabStop = true;
            this.radbtn_salary.Text = "Salary/Payments";
            this.radbtn_salary.UseVisualStyleBackColor = false;
            this.radbtn_salary.CheckedChanged += new System.EventHandler(this.radbtn_salary_CheckedChanged);
            // 
            // radbtn_leaves
            // 
            this.radbtn_leaves.AutoSize = true;
            this.radbtn_leaves.BackColor = System.Drawing.Color.Transparent;
            this.radbtn_leaves.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_leaves.Location = new System.Drawing.Point(198, 255);
            this.radbtn_leaves.Name = "radbtn_leaves";
            this.radbtn_leaves.Size = new System.Drawing.Size(78, 24);
            this.radbtn_leaves.TabIndex = 3;
            this.radbtn_leaves.TabStop = true;
            this.radbtn_leaves.Text = "Leaves";
            this.radbtn_leaves.UseVisualStyleBackColor = false;
            this.radbtn_leaves.CheckedChanged += new System.EventHandler(this.radbtn_leaves_CheckedChanged);
            // 
            // radbtn_transport
            // 
            this.radbtn_transport.AutoSize = true;
            this.radbtn_transport.BackColor = System.Drawing.Color.Transparent;
            this.radbtn_transport.Font = new System.Drawing.Font("Adobe Gothic Std B", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtn_transport.Location = new System.Drawing.Point(198, 329);
            this.radbtn_transport.Name = "radbtn_transport";
            this.radbtn_transport.Size = new System.Drawing.Size(190, 24);
            this.radbtn_transport.TabIndex = 4;
            this.radbtn_transport.TabStop = true;
            this.radbtn_transport.Text = "Transport Information";
            this.radbtn_transport.UseVisualStyleBackColor = false;
            this.radbtn_transport.CheckedChanged += new System.EventHandler(this.radbtn_transport_CheckedChanged);
            // 
            // Staff_Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.pexels_photo_3319959;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 436);
            this.Controls.Add(this.radbtn_transport);
            this.Controls.Add(this.radbtn_leaves);
            this.Controls.Add(this.radbtn_salary);
            this.Controls.Add(this.lbl_srequirement);
            this.Controls.Add(this.lbl_swelcome);
            this.Name = "Staff_Welcome";
            this.Text = "Staff_Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_swelcome;
        private System.Windows.Forms.Label lbl_srequirement;
        private System.Windows.Forms.RadioButton radbtn_salary;
        private System.Windows.Forms.RadioButton radbtn_leaves;
        private System.Windows.Forms.RadioButton radbtn_transport;
    }
}