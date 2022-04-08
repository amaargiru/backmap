namespace LearnSorting;

static class Merge
{
   public static int[] Sort(int[] randomArray)
   {
      var sortedArray = (int[])randomArray.Clone();

      MergeSort(sortedArray);

      return sortedArray;
   }

   private static void MergeSort(int[] array)
   {
      var length = array.Length;

      if (length <= 1)
      {
         return;
      }

      var leftSize = length / 2;
      var rightSize = length - leftSize;
      var leftArray = new int[leftSize];
      var rightArray = new int[rightSize];

      Array.Copy(array, 0, leftArray, 0, leftSize);
      Array.Copy(array, leftSize, rightArray, 0, rightSize);

      MergeSort(leftArray);
      MergeSort(rightArray);

      Merges(array, leftArray, rightArray);
   }

   private static void Merges(int[] array, int[] leftArray, int[] rightArray)
   {
      int leftIndex = 0, rightIndex = 0, targetIndex = 0;

      var remaining = leftArray.Length + rightArray.Length;

      while (remaining > 0)
      {
         if (leftIndex >= leftArray.Length)
            array[targetIndex] = rightArray[rightIndex++];
         else if (rightIndex >= rightArray.Length)
            array[targetIndex] = leftArray[leftIndex++];
         else if (leftArray[leftIndex].CompareTo(rightArray[rightIndex]) < 0)
            array[targetIndex] = leftArray[leftIndex++];
         else
            array[targetIndex] = rightArray[rightIndex++];

         targetIndex++;
         remaining--;
      }
   }
}
