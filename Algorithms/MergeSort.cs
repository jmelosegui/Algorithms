// Copyright (c) to jmelosegui. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public static class MergeSort
    {
        public static void Sort<T>(IList<T> list, SortDirection direction = SortDirection.Asc)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            int low = 0;
            int high = list.Count - 1;

            InternalSort(list, low, high, direction);
        }

        private static void InternalSort<T>(IList<T> list, int low, int high, SortDirection direction)
        {
            if (low < high)
            {
                int middle = (low + high) / 2;

                InternalSort(list, low, middle, direction);
                InternalSort(list, middle + 1, high, direction);
                InternalMerge(list, low, middle, high, direction);
            }
        }

        private static void InternalMerge<T>(IList<T> list, int low, int middle, int high, SortDirection direction)
        {
            T[] left = new T[middle - low + 1];
            T[] right = new T[high - middle];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = list[low + i];
            }

            for (int j = 0; j < right.Length; j++)
            {
                right[j] = list[middle + j + 1];
            }

            Func<int, int, bool> comparison;

            if (direction == SortDirection.Asc)
            {
                comparison = (leftItem, rightItem) => leftItem <= rightItem;
            }
            else
            {
                comparison = (leftItem, rightItem) => leftItem >= rightItem;
            }

            int x = 0;
            int y = 0;
            for (int k = low; k <= high; k++)
            {
                if (y == right.Length)
                {
                    list[k] = left[x];
                    x++;
                }
                else if (x == left.Length)
                {
                    list[k] = right[y];
                    y++;
                }
                else if (comparison(left[x].GetHashCode(), right[y].GetHashCode()))
                {
                    list[k] = left[x];
                    x++;
                }
                else
                {
                    list[k] = right[y];
                    y++;
                }
            }
        }
    }
}
