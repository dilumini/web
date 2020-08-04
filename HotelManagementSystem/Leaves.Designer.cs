namespace HotelManagementSystem
{
    partial class Leaves
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
            this.lbl_selectdate = new System.Windows.Forms.Label();
            this.lbl_reqleave = new System.Windows.Forms.Label();
            this.btn_sendreq = new System.Windows.Forms.Button();
            this.dateTimePicker_leaves = new System.Windows.Forms.DateTimePicker();
            this.lbl_reason = new System.Windows.Forms.Label();
            this.txt_reason = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_selectdate
            // 
            this.lbl_selectdate.AutoSize = true;
            this.lbl_selectdate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_selectdate.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectdate.ForeColor = System.Drawing.Color.White;
            this.lbl_selectdate.Location = new System.Drawing.Point(77, 103);
            this.lbl_selectdate.Name = "lbl_selectdate";
            this.lbl_selectdate.Size = new System.Drawing.Size(168, 18);
            this.lbl_selectdate.TabIndex = 0;
            this.lbl_selectdate.Text = "Select the date ";
            // 
            // lbl_reqleave
            // 
            this.lbl_reqleave.AutoSize = true;
            this.lbl_reqleave.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reqleave.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reqleave.ForeColor = System.Drawing.Color.White;
            this.lbl_reqleave.Location = new System.Drawing.Point(210, 26);
            this.lbl_reqleave.Name = "lbl_reqleave";
            this.lbl_reqleave.Size = new System.Drawing.Size(220, 27);
            this.lbl_reqleave.TabIndex = 1;
            this.lbl_reqleave.Text = "Requesting for a leave";
            // 
            // btn_sendreq
            // 
            this.btn_sendreq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_sendreq.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendreq.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_sendreq.Location = new System.Drawing.Point(247, 237);
            this.btn_sendreq.Name = "btn_sendreq";
            this.btn_sendreq.Size = new System.Drawing.Size(151, 26);
            this.btn_sendreq.TabIndex = 3;
            this.btn_sendreq.Text = "Send Request";
            this.btn_sendreq.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker_leaves
            // 
            this.dateTimePicker_leaves.Location = new System.Drawing.Point(318, 101);
            this.dateTimePicker_leaves.Name = "dateTimePicker_leaves";
            this.dateTimePicker_leaves.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_leaves.TabIndex = 4;
            // 
            // lbl_reason
            // 
            this.lbl_reason.AutoSize = true;
            this.lbl_reason.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reason.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reason.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_reason.Location = new System.Drawing.Point(77, 162);
            this.lbl_reason.Name = "lbl_reason";
            this.lbl_reason.Size = new System.Drawing.Size(178, 18);
            this.lbl_reason.TabIndex = 5;
            this.lbl_reason.Text = "Enter your reason";
            // 
            // txt_reason
            // 
            this.txt_reason.Location = new System.Drawing.Point(318, 160);
            this.txt_reason.Multiline = true;
            this.txt_reason.Name = "txt_reason";
            this.txt_reason.Size = new System.Drawing.Size(200, 20);
            this.txt_reason.TabIndex = 6;
            // 
            // Leaves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HotelManagementSystem.Properties.Resources.pexels_photo_60217;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(646, 345);
            this.Controls.Add(this.txt_reason);
            this.Controls.Add(this.lbl_reason);
            this.Controls.Add(this.dateTimePicker_leaves);
            this.Controls.Add(this.btn_sendreq);
            this.Controls.Add(this.lbl_reqleave);
            this.Controls.Add(this.lbl_selectdate);
            this.Name = "Leaves";
            this.Text = "Leaves";
            this.Load += new System.EventHandler(this.Leaves_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_selectdate;
        private System.Windows.Forms.Label lbl_reqleave;
        private System.Windows.Forms.Button btn_sendreq;
        private System.Windows.Forms.DateTimePicker dateTimePicker_leaves;
        private System.Windows.Forms.Label lbl_reason;
        private System.Windows.Forms.TextBox txt_reason;
    }
}