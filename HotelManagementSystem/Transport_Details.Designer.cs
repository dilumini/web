namespace HotelManagementSystem
{
    partial class Transport_Details
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
            this.dataGridView_transport = new System.Windows.Forms.DataGridView();
            this.lbl_transportinfo = new System.Windows.Forms.Label();
            this.btn_showtransport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_transport
            // 
            this.dataGridView_transport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_transport.Location = new System.Drawing.Point(12, 72);
            this.dataGridView_transport.Name = "dataGridView_transport";
            this.dataGridView_transport.Size = new System.Drawing.Size(430, 273);
            this.dataGridView_transport.TabIndex = 0;
            // 
            // lbl_transportinfo
            // 
            this.lbl_transportinfo.AutoSize = true;
            this.lbl_transportinfo.Location = new System.Drawing.Point(172, 22);
            this.lbl_transportinfo.Name = "lbl_transportinfo";
            this.lbl_transportinfo.Size = new System.Drawing.Size(232, 13);
            this.lbl_transportinfo.TabIndex = 2;
            this.lbl_transportinfo.Text = "Bus Transpotation Details provided by the Hotel";
            // 
            // btn_showtransport
            // 
            this.btn_showtransport.Location = new System.Drawing.Point(455, 164);
            this.btn_showtransport.Name = "btn_showtransport";
            this.btn_showtransport.Size = new System.Drawing.Size(148, 38);
            this.btn_showtransport.TabIndex = 3;
            this.btn_showtransport.Text = "Show Transpotation Details";
            this.btn_showtransport.UseVisualStyleBackColor = true;
            this.btn_showtransport.Click += new System.EventHandler(this.btn_showtransport_Click);
            // 
            // Transport_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.btn_showtransport);
            this.Controls.Add(this.lbl_transportinfo);
            this.Controls.Add(this.dataGridView_transport);
            this.Name = "Transport_Details";
            this.Text = "Transport_Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_transport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_transport;
        private System.Windows.Forms.Label lbl_transportinfo;
        private System.Windows.Forms.Button btn_showtransport;
    }
}