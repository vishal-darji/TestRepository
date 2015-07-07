using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GithubTest
{
   public class FindingRemovingDuplicates
    {
       public Int16[] FindingDuplicates(Int16[] myArray)
       {
           
           for (int i = 0; i <= myArray.Length - 1; i++)
           {
               for (int x = 0; x <= myArray.Length - 1; x++)
               {
                   if (myArray[x] == myArray[i] && i != x)
                   { 
                        //remove from array
                       myArray = removeFromArray(myArray, x);
                       i = -1;
                       break;

                   }
               }
           }
           return myArray;

       }


       private Int16[] removeFromArray(Int16[] myArray, int position)
       {
           Int16[] myNewArray = new Int16[myArray.Length - 1];
           int newArrayCount = 0;
           for (int x = 0; x <= myArray.Length - 1; x++)
           {

               if (x == position)
               {
                   continue;
               }
               else
               {
                   myNewArray[newArrayCount] = myArray[x];
                   newArrayCount += 1;
               }
           }
           myArray = null;
           return myNewArray;
       
       }
    }

   public class DuplicateClient
   {

       public static void Process()
       {
           Int16[] myArray = { 1, 2, 3, 1, 5, 2, 1,2,3,4,5,6,7,8,12,3,4,5,6,7,8 };
           FindingRemovingDuplicates dup = new FindingRemovingDuplicates();
           
           foreach (int i in dup.FindingDuplicates(myArray))
           {
               Console.Write(string.Format("{0} {1}", i.ToString(), " "));
           }
           
           



       }
   }

}
