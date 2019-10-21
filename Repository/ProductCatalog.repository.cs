using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ZXY_IMS.Repository
{
    public class ProductCatalog
    {
        private readonly string sqlConnectionString = Helper.SqlConnectionString();

        public bool ExecuteSQLNonQueryCommand(string commandString)
        {
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            Console.WriteLine(commandString);
            int isExecuted = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (isExecuted > 0) return true;
            return false;
        }

        public DataTable ExecuteSQLSelectCommand(string commandString)
        {
            
            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

        public bool AddProductCategory(Models.ProductCategory productCategory)
        {
            string commandString = @"INSERT INTO ProductCategories (Code, CategoryName) Values ('" + productCategory.Code + "','" + productCategory.CategoryName +"')";
            return ExecuteSQLNonQueryCommand(commandString);
        }

        public DataTable GetProductCategories()
        {
            string commandString = @"SELECT * FROM ProductCategories";
            return ExecuteSQLSelectCommand(commandString);
        }
    }
}
