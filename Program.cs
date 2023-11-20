using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortAssignment16_Day11
{
    internal class Program
    {
        
            public static void QuickSort(int[] arr)
            {
                QuickSort(arr, 0, arr.Length - 1);
            }
            private static void QuickSort(int[] arr, int left, int right)
            {
                if (left < right)
                {
                    int pivotIndex = Partition(arr, left, right);
                    QuickSort(arr, left, pivotIndex - 1);
                    QuickSort(arr, pivotIndex + 1, right);
                }
            }

            private static int Partition(int[] arr, int left, int right)
            {
                int pivot = arr[right];
                int i = left - 1;
                for (int j = left; j < right; j++)
                {
                    if (arr[j] < pivot)
                    {
                        i++;
                        Swap(arr, i, j);
                    }
                }
                Swap(arr, i + 1, right);
                return i + 1;
            }

            private static void Swap(int[] arr, int i, int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }

            public static void IsSorted(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                        Console.WriteLine("The given array is not sorted");
                }
                Console.WriteLine("The array is  sorted");
            }

            public static void Print(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine("\n");
            }
            static void Main(string[] args)
            {
                int[] arr = { 9, -3, 5, 2, 6, 8, -6, 1, 3 };
                Console.WriteLine("Original Array");
                Print(arr);
                Stopwatch sw = new Stopwatch();
                sw.Start();
                QuickSort(arr);
                sw.Stop();
                Console.WriteLine("After Quick Sort");
                Print(arr);
                Console.WriteLine($"Array Size {arr.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");
                IsSorted(arr);
                Console.WriteLine();
                int[] arr1 = { 2, 3, 88, 44, 21, 90, 7, 87, 91, 100, 11, 23, 36, 6, 10, 13, 12, 9, 1, 22 };
                Console.WriteLine("Original Array 1");
                Print(arr1);
                sw.Start();
                QuickSort(arr1);
                sw.Stop();
                Console.WriteLine("After Quick Sort Array 1");
                Print(arr1);
                Console.WriteLine($"Array Size {arr1.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");
                IsSorted(arr1);
                Console.WriteLine();
                int[] arr2 = { 13, 25, 3, 49, 59, 50, 36, 27, 75, 48, 68, 98, 12, 45, 3, 25, 38, 96, 99 , 98, 37, 12, 22, 44, 66, 79, 93, 91, 25, 37, 86, 43, 20};
                Console.WriteLine("Original Array 2");
                Print(arr2);
                sw.Start();
                QuickSort(arr2);
                sw.Stop();
                Console.WriteLine("After Quick Sort Array 2");
                Print(arr2);
                Console.WriteLine($"Array Size {arr2.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");
                IsSorted(arr2);
                Console.WriteLine();
                int[] arr3 = { 6, 10, 13, 12, 44, 58, 88, 27, 68, 98, 12, 45, 67, 87, 54, 69 ,96 ,84 ,27 ,84 , 1, 3, 25, 38, 96, 99, 48, 86, 48, 13, 25, 3, 49, 59, 50, 36, 27, 75, 48, 95};
                Console.WriteLine("Original Array 3");
                Print(arr3);
                sw.Start();
                QuickSort(arr3);
                sw.Stop();
                Console.WriteLine("After Quick Sort Array 3");
                Print(arr3);
                Console.WriteLine($"Array Size {arr3.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");
                IsSorted(arr3);
                Console.ReadKey();
            }
        }
    }