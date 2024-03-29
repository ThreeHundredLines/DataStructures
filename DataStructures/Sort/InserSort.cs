﻿namespace DataStructures
{
    public class InserSort
    {
        public static void Sort(int[] arr)
        {
            var n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                var e = arr[i];
                int j;
                for (j = i; j > 0; j--)
                {
                    if (e < arr[j - 1])
                        arr[j] = arr[j - 1];
                    else
                        break;
                }
                arr[j] = e;
            }
        }

        //对arr[l...r]的范围使用插入排序进行排序
        public static void Sort1(int[] arr, int l, int r)
        {
            for (int i = l + 1; i <= r; i++)
            {
                var e = arr[i];
                int j;
                for (j = i; j > l; j--)
                {
                    if (e < arr[j - 1])
                        arr[j] = arr[j - 1];
                    else
                        break;
                }
                arr[j] = e;
            }
        }
    }
}
