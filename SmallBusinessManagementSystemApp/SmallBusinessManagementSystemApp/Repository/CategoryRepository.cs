using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystemApp.Model;

namespace SmallBusinessManagementSystemApp.Repository
{
    public class CategoryRepository
    {
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;
        //private SqlDataAdapter _sqlDataAdapter;
        private string query;
        private void Connect()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.ConnectionDatabase();
        }
        public int SaveCategory(Category aCategory)
        {
            Connect();
            query = "INSERT INTO Categories(Name, Code) VALUES (@Name, @Code) ";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Name"].Value = aCategory.Name;
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aCategory.Code;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
        }
        public bool ExistCategory(Category aCategory, string unique)
        {
            Connect();
            if(unique == "name")
                query = "SELECT * FROM Categories WHERE Name = @Name AND Id <> "+aCategory.Id+ " ";
            if(unique == "code")
                query = "SELECT * FROM Categories WHERE Code = @Code AND Id <> " + aCategory.Id + "";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlCommand.Parameters.Clear();
            if (unique == "name")
            {
                _sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar);
                _sqlCommand.Parameters["Name"].Value = aCategory.Name;
            }
            if (unique == "code")
            {
                _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
                _sqlCommand.Parameters["Code"].Value = aCategory.Code;
            }
            _sqlDataReader = _sqlCommand.ExecuteReader();
            bool isExist = _sqlDataReader.HasRows;
            DatabaseConnection.sqlConnection.Close();
            return isExist ;
        }
        public List<Category>  ShowCategory()
        {
            List<Category> categories = new List<Category>();
            Connect();
            query = "SELECT * from Categories";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Category aCategory = new Category
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]),
                    Code = _sqlDataReader["Code"].ToString(),
                    Name = _sqlDataReader["Name"].ToString()
                };
                categories.Add(aCategory);
            }
            DatabaseConnection.sqlConnection.Close();
            return categories;
        }
        public int UpdateCategory(Category aCategory)
        {
            Connect();
            query = "UPDATE Categories SET Name = @Name, Code = @Code WHERE Id = " + aCategory.Id+" ";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Name"].Value = aCategory.Name;
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aCategory.Code;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
        }
        public List<Category> SearchCategory(string searchItem)
        {
            List<Category> categories = new List<Category>();
            Connect();
            query = "SELECT * FROM Categories WHERE Code LIKE '%"+searchItem+ "%' OR Name LIKE '%" + searchItem + "%' ";
            _sqlCommand = new SqlCommand { CommandText = query, Connection = DatabaseConnection.sqlConnection };
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Category aCategory = new Category
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]),
                    Code = _sqlDataReader["Code"].ToString(),
                    Name = _sqlDataReader["Name"].ToString()
                };
                categories.Add(aCategory);
            }
            DatabaseConnection.sqlConnection.Close();
            return categories;
        }
    }
}
