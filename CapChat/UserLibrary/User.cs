using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace UserLibrary
{
    public class User
    {
        private CryptoHelper _cHelper = new CryptoHelper();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        private byte[] _passwordHash;
        private byte[] _salt;

        public User(string firstName, string lastName, string email, string password)
        {
            _salt = RandomNumberGenerator.GetBytes(64);
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            _passwordHash = _cHelper.ComputeHash(password, this._salt);
            this.StoreUser();
        }

        private void StoreUser()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<User>().Build();
            string connString = config["connString"];

            using (var connection = new SqlConnection(connString))
            {
                connection.Open();

                string sql = @"INSERT INTO [User] (UserFirstName, UserLastName, UserEmail, UserPassHash) VALUES (@first, @last, @email, @hash)";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@first", FirstName);
                    command.Parameters.AddWithValue("@last", LastName);
                    command.Parameters.AddWithValue("@email", Email);
                    command.Parameters.AddWithValue("@hash", _passwordHash);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }

        }
    }

  
}