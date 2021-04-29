namespace Algorithms.Foundations
{
    public static class InsertionSort
    {
        public static void Sort(int[] collection)
        {
            for (var i = 1; i < collection.Length; i++)
            {
                var key = collection[i];
                var j = i - 1;

                while (j >= 0 && collection[j] > key)
                {
                    collection[j + 1] = collection[j];
                    j--;
                }

                collection[j + 1] = key;
            }
        }
    }
}