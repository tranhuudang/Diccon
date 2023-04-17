using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;

namespace Diccon
{
    public class Sha256Encrypt
    {
        private string _key;
        private int _salt = 100;

        public Sha256Encrypt(string password)
        {
            _key = password;
        }
        public string Hash()
        {
            int intValue = _salt; // pepper
            byte[] intBytes = BitConverter.GetBytes(intValue);
            if (BitConverter.IsLittleEndian)
                Array.Reverse(intBytes);
            byte[] resultSalt = intBytes;
            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: _key,
                salt: resultSalt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
            return hashed;
        }
    }
}
