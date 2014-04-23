﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndaForceExtensions.com.andaforce.arazect.collections.linq
{
    public static class ClonedLinqCompareMethods
    {
        public static T ClonedMax<T>(this List<T> list) where T : IComparable
        {
            if (list.Count > 0)
            {
                var maxValue = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    if (maxValue.CompareTo(list[i]) < 0)
                    {
                        maxValue = list[i];
                    }
                }

                return maxValue;
            }
            return default(T);
        }

        public static T ClonedMin<T>(this List<T> list) where T : IComparable
        {
            if (list.Count > 0)
            {
                var minValue = list[0];
                for (int i = 0; i < list.Count; i++)
                {
                    if (minValue.CompareTo(list[i]) > 0)
                    {
                        minValue = list[i];
                    }
                }

                return minValue;
            }
            return default(T);
        }
    }
}