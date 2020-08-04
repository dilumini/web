using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Salary_Payments : Form
    {
        public Salary_Payments()
        {
            InitializeComponent();
        }

        private void btn_checksal_Click(object sender, EventArgs e)
        {
            String dept = txt_dept.Text;
            String post = txt_post.Text;
            int ot = int.Parse(txt_OT.Text);


        }
        class employee
        {
            int ot;


        }

        class house_keeping : employee
        {
            double bsal = 20000;
            public house_keeping(double basal)
            {
                bsal = basal;
            }

            class kitchen : employee
            {

            }
            class fandb : employee
            {

            }
            class maintanance : employee
            {

            }
        }

        private void lbl_post_Click(object sender, EventArgs e)
        {

        }
    }
}
    
