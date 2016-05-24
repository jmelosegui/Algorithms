// Copyright (c) to jmelosegui. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public static class InsertionSort
    {
        public static void Sort<T>(IList<T> list, SortDirection direction = SortDirection.Asc)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list));
            }

            for (int j = 0; j < list.Count; j++)
            {
                var currentItem = list[j];
                var i = j - 1;

                Func<int, int, bool> comparison;

                if (direction == SortDirection.Asc)
                {
                    comparison = (sorted, current) => sorted > current;
                }
                else
                {
                    comparison = (sorted, current) => sorted < current;
                }

                while (i >= 0 && comparison(list[i].GetHashCode(), currentItem.GetHashCode()))
                {
                    list[i + 1] = list[i];
                    i--;
                }

                list[i + 1] = currentItem;
            }
        }
    }
}
