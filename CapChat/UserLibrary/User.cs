﻿using System.Security.Cryptography;
using System.Text;

namespace UserLibrary
{
    public class User
    {
        private CryptoHelper _cHelper;
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
        }
    }

  
}