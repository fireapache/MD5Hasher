using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace MD5Hasher
{
    class Program
    {
        static void Main(string[] args)
        {
            String str;
            byte[] hash;
            MD5 hasher;

            str = Console.ReadLine();
            hasher = MD5.Create();
            hash = Encoding.UTF8.GetBytes(str);
            hash = hasher.ComputeHash(hash);

            str = "";

            foreach (byte b in hash)
            {
                str = str + b.ToString("x2");
            }

            Console.WriteLine(str);
        }
    }
}
