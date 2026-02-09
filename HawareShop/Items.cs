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
    public partial class Items : Form
    {
        Function Function = new Function();
        public Items()
        {
            InitializeComponent();
            load_category();
        }

        //load item category
        private void load_category()
        {
            DataTable dt = Function.get_Category();
            txt_itemCategory.DataSource = dt;
            txt_itemCategory.DisplayMember = "CatName";
            txt_itemCategory.SelectedIndex = -1;

        }

        //load pages
        private void btn_customerForm_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.Show();
            this.Hide();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_categoryForm_Click(object sender, EventArgs e)
        {
            Catrgory catrgory = new Catrgory();
            catrgory.Show();
            this.Hide();
        }
    }
}
