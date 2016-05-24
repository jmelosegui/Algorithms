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

            int p = 0;
            int r = list.Count - 1;

            InternalSort(list, p, r, direction);
        }

        private static void InternalSort<T>(IList<T> list, int p, int r, SortDirection direction)
        {
            if (p < r)
            {
                int q = (p + r) / 2;

                InternalSort(list, p, q, direction);
                InternalSort(list, q + 1, r, direction);
                InternalMerge(list, p, q, r, direction);
            }
        }

        private static void InternalMerge<T>(IList<T> list, int p, int q, int r, SortDirection direction)
        {
            int n1 = q - p + 1;
            int n2 = r - q;

            T[] left = new T[n1];
            T[] right = new T[n2];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = list[p + i];
            }

            for (int j = 0; j < right.Length; j++)
            {
                right[j] = list[q + j + 1];
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
            for (int k = p; k <= r; k++)
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
