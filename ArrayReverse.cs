using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GithubTest
{
    public class ArrayReverse
    {
        public Int16[] ReverseArray(Int16[] myArray)
        {
            Int16 temp;
            
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                temp = myArray[i];
                myArray[i] = myArray[myArray.Length - 1 - i];
                myArray[myArray.Length - 1 - i] = temp;
                if (i == myArray.Length - 1 - i || i + 1 == myArray.Length - 1 - i)
                {
                    break;
                }
            }
            return myArray;
            
        }
        public char[] ReverseArray(char[] myArray)
        {
            char temp;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                temp = myArray[i];
                myArray[i] = myArray[myArray.Length - 1 - i];
                myArray[myArray.Length - 1 - i] = temp;
                if (i == myArray.Length - 1 - i || i + 1 == myArray.Length - 1 - i)
                {
                    break;
                }
            }
            return myArray;

        }
    }
    public class ArrayReverseClient
    {

        public static void Process()
        {
            Int16[] myArray = { 1, 2, 3, 4, 5, 6 };
            ArrayReverse reverse = new ArrayReverse();
            foreach (int i in reverse.ReverseArray(myArray))
            {
                Console.WriteLine(i);
            }

            Int16[]  myArray1 = { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int i in reverse.ReverseArray(myArray1))
            {
                Console.WriteLine(i);
            }

            char[] mycharArray1 = { 'a', 'b', 'c', 'd', 'e', 'f', 'g' };
            foreach (char i in reverse.ReverseArray(mycharArray1))
            {
                Console.WriteLine(i);
            }
        }
    }
}
