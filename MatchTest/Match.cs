using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTest
{
   public class Match
    {
        public static String binary;
        protected static String binary1 = "Hello";
        protected static String binary2 = "xyz";

        static void Main(string[] args)
        {
            if (test(null) == true)
            {
                Console.WriteLine("You match");
            }
            else
            {
                Console.WriteLine("Who are you?");
            }

        }

        public static bool test(String input)
        {

            Console.WriteLine("Enter the correct phrase (This program is caps sensitive):");

            if (input == null)
            {
                binary = Console.ReadLine();
            }
            else
            {
                binary = input;
            }

            char[] textArray = binary.ToCharArray();
            char[] textArray1 = binary1.ToCharArray();
            char[] textArray2 = binary2.ToCharArray();

            if (xor(textArray, textArray2).Equals(xor(textArray1, textArray2)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static String xor(char[] a, char[] b)
        {
            int length = Math.Min(a.Length, b.Length);
            int[] result = new int[length];
            String str = "";
            for (int i = 0; i < length; i++)
            {
                result[i] = (a[i] ^ b[i]);
                str = str + "" + result[i];
            }
            return str;
        }
    }
}
