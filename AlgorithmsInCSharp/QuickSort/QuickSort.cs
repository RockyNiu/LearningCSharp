using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsInCSharp
{
    class QuickSort
    {
        static void Main(string[] args)
        {
            QuickSortSolution solution = new QuickSortSolution();
            int[] A = { 1, 2, 4, 3, 5 };
            int[] B = solution.Sort(A);
            for (int i = 0; i < B.Length; i++)
            {
                Console.Write(B[i] + " ");
            }
        }
    }

    public class QuickSortSolution
    {

        public int[] Sort(int[] A)
        {
            DoSorting(A, 0, A.Length - 1);
            return A;
        }

        void DoSorting(int[] A, int left, int right)
        {
            if (right > left)
            {
                int pivot = Patition(A, left, right);
                DoSorting(A, left, pivot - 1);
                DoSorting(A, pivot + 1, right);
            }
        }

        int Patition(int[] A, int left, int right)
        {
            Random random = new Random();
            int pivot = left + random.Next(right - left + 1);
            int pivotValue = A[pivot];
            Swap(A, pivot, right);

            int pivotNew = left;
            for (int i = left; i < right; i++)
            {
                if (A[i] < pivotValue)
                {
                    Swap(A, pivotNew, i);
                    pivotNew++;
                }
            }
            Swap(A, pivotNew, right);
            return pivotNew;
        }

        void Swap(int[] A, int a, int b)
        {
            int temp = A[a];
            A[a] = A[b];
            A[b] = temp;
        }
    }
}
