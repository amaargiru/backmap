using System.Runtime.CompilerServices;

int[] a = { 800, 11, 50, 771, 649, 770, 240, 9 };

for (int i = 1; i <= a.Length - 1; ++i)
{
   for (int j = 0; j < a.Length - i; ++j)
   {
      if (a[j] > a[j + 1])
      {
         Swap(ref a[j], ref a[j + 1]);
      }
   }
}

[MethodImpl(MethodImplOptions.AggressiveInlining)]
static void Swap(ref int x, ref int y)
{
   var temp = x;
   x = y;
   y = temp;
}