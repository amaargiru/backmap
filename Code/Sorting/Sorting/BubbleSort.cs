namespace LearnSorting;

static class Bubble
{
   public static int[] Sort(int[] randomArray)
   {
      var arr = (int[])randomArray.Clone();
      var len = arr.Length;

      for (var i = 0; i < len - 1; i++)
      {
         for (var j = 0; j < len - i - 1; j++)
         {
            if (arr[j] > arr[j + 1])
            {
               (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
         }
      }

      return arr;
   }
}
