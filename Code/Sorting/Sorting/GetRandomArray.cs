namespace LearnSorting;

static class RandomArray
{
   static readonly Random Rnd = new();

   public static int[] GetRandomArray(int ArrayLength)
   {
      var randomArray = new int[ArrayLength];

      for (var i = 0; i < ArrayLength; i++)
      {
         randomArray[i] = Rnd.Next();
      }

      return randomArray;
   }
}