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
    public partial class Catrgory : Form
    {
        Function Function = new Function();
        public Catrgory()
        {
            InitializeComponent();
            CategoryLoad();
        }

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            string Name = txt_category.Text;
            Function.add_Category(Name);
            CategoryLoad();
        }
        //Load category data to datagridview
        private void CategoryLoad()
        {
            DataGridView dvg = dvg_category;
            Function.dgv_category(dvg);
        }

        private void btn_ItemForm_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
            this.Hide();
        }

        private void btn_CustomerForm_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void btn_BillingForm_Click(object sender, EventArgs e)
        {
            Billing billing = new Billing();
            billing.Show();
            this.Hide();
        }
    }
}
