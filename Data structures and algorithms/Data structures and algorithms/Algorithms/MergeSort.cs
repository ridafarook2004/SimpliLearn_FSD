using System;
using System.Collections.Generic;
using System.Text;

namespace Data_structures_and_algorithms.Algorithms
{
    class MergeSort
    {
        public void Do()
        {
            int[] arr1 = { 92, 23, 41, 7, 32, 61, 12, 3 };

            Console.WriteLine($"Before sorting  ..  ");
            foreach (int num in arr1)
            {
               
                Console.Write($"{num }  ");
            }
            // function call 
            Divide(arr1, 0, arr1.Length);

            Console.WriteLine($"After sorting  ..  ");
            foreach (int num1 in arr1)
            {
               
                Console.Write($" {num1 }  ");
            }

        }

        public void Divide(int[] arr1, int left, int right) // left = 0 and right = 8 (total number of elements in the array)
        {
            if (left < right)
            {
                // 1. Find the mid element

                int mid = (left + right) / 2;

                // 2. Divide left array (create pointers for left array)
                Divide(arr1, left, mid);

                // 3. Divide right array (create pointers for right array)
                Divide(arr1,mid+1, right);

                //4. Merge and sort array
                MergeAndSort(arr1, left, right, mid);



            }
        }

        public void MergeAndSort( int[] arr1, int left, int right, int mid)
        {
            // 1. Create left and right array based on pointers

            // 1.1  Lenght of arrays
            int leftArrayLenth =mid - left +1; // 4 - 0+1  = 5 - is this correct
            int rightArrayLenth = right - mid +1 ; // 8 -4    = 4 elements
                                                //  Console.WriteLine( $" leftArrayLenth is : {leftArrayLenth} ");


            //1.2 create left and right arrays

            int[] arrLeft = new int[leftArrayLenth];
            int[] arrRight = new int[rightArrayLenth];

            int i, j;
            for ( i =0; i < leftArrayLenth; i++)
            {
                arrLeft[i] = arr1[left + i];
            }

            for ( j = 0; j < rightArrayLenth; j++)
            {
                arrRight[j] = arr1[mid + 1 +j];     // INDEX OUTSIDE THE BOUNDS OF THE ARRAY EXCEPTION
            }

            i = 0; j = 0;
            int k = left;
            while ( i < leftArrayLenth &&  j < rightArrayLenth)
                { 
                     if (arrLeft[i] < arrRight[j])
                    {
                        arr1[k] = arrLeft[i];
                        i++;
                    }
                     else
                    {
                        arr1[k] = arrRight[i];
                        j++;    
                    }

                }

            while (i < leftArrayLenth)
            {
                arr1[k] = arrLeft[i];
                i++;
                k++;
            }
            while (j < rightArrayLenth)
            {
                arr1[k] = arrRight[j];
                j++;
                k++;
            }

        }

    }
}
