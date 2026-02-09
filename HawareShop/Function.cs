using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HawareShop
{
    internal class Function
    {

        private string Constring = "Data Source=.;Initial Catalog=HardwareDB;Integrated Security=True";

        public void addCustomer(string Name, string Gender, string Phone)
        {
            int Cnt;
            string Query = @"insert into tbl_Customer (Name,Gender,Phone) values (@Name,@Gender,@Phone)";

            using (SqlConnection Con = new SqlConnection(Constring))
            {
                using (SqlCommand Cmd = new SqlCommand(Query, Con))
                {

                    Cmd.Parameters.AddWithValue("@Name", Name);
                    Cmd.Parameters.AddWithValue("@Gender", Gender);
                    Cmd.Parameters.AddWithValue("@Phone", Phone);
                    Con.Open();
                    Cnt = Cmd.ExecuteNonQuery();
                    if (Cnt > 0)
                    {

                        MessageBox.Show("Data Inserted Successfully");

                    }
                    else
                    {
                        MessageBox.Show("Error! Data not inserted");
                    }
                }
            }


        }
        //dvg_customer


        public void dgv_customer(DataGridView dgv)
        {
            string Query = "select * from tbl_Customer";

            DataTable dt = new DataTable();
            using (SqlConnection Con = new SqlConnection(Constring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(Query, Con))
            {
                Con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgv.DataSource = dt;
                }
            }
        }
        //Add Category to database
        public void add_Category(string CatName)
        {
            int Cnt;
            string Query = @"insert into tbl_Category (CatName) values (@CatName)";
            using (SqlConnection Con = new SqlConnection(Constring))
            {
                using (SqlCommand Cmd = new SqlCommand(Query, Con))
                {
                    Cmd.Parameters.AddWithValue("@CatName", CatName);

                    Con.Open();
                    Cnt = Cmd.ExecuteNonQuery();
                    if (Cnt > 0)
                    {
                        MessageBox.Show("Data Inserted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("Error! Data not inserted");
                    }
                }
            }
        }
        //dvg_category
        public void dgv_category(DataGridView dgv)
        {
            string Query = "select * from tbl_Category";
            DataTable dt = new DataTable();
            using (SqlConnection Con = new SqlConnection(Constring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(Query, Con))
            {
                Con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dgv.DataSource = dt;
                }
            }
        }

        //get category name
        public DataTable get_Category()
        {
            string Query = "select CatName from tbl_Category";
            DataTable dt = new DataTable();
            using (SqlConnection Con = new SqlConnection(Constring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(Query, Con))
            {
                
                Con.Open();
                adapter.Fill(dt);
                
            }
            return dt;
        }
    }
}
