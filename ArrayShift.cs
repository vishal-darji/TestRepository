using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GithubTest
{
    public class ArrayShift
    {
        public Int16[] ArrayShiftRight(Int16[] myArray)
        {
            Int16 temp=0,temp1=0;

            for (int i = 0; i < myArray.Length - 1; i++)
            {
                //stroing next element and overwriting next with current
                if (temp > 0)
                {
                    temp1 = myArray[i + 1];
                    myArray[i + 1] = temp;
                    temp = temp1;
                }
                else
                {
                    temp = myArray[i + 1];
                    myArray[i + 1] = myArray[i];
                    myArray[i] = myArray[myArray.Length - 1];
                }
                
 
                //if (i == myArray.Length - 1)
                //{
                //    myArray[0] = myArray[myArray.Length - 1];
                //}
                //else if (i == 0)
                //{
                //    temp = myArray[i + 1];
                //    myArray[i + 1] = myArray[i];
                //}
                //else
                //{
                //    temp = myArray[i + 1];
                //    myArray[i + 1] = myArray[i];
                //}
                

             
            }
            return myArray;

        }
        public Int16[] ArrayShiftLeft(Int16[] myArray)
        {
            Int16 temp = myArray[myArray.Length - 1], temp1 = 0;
                       
            for (int i = myArray.Length - 1; i >= 0 ; i--)
            {
                //stroing next element and overwriting next with current
                if (i == 0)
                {
                    myArray[myArray.Length - 1] = temp;
                }
                else
                {
                    
                        temp1 = myArray[i - 1];
                        myArray[i - 1] = temp;
                        temp = temp1;
                    
                    
                    
                }


            }


            return myArray;

        }
        
    }
    public class ArrayShiftClient
    {

        public static void Process()
        {
            Int16[] myArray = { 1, 2, 3, 4, 5, 6 };
            ArrayShift reverse = new ArrayShift();
            //One shift to right
            Console.WriteLine(Environment.NewLine + "shifting to right" + Environment.NewLine);
            foreach (int i in reverse.ArrayShiftRight(myArray))
            {
                Console.Write(string.Format("{0} {1}", i.ToString()," "));
            }
            Console.WriteLine(Environment.NewLine + "shifting to left" + Environment.NewLine);
            Int16[] myArray1 = { 1, 2, 3, 4, 5, 6 };
            
            foreach (int i in reverse.ArrayShiftLeft(myArray1))
            {
                Console.Write(string.Format("{0} {1}", i.ToString(), " "));
            }



        }
    }
}
