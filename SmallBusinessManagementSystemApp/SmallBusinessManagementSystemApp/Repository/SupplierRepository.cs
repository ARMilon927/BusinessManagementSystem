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
    public class SupplierRepository
    {
        private SqlCommand _sqlCommand;
        private SqlDataReader _sqlDataReader;
      //  private SqlDataAdapter _sqlDataAdapter;
        private string query;
        private void Connect()
        {
            DatabaseConnection databaseConnection = new DatabaseConnection();
            databaseConnection.ConnectionDatabase();
        }

        public int SaveSupplier(Supplier aSupplier)
        {
            Connect();
            query = "INSERT INTO Suppliers(Code, Name, Address, Email, Contact, ContactPerson) VALUES (@Code, @Name, @Address, @Email, @Contact, @ContactPerson)";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aSupplier.Code;
            _sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Name"].Value = aSupplier.Name;
            _sqlCommand.Parameters.Add("Address", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Address"].Value = aSupplier.Address;
            _sqlCommand.Parameters.Add("Email", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Email"].Value = aSupplier.Email;
            _sqlCommand.Parameters.Add("Contact", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Contact"].Value = aSupplier.Contact;
            _sqlCommand.Parameters.Add("ContactPerson", SqlDbType.NVarChar);
            _sqlCommand.Parameters["ContactPerson"].Value = aSupplier.ContactPerson;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
        }
        public bool ExistSupplier(Supplier aSupplier, string unique)
        {
            Connect();
            if (unique == "name")
                query = "SELECT * FROM Suppliers WHERE Name = '" + aSupplier.Name + "' AND Id <> " + aSupplier.Id + " ";
            if (unique == "code")
                query = "SELECT * FROM Suppliers WHERE Code = '" + aSupplier.Code + "' AND Id <> " + aSupplier.Id + "";
            if (unique == "email")
                query = "SELECT * FROM Suppliers WHERE Email = '" + aSupplier.Email + "' AND Id <> " + aSupplier.Id + "";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            bool isExist = _sqlDataReader.HasRows;
            DatabaseConnection.sqlConnection.Close();
            return isExist;
        }
        public List<Supplier> ShowSupplier()
        {
            List<Supplier> suppliers = new List<Supplier>();
            Connect();
            query = "SELECT * FROM Suppliers";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Supplier aSupplier = new Supplier
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]),
                    Code = _sqlDataReader["Code"].ToString(),
                    Name = _sqlDataReader["Name"].ToString(),
                    Address = _sqlDataReader["Address"].ToString(),
                    Email = _sqlDataReader["Email"].ToString(),
                    Contact = _sqlDataReader["Contact"].ToString(),
                    ContactPerson = _sqlDataReader["ContactPerson"].ToString()
                };
                ;
                suppliers.Add(aSupplier);
            }
            DatabaseConnection.sqlConnection.Close();
            return suppliers;
        }
        public int UpdateSupplier(Supplier aSupplier)
        {
            Connect();
            query = "UPDATE Suppliers SET Name = @Name, Code = @Code, Address = @Address, Email = @Email, Contact = @Contact, ContactPerson = @ContactPerson  WHERE Id = " + aSupplier.Id + " ";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlCommand.Parameters.Clear();
            _sqlCommand.Parameters.Add("Code", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Code"].Value = aSupplier.Code;
            _sqlCommand.Parameters.Add("Name", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Name"].Value = aSupplier.Name;
            _sqlCommand.Parameters.Add("Address", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Address"].Value = aSupplier.Address;
            _sqlCommand.Parameters.Add("Email", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Email"].Value = aSupplier.Email;
            _sqlCommand.Parameters.Add("Contact", SqlDbType.NVarChar);
            _sqlCommand.Parameters["Contact"].Value = aSupplier.Contact;
            _sqlCommand.Parameters.Add("ContactPerson", SqlDbType.NVarChar);
            _sqlCommand.Parameters["ContactPerson"].Value = aSupplier.ContactPerson;
            int rowAffected = _sqlCommand.ExecuteNonQuery();
            DatabaseConnection.sqlConnection.Close();
            return rowAffected;
        }
        public List<Supplier> SearchSupplier(string searchItem)
        {
            List<Supplier> suppliers = new List<Supplier>();
            Connect();
            query = "SELECT * FROM Suppliers WHERE Name LIKE '%" + searchItem + "%' OR Contact LIKE '%" + searchItem + "%' OR Email LIKE '%" + searchItem + "%' ";
            _sqlCommand = new SqlCommand {CommandText = query, Connection = DatabaseConnection.sqlConnection};
            _sqlDataReader = _sqlCommand.ExecuteReader();
            while (_sqlDataReader.Read())
            {
                Supplier aSupplier = new Supplier
                {
                    Id = Convert.ToInt32(_sqlDataReader["Id"]),
                    Code = _sqlDataReader["Code"].ToString(),
                    Name = _sqlDataReader["Name"].ToString(),
                    Address = _sqlDataReader["Address"].ToString(),
                    Email = _sqlDataReader["Email"].ToString(),
                    Contact = _sqlDataReader["Contact"].ToString(),
                    ContactPerson = _sqlDataReader["ContactPerson"].ToString()
                };
                ;
                suppliers.Add(aSupplier);
            }
            DatabaseConnection.sqlConnection.Close();
            return suppliers;
        }
    }
}
