using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UserLibrary
{
    public class CryptoHelper
    {
        const int keySize = 64;
        const int iterations = 350000;
        HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
        public byte[] ComputeHash(string input, byte[] salt)
        {

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(input),
                salt,
                iterations,
                hashAlgorithm,
                keySize);

            return hash;
        }

        public bool VerifyHash(string clearPassword, byte[] passwordHash, byte[] salt)
        {

            var hashToCompare = Rfc2898DeriveBytes.Pbkdf2(clearPassword, salt, iterations, hashAlgorithm, keySize);

            return CryptographicOperations.FixedTimeEquals(hashToCompare, passwordHash);
        }
    }

    public static class DbHelper
    {

        public static bool UserExists(string email)
        {
            bool recordsExists = false;
            var config = new ConfigurationBuilder().AddUserSecrets<User>().Build();
            string connString = config["connString"];

            using (var connection = new SqlConnection(connString))
            {
                connection.Open();
                //search DB for a user where the email matches, email is unique field
                string sql = @"SELECT * FROM [User] WHERE UserEmail = @email";
                using (var command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@email", email);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            recordsExists = true;
                        }
                    }
                }
            }
            return recordsExists;
         
        }
        public static User? RetrieveUser(string email, string inputPass)
        {
            //set up db connection
            var config = new ConfigurationBuilder().AddUserSecrets<User>().Build();
            string connString = config["connString"];
            try
            {
                using (var connection = new SqlConnection(connString))
                {
                    connection.Open();
                    //search DB for a user where the email matches, email is unique field
                    string sql = @"SELECT * FROM [User] WHERE UserEmail = @email";
                    using (var command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                //set variables to build the user object
                                string userFname = reader["UserFirstName"].ToString();
                                string userLname = reader["UserLastName"].ToString();
                                string userEmail = reader["UserEmail"].ToString();
                                byte[] userPassHash = (byte[])reader["UserPassHash"];
                                byte[] userSalt = (byte[])reader["UserSalt"];
                                var cryptoHelper = new CryptoHelper();

                                //if password matches, return the user--login is successful
                                if (cryptoHelper.VerifyHash(inputPass, userPassHash, userSalt))
                                {
                                    return new User(userFname, userLname, userEmail, userSalt, userPassHash);
                                }
                                
                            }
                        }
                        
                    }
                    return null;
                    
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
