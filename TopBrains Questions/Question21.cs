using System;

class Program
{
    // Generic Merge Method
    public static T[] MergeSortedArrays<T>(T[] a, T[] b) where T : IComparable<T>
    {
        int n = a.Length;
        int m = b.Length;

        T[] result = new T[n + m];

        int i = 0, j = 0, k = 0;

        // Merge both arrays
        while (i < n && j < m)
        {
            if (a[i].CompareTo(b[j]) <= 0)
            {
                result[k++] = a[i++];
            }
            else
            {
                result[k++] = b[j++];
            }
        }

        // Remaining elements
        while (i < n)
        {
            result[k++] = a[i++];
        }

        while (j < m)
        {
            result[k++] = b[j++];
        }

        return result;
    }

    // Main Method (for testing)
    static void Main()
    {
        int[] a = { 1, 3, 5 };
        int[] b = { 2, 4, 6 };

        var merged = MergeSortedArrays(a, b);

        Console.WriteLine("Merged Array:");
        foreach (var item in merged)
        {
            Console.Write(item + " ");
        }
    }
}