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

        //public int SetData(string Query)
        //{
        //    int Cnt;
        //    if (Con.State == ConnectionState.Closed)
        //    {
        //        Con.Open();
        //    }
        //    Cmd.CommandText = Query;
        //    Cnt = Cmd.ExecuteNonQuery();
        //    Con.Close();
        //    return Cnt;
        //}
        //add customer data to database
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
            //using (SqlConnection Con = new SqlConnection(Constring))
            //{
            //    using (SqlCommand Cmd = new SqlCommand(Query, Con))
            //    {
            //        Con.Open();
            //        SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            //        DataTable dt = new DataTable();
            //        sda.Fill(dt);
            //        dgv.DataSource = dt;
            //    }
            //}
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
    }
}
