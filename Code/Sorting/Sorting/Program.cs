namespace LearnSorting;

class Program
{
   static readonly int ArrayLength = 10000;

   static void Main()
   {
      var randomArray = RandomArray.GetRandomArray(ArrayLength);

      var bubbleSortedArray = Bubble.Sort(randomArray);
      var quickSortedArray = Quick.Sort(randomArray);
      var mergeSortedArray = Merge.Sort(randomArray);
      var heapSortedArray = Heap.Sort(randomArray);
      var insertionSortedArray = Insertion.Sort(randomArray);
   }
}
