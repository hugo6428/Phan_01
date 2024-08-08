using System;

internal class Mergesort
{
    static void Main(string[] args)
    {
        int[] array = new int[] { 5, 2, 4, 6, 1, 3 };
        Console.WriteLine("Array:");
        PrintArray(array);

        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("\nArray after Merge Sort:");
        PrintArray(array);
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            Merge(array, left, mid, right);
        }
    }

    static void Merge(int[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        int i;
        int j;
        int k;

        for (i = 0; i < n1; i++)
        {
            L[i] = array[left + i];
        }

        for (j = 0; j < n2; j++)
        {
            R[j] = array[mid + j + 1];
        }

        i = 0; j = 0; k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                array[k] = L[i];
                i++;
            }
            else
            {
                array[k] = R[j];
                j++;
            }
            k++;
        }

        while (i < n1)
        {
            array[k] = L[i];
            i++;
            k++;
        }

        while (j < n2)
        {
            array[k] = R[j];
            j++;
            k++;
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}