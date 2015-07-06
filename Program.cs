using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GithubTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.WriteLine(ConvertString(Console.ReadLine()));
            Console.Read();
        }

        public static string ConvertString(string text)
        {
            string[] str = text.Split(" ".ToCharArray());
            StringBuilder builder = new StringBuilder();
            foreach (string s in str)
            {
                Console.WriteLine(s);
                if (!string.IsNullOrEmpty(builder.ToString()))
                {
                    builder.Append(" ");
                    
                }
                //
                
                builder.Append( char.ToUpper(s.ToCharArray()[0]) + s.Substring(1).ToLower());
            }
            return builder.ToString();
        }
    }
}
