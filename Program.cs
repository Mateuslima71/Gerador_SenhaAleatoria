using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();
            int length = 10;

            string randowchars = GenerateRandomChars(length);

            Console.WriteLine("Caracteres aleatorio: " + randowchars);
            Console.ReadLine();

        }

        static string GenerateRandomChars(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+{}[]|;:<>,.?/~";
            Random random = new Random();
            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = chars[random.Next(chars.Length)];
            }
            return new string(result);
            
        }

        
    }
}   