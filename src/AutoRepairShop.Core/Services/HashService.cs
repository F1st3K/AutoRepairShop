using System;
using System.Security.Cryptography;
using System.Text;

namespace AutoRepairShop.Core.Services
{
    public class HashService
    {
        public string Hash(string pwd)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(pwd);
                byte[] hashedBytes = sha256Hash.ComputeHash(bytes);
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }
    }
}
