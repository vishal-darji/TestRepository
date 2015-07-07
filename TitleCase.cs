using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GithubTest
{
    public class TitleCase
    {
        public string ConvertString(string text)
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


                builder.Append(char.ToUpper(s.ToCharArray()[0]) + s.Substring(1).ToLower());
            }
            return builder.ToString();
        }
    }

    public class TitleCaseClient
    {

        public static void Process()
        {
            TitleCase titleCase = new TitleCase();
            Console.WriteLine(titleCase.ConvertString(Console.ReadLine()));
            Console.Read();
        }
    }
}
