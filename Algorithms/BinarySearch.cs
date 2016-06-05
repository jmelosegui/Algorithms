// Copyright (c) to jmelosegui. All rights reserved.
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.

namespace Algorithms
{
    using System.Collections.Generic;

    public static class BinarySearch
    {
        public static int Search<T>(IList<T> list, T itemToSearch)
        {
            return Search<T>(list, itemToSearch, 0, list.Count - 1);
        }

        private static int Search<T>(IList<T> list, T itemToSearch, int low, int high)
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

            if (list[middle].GetHashCode() > itemToSearch.GetHashCode())
            {
                return Search(list, itemToSearch, low, middle - 1);
            }

            return Search(list, itemToSearch, middle + 1, high);
        }
    }
}
