using System.Data.SqlTypes;
using System.Security.Cryptography;
using System.Text;

namespace LogicLayer
{
    public class PasswordHashing
    {
        const int keySize = 64;
        const int iterations = 100000; //in the real world it is reccomended to at a minimum use 100k and for high risk/security more than 1m
        HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA256;

        public string CreateNewHash(string password, out string salt)
        {
            var saltBytes = RandomNumberGenerator.GetBytes(keySize);

            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                saltBytes,
                iterations,
                HashAlgorithmName.SHA256,
                keySize
                );
            salt = Convert.ToHexString(saltBytes);
            return Convert.ToHexString(hash);
        }

        public string HashPassword(string password, string salt)
        {
            var hash = Rfc2898DeriveBytes.Pbkdf2(
                Encoding.UTF8.GetBytes(password),
                Convert.FromHexString(salt),
                iterations,
                HashAlgorithmName.SHA256,
                keySize
                );
            return Convert.ToHexString(hash);
        }
    }
}