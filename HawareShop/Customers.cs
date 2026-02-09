using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HawareShop
{
    public partial class Customers : Form
    {
        Function Function = new Function();
        public Customers()
        {
            InitializeComponent();
            CustomerLoad();
        }
        

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            string Name = txt_name.Text;
            string Gender = txt_gender.Text;
            string Phone = txt_phone.Text;
           
            Function.addCustomer(Name, Gender,Phone);
            CustomerLoad();
        }
        private void CustomerLoad()
        {
            DataGridView dvg = dvg_customer;
            Function.dgv_customer(dvg);
        }
    }
}
