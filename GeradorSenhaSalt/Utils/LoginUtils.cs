using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;

namespace EscritorioVirtual.Api.Utils
{
    public class LoginUtils
    {
        public static string GerarHash(string senha, byte[] salt)
        {
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: senha!,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));

            return hashed;
        }

        public static string ToString(byte[] salt)
        {
            return string.Join(',', salt);
        }

        public static byte[] ToByte(string salt)
        {
            var strs = salt.Split(',');
            var bytes = new byte[strs.Length];
            for (int i = 0; i < strs.Length; i++)
            {
                bytes[i] = Convert.ToByte(strs[i]);
            }
            return bytes;
        }

        public static byte[] GerarSalt()
        {
            return RandomNumberGenerator.GetBytes(128 / 8);
        }
    }
}
