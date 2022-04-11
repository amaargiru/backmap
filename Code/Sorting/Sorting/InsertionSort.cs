namespace LearnSorting;

internal static class Insertion
{
   internal static int[] Sort(int[] randomArray)
   {
      var sortedArray = (int[])randomArray.Clone();

      int n = sortedArray.Length;
      for (int i = 1; i < n; ++i)
      {
         int key = sortedArray[i];
         int j = i - 1;

         // Move elements of arr[0..i-1],
         // that are greater than key,
         // to one position ahead of
         // their current position
         while (j >= 0 && sortedArray[j] > key)
         {
            sortedArray[j + 1] = sortedArray[j];
            j = j - 1;
         }
         sortedArray[j + 1] = key;
      }

      return sortedArray;
   }
}
