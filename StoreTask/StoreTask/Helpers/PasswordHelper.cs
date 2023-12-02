using System;
using System.Security.Cryptography;
using System.Text;

namespace StoreTask.Helpers
{
    public static class PasswordHelper
    {
        public static string Hash(string password)
        {
            if (string.IsNullOrEmpty(password))
                return string.Empty;
            var sha512 = SHA512.Create();
            var bytes = sha512.ComputeHash(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(bytes).Replace("-", "");
        }
    }
}
