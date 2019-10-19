using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using ZXY_IMS.Models;

namespace ZXY_IMS.Repository
{
    public class ProductCatalog
    {
        private readonly string sqlConnectionString = Helper.SqlConnectionString();

        public bool AddCategory()
        {
            SqlConnection sqlConnection = new SqlConnection();
            
            return false;
        }
    }
}


//private void button1_Click(object sender, EventArgs e)
//{
//    string sqlConnectionString = Helper.SqlConnectionString();
//    string commandString = @"SELECT * FROM Admin";

//    SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
//    SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

//    sqlConnection.Open();

//    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
//    DataTable dataTable = new DataTable();
//    sqlDataAdapter.Fill(dataTable);
//    adminGridView.DataSource = dataTable;

//    sqlConnection.Close();
//}