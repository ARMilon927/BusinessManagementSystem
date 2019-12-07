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
    public class CustomerRepository
    {
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;
       // private SqlDataAdapter _sqlDataAdapter;
        private string query;
        private void Connect()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.ConnectionDatabase();
        }

        public int SaveCustomer(Customer aCustomer)
        {
            Connect();
            query = "INSERT INTO Customers(Code, Name, Address, Email, Contact, LoyaltyPoint) VALUES (@Code, @Name, @Address, @Email, @Contact, @LoyaltyPoint)";
            _sqlCommand = new SqlCommand();
            _sqlCommand.CommandText = query;
            _sqlCommand.Connection = DatabaseConnection.sqlConnection;
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aCustomer.Code;
            _sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Name"].Value = aCustomer.Name;
            _sqlCommand.Parameters.Add("Address", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Address"].Value = aCustomer.Address;
            _sqlCommand.Parameters.Add("Email", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Email"].Value = aCustomer.Email;
            _sqlCommand.Parameters.Add("Contact", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Contact"].Value = aCustomer.Contact;
            _sqlCommand.Parameters.Add("LoyaltyPoint", SqlDbType.Int);
            _sqlCommand.Parameters["LoyaltyPoint"].Value = aCustomer.LoyaltyPoint;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
        }
        public bool ExistCustomer(Customer aCustomer, string unique)
        {
            Connect();
            if (unique == "name")
                query = "SELECT * FROM Customers WHERE Name = '" + aCustomer.Name + "' AND Id <> " + aCustomer.Id + " ";
            if (unique == "code")
                query = "SELECT * FROM Customers WHERE Code = '" + aCustomer.Code + "' AND Id <> " + aCustomer.Id + "";
            if (unique == "email")
                query = "SELECT * FROM Customers WHERE Email = '" + aCustomer.Email + "' AND Id <> " + aCustomer.Id + "";
            _sqlCommand = new SqlCommand();
            _sqlCommand.CommandText = query;
            _sqlCommand.Connection = DatabaseConnection.sqlConnection;
            _sqlDataReader = _sqlCommand.ExecuteReader();
            bool isExist = _sqlDataReader.HasRows;
            DatabaseConnection.sqlConnection.Close();
            return isExist;
        }
        public List<Customer> ShowCustomer()
        {
            List<Customer> customers = new List<Customer>();
            Connect();
            query = "SELECT * FROM Customers";
            _sqlCommand = new SqlCommand();
            _sqlCommand.CommandText = query;
            _sqlCommand.Connection = DatabaseConnection.sqlConnection;
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Customer aCustomer = new Customer();
                aCustomer.Id = Convert.ToInt32(_sqlDataReader["Id"]);
                aCustomer.Code = _sqlDataReader["Code"].ToString();
                aCustomer.Name = _sqlDataReader["Name"].ToString();
                aCustomer.Address = _sqlDataReader["Address"].ToString();
                aCustomer.Email = _sqlDataReader["Email"].ToString();
                aCustomer.Contact = _sqlDataReader["Contact"].ToString();
                aCustomer.LoyaltyPoint = Convert.ToInt32(_sqlDataReader["LoyaltyPoint"]);
                customers.Add(aCustomer);
            }
            DatabaseConnection.sqlConnection.Close();
            return customers;
        }
        public int UpdateCustomer(Customer aCustomer)
        {
            Connect();
            query = "UPDATE Customers SET Name = @Name, Code = @Code, Address = @Address, Email = @Email, Contact = @Contact, LoyaltyPoint = @LoyaltyPoint  WHERE Id = " + aCustomer.Id + " ";
            _sqlCommand = new SqlCommand();
            _sqlCommand.CommandText = query;
            _sqlCommand.Connection = DatabaseConnection.sqlConnection;
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aCustomer.Code;
            _sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Name"].Value = aCustomer.Name;
            _sqlCommand.Parameters.Add("Address", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Address"].Value = aCustomer.Address;
            _sqlCommand.Parameters.Add("Email", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Email"].Value = aCustomer.Email;
            _sqlCommand.Parameters.Add("Contact", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Contact"].Value = aCustomer.Contact;
            _sqlCommand.Parameters.Add("LoyaltyPoint", SqlDbType.Int);
            _sqlCommand.Parameters["LoyaltyPoint"].Value = aCustomer.LoyaltyPoint;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
        }
        public List<Customer> SearchCustomer(string searchItem)
        {
            List<Customer> customers = new List<Customer>();
            Connect();
            query = "SELECT * FROM Customers WHERE Name LIKE '%"+ searchItem + "%' OR Contact LIKE '%" + searchItem + "%' OR Email LIKE '%" + searchItem + "%' ";
            _sqlCommand = new SqlCommand();
            _sqlCommand.CommandText = query;
            _sqlCommand.Connection = DatabaseConnection.sqlConnection;
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Customer aCustomer = new Customer();
                aCustomer.Id = Convert.ToInt32(_sqlDataReader["Id"]);
                aCustomer.Code = _sqlDataReader["Code"].ToString();
                aCustomer.Name = _sqlDataReader["Name"].ToString();
                aCustomer.Address = _sqlDataReader["Address"].ToString();
                aCustomer.Email = _sqlDataReader["Email"].ToString();
                aCustomer.Contact = _sqlDataReader["Contact"].ToString();
                aCustomer.LoyaltyPoint = Convert.ToInt32(_sqlDataReader["LoyaltyPoint"]);
                customers.Add(aCustomer);
            }
            DatabaseConnection.sqlConnection.Close();
            return customers;
        }
    }
}
