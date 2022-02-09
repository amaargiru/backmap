int[] arr = { 11, 120, 12, 130, 0, -1000, int.MaxValue, 0, 1_000_000_000, 0xFF, int.MinValue, 0, 100 };

int len = arr.Length;

for (int i = 0; i < len - 1; i++)
{
   for (int j = 0; j < len - i - 1; j++)
   {
      if (arr[j] > arr[j + 1])
      {
         (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
      }
   }
}

Array.ForEach(arr, Console.WriteLine);

Console.ReadKey();