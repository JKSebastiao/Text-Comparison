﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparisonTextDocuments.Interfaces
{
    public interface IStringDistance
    {
        /// <summary>
        /// Compute and return a measure of distance.
        /// Must be >= 0.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        double Distance(string s1, string s2);
    }
}
