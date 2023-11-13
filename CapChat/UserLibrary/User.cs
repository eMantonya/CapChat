using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using System;
using System.IO;



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
        public bool Stored = false;
        public User() { }

        //constructor called during registration
        public User(string firstName, string lastName, string email, string password)
        {
            _salt = RandomNumberGenerator.GetBytes(64);
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            _passwordHash = _cHelper.ComputeHash(password, this._salt);
            this.StoreUser();
        }

        //constructor called during login
        public User(string firstName, string lastName, string email, byte[]salt, byte[]passHash)
        {
            _salt = salt;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            _passwordHash = passHash;
        }

        private void StoreUser()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<User>().Build();
            string connString = config["connString"];
            try
            {
                using (var connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string sql = @"INSERT INTO [User] (UserFirstName, UserLastName, UserEmail, UserPassHash, UserSalt) VALUES (@first, @last, @email, @hash, @salt)";

                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@first", FirstName);
                        command.Parameters.AddWithValue("@last", LastName);
                        command.Parameters.AddWithValue("@email", Email);
                        command.Parameters.AddWithValue("@hash", _passwordHash);
                        //command.Parameters.AddWithValue("@avatar", Avatar);
                        command.Parameters.AddWithValue("@salt", _salt);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            this.Stored = true;
                        }
                    }
                }
            }
            catch
            {
                this.Stored = false;
            }
        }

        public bool UpdateUserName(string firstName, string lastName)
        {
            var config = new ConfigurationBuilder().AddUserSecrets<User>().Build();
            string connString = config["connString"];
            try
            {
                using (var connection = new SqlConnection(connString))
                {
                    connection.Open();

                    string sql = @"UPDATE [User] 
                        SET UserFirstName = @first, UserLastName = @last 
                        WHERE UserEmail = @email";


                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@first", firstName);
                        command.Parameters.AddWithValue("@last", lastName);
                        command.Parameters.AddWithValue("@email", this.Email);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            this.FirstName = firstName;
                            this.LastName = lastName;
                            return true;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
            return false;
        }

        public bool VerifyPassword(string password)
        {
            var input = Convert.ToHexString(_cHelper.ComputeHash(password, this._salt));
            var oldPass = Convert.ToHexString(this._passwordHash);
            //byte[] inputPassHash = _cHelper.ComputeHash(password, this._salt);
            if (string.Equals(input, oldPass))
            {
                return true;
                
            }
            return false;
        }
        public bool UpdateUserPassword(string pass)
        {
            byte[] newPassHash = _cHelper.ComputeHash(pass, this._salt);
            this._passwordHash = newPassHash;

            var config = new ConfigurationBuilder().AddUserSecrets<User>().Build();
            string connString = config["connString"];
            using (var connection = new SqlConnection(connString))
            {
                connection.Open();

                string sql = @"UPDATE [User] SET UserPassHash = @hash WHERE UserEmail = @email";

                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("hash", newPassHash);
                    command.Parameters.AddWithValue("@email", this.Email);
                    
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        return true;
                    }
                }
            }
            return false;

        }
    }

    

  
}