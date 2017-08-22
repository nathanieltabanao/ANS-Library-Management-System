using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;

namespace ANS_Library_Management_System
{
    class encryption_algorithm
    {
        public string HashPass(string password, string salt)
        {
            SHA256Managed sha = new SHA256Managed();
            //compute has from the bytes of text

            sha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(salt+salt+password));
            //get hash result after computation
            

            byte[] result = sha.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                // change it into 2 hex digits
                //for each type

                strBuilder.Append(result[i].ToString("x2"));
            }
            return strBuilder.ToString();
        }
    }
}
