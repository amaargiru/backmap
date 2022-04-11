namespace LearnSorting;

internal static class Quick
{
   internal static int[] Sort(int[] randomArray)
   {
      var arr = (int[])randomArray.Clone();

      QuickSort(arr, 0, arr.Length - 1);

      return arr;
   }

   private static int[] QuickSort(int[] a, int i, int j)
   {
      if (i < j)
      {
         int q = Partition(a, i, j);
         a = QuickSort(a, i, q);
         a = QuickSort(a, q + 1, j);
      }
      return a;
   }

   private static int Partition(int[] a, int p, int r)
   {
      int x = a[p];
      int i = p - 1;
      int j = r + 1;
      while (true)
      {
         do
         {
            j--;
         }
         while (a[j] > x);
         do
         {
            i++;
         }
         while (a[i] < x);
         if (i < j)
         {
            int tmp = a[i];
            a[i] = a[j];
            a[j] = tmp;
         }
         else
         {
            return j;
         }
      }
   }
}
