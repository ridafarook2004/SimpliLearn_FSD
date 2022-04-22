using System;
using System.Collections.Generic;
using System.Text;

namespace Data_structures_and_algorithms.Algorithms
{
    internal class BinarySearch
    {
        static int[] arr2 = { 100, 200, 300, 400, 500 };
        public static void Do()
        {
            //  step 1: Find the midelement
            int result;

            result = binarySearch(arr2, 0, arr2.Length - 1, 400);
            Console.WriteLine(" Element at the result :" + result);

        }
        
        //method return an int
        public static int binarySearch(int[] arr2, int left, int right,  int num)
        {
            Console.WriteLine( $" Values passed are : {left} ,{right} ,{num}");
            if ( right >= left ) // breakpoint since there is a recursive call
          {
                // step 1: find the mid element
               int  mid = (left + right) / 2;

                Console.WriteLine($" Mid point is : {mid}, { arr2[mid]} ");

                // check if the mid element is the number (to be searched)
                if   ( arr2[mid] == num )
                {
                    return mid;
                }

                // check if the mid element is less than the number
                if  (  num  < arr2[mid] )
                {
                    // Recursive calling 
                    return binarySearch(arr2, left, mid - 1, num);
                }

                if  ( num > arr2[mid])
                {
                    // Recursive calling 
                    return binarySearch(arr2,  mid + 1, right , num);
                }               
                

            }
            //Rerurn -1 if num is  not found
            return -1;
        }
    }
}
