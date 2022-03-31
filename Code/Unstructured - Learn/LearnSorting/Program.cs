using System;

namespace LearnSorting
{
   class Program
   {
      static readonly int ArrayLength = 10000;
      static readonly Random Rnd = new Random();

      static void Main()
      {
         int[] randomArray, sortedArray;

         randomArray = GetRandomArray();

         sortedArray = BubbleSort(randomArray);
         sortedArray = MergeSort(randomArray);
//         sortedArray = QuickSort(randomArray);
      }

      public static int[] GetRandomArray()
      {
         int[] randomArray = new int[ArrayLength];

         for (int i = 0; i < ArrayLength; i++)
         {
            randomArray[i] = Rnd.Next();
         }

         return randomArray;
      }

      public static int[] BubbleSort(int[] randomArray)
      {
         int[] sortedArray = (int[])randomArray.Clone();
         int length = sortedArray.Length;
         int temp;

         for (int i = 0; i < length - 1; i++)
            for (int j = 0; j < length - i - 1; j++)
               if (sortedArray[j] > sortedArray[j + 1])
               {
                  temp = sortedArray[j];
                  sortedArray[j] = sortedArray[j + 1];
                  sortedArray[j + 1] = temp;
               }

         return sortedArray;
      }

      public static int[] MergeSort(int[] randomArray)
      {
         int[] sortedArray = (int[])randomArray.Clone();

         Sort(sortedArray);

         return sortedArray;
      }

      private static void Sort(int[] array)
      {
         int length = array.Length;

         if (length <= 1)
         {
            return;
         }

         int leftSize = length / 2;
         int rightSize = length - leftSize;
         int[] leftArray = new int[leftSize];
         int[] rightArray = new int[rightSize];

         Array.Copy(array, 0, leftArray, 0, leftSize);
         Array.Copy(array, leftSize, rightArray, 0, rightSize);

         Sort(leftArray);
         Sort(rightArray);

         Merges(array, leftArray, rightArray);
      }

      private static void Merges(int[] array, int[] leftArray, int[] rightArray)
      {
         int leftIndex = 0;
         int rightIndex = 0;
         int targetIndex = 0;

         int remaining = leftArray.Length + rightArray.Length;

         while (remaining > 0)
         {
            if (leftIndex >= leftArray.Length)
            {
               array[targetIndex] = rightArray[rightIndex++];
            }
            else if (rightIndex >= rightArray.Length)
            {
               array[targetIndex] = leftArray[leftIndex++];
            }
            else if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) < 0)
            {
               array[targetIndex] = leftArray[leftIndex++];
            }
            else
            {
               array[targetIndex] = rightArray[rightIndex++];
            }

            targetIndex++;
            remaining--;
         }
      }

      public static int[] QuickSort(int[] randomArray)
      {
         int[] sortedArray = new int[ArrayLength];

         return sortedArray;
      }
   }
}