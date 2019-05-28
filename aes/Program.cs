using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input string: ");
            string source = Console.ReadLine();
            byte[,] key = { { 0x2b, 0x28, 0xab, 0x09 }, { 0x7e, 0xae, 0xf7, 0xcf }, { 0x15, 0xd2, 0x15, 0x4f }, { 0x16, 0xa6, 0x88, 0x3c } };
            AES aes = new AES(key);

            byte[] encryptedArray = aes.Encrypt(source);

            for (int i = 0; i < encryptedArray.Length; i++)
                Console.Write(Convert.ToString(encryptedArray[i], 16) + " ");

            Console.WriteLine();
            string decryptedString = aes.Decrypt(encryptedArray);
            Console.WriteLine(decryptedString);

            Console.ReadKey();
        }
    }
}
