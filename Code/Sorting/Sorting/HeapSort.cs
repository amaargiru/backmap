namespace LearnSorting;

internal static class Heap
{
   internal static int[] Sort(int[] randomArray)
   {
      var sortedArray = (int[])randomArray.Clone();

      int n = sortedArray.Length;

      // Build heap (rearrange array)
      for (int i = n / 2 - 1; i >= 0; i--)
         heapify(sortedArray, n, i);

      // One by one extract an element from heap
      for (int i = n - 1; i > 0; i--)
      {
         // Move current root to end
         int temp = sortedArray[0];
         sortedArray[0] = sortedArray[i];
         sortedArray[i] = temp;

         // call max heapify on the reduced heap
         heapify(sortedArray, i, 0);
      }

      return sortedArray;
   }

   private static void heapify(int[] arr, int n, int i)
   {
      int largest = i; // Initialize largest as root
      int l = 2 * i + 1; // left = 2*i + 1
      int r = 2 * i + 2; // right = 2*i + 2

      // If left child is larger than root
      if (l < n && arr[l] > arr[largest])
         largest = l;

      // If right child is larger than largest so far
      if (r < n && arr[r] > arr[largest])
         largest = r;

      // If largest is not root
      if (largest != i)
      {
         int swap = arr[i];
         arr[i] = arr[largest];
         arr[largest] = swap;

         // Recursively heapify the affected sub-tree
         heapify(arr, n, largest);
      }
   }
}
