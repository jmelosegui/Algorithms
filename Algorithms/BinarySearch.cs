// Copyright (c) to jmelosegui. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public static class BinarySearch
    {
        private static readonly Func<int, int, SortDirection, bool> Comparison = (left, right, sortDirection) =>
        {
            if (sortDirection == SortDirection.Asc)
            {
                return left > right;
            }

            return left < right;
        };

        public static int IterativeSearch<T>(IList<T> list, T itemToSearch, SortDirection sortDirection = SortDirection.Asc)
        {
            int low = 0;
            int high = list.Count - 1;

            var levels = Math.Ceiling(Math.Log(list.Count, 2));
            for (int i = 0; i < levels; i++)
            {
                int middle = (high + low) / 2;

                if (list[middle].GetHashCode() == itemToSearch.GetHashCode())
                {
                    return middle;
                }

                if (Comparison(list[middle].GetHashCode(), itemToSearch.GetHashCode(), sortDirection))
                {
                    high = middle - 1;
                }
                else
                {
                    low = middle + 1;
                }
            }

            return -1;
        }

        public static int RecursiveSearch<T>(IList<T> list, T itemToSearch, SortDirection sortDirection = SortDirection.Asc)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            return RecursiveSearch<T>(list, itemToSearch, 0, list.Count - 1, sortDirection);
        }

        private static int RecursiveSearch<T>(IList<T> list, T itemToSearch, int low, int high, SortDirection sortDirection)
        {
            if (low > high)
            {
                return -1;
            }

            int middle = (high + low) / 2;

            if (list[middle].GetHashCode() == itemToSearch.GetHashCode())
            {
                return middle;
            }

            if (Comparison(list[middle].GetHashCode(), itemToSearch.GetHashCode(), sortDirection))
            {
                high = middle - 1;
            }
            else
            {
                low = middle + 1;
            }

            return RecursiveSearch(list, itemToSearch, low, high, sortDirection);
        }
    }
}
