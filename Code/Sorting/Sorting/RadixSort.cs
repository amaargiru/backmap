namespace LearnSorting
{
   internal static class Radix
   {
      internal static int[] Sort(int[] randomArray)
      {
         var sortedArray = (int[])randomArray.Clone();

         int i, j;
         int[] tmp = new int[sortedArray.Length];
         for (int shift = 31; shift > -1; --shift)
         {
            j = 0;
            for (i = 0; i < sortedArray.Length; ++i)
            {
               bool move = (sortedArray[i] << shift) >= 0;
               if (shift == 0 ? !move : move)
                  sortedArray[i - j] = sortedArray[i];
               else
                  tmp[j++] = sortedArray[i];
            }
            Array.Copy(tmp, 0, sortedArray, sortedArray.Length - j, j);
         }

         return sortedArray;
      }
   }
}