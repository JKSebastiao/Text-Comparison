using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComparisonTextDocuments.Interfaces
{
    public interface IMetricStringDistance : IStringDistance
    {
        /// <summary>
        /// Compute and return the metric distance.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        new double Distance(string s1, string s2);
    }
}
