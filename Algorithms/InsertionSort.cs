// Copyright (c) to jmelosegui. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace Algorithms
{
    using System;
    using System.Collections.Generic;

    public class InsertionSort
    {
        public void Sort<T>(IList<T> list, SortDirection direction = SortDirection.Asc)
        {
            for (int j = 0; j < list.Count; j++)
            {
                var currentItem = list[j];
                var i = j - 1;

                Func<int, int, bool> comparison;

                if (direction == SortDirection.Asc)
                {
                    comparison = (sortedIntem, currentIntem) => sortedIntem > currentIntem;
                }
                else
                {
                    comparison = (sortedIntem, currentIntem) => sortedIntem < currentIntem;
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
