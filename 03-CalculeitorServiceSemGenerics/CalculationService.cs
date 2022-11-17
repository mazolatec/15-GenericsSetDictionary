﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CalculeitorServiceSemGenerics
{
    internal class CalculationService
    {
        public int Max(List<int> list)
        {
            if (list.Count == 0)
            {
                throw new ArgumentNullException("The list can not be empty");
            }
            int max=list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i]>max)
                {
                    max = list[i];
                }

            }return max;
        }
    }
}
