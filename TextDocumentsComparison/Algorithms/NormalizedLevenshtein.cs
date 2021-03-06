﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComparisonTextDocuments.Interfaces;

namespace ComparisonTextDocuments.Algorithms
{
    public class NormalizedLevenshtein : INormalizedStringDistance, INormalizedStringSimilarity
    {
        private readonly Levenshtein l = new Levenshtein();

        /// <summary>
        /// Compute distance as Levenshtein(s1, s2) / max(|s1|, |s2|).
        /// </summary>
        /// <param name="s1">The first string to compare.</param>
        /// <param name="s2">The second string to compare.</param>
        /// <returns>The computed distance in the range [0, 1]</returns>
        /// <exception cref="ArgumentNullException">If s1 or s2 is null.</exception>
        public double Distance(string s1, string s2)
        {
            if (s1 == null)
            {
                throw new ArgumentNullException(nameof(s1));
            }

            if (s2 == null)
            {
                throw new ArgumentNullException(nameof(s2));
            }

            if (s1.Equals(s2))
            {
                return 0.0;
            }

            int m_len = Math.Max(s1.Length, s2.Length);

            if (m_len == 0)
            {
                return 0.0;
            }

            return l.Distance(s1, s2) / m_len;
        }

        /// <summary>
        /// Return 1 - distance.
        /// </summary>
        /// <param name="s1">The first string to compare.</param>
        /// <param name="s2">The second string to compare.</param>
        /// <returns>1 - distance</returns>
        /// <exception cref="ArgumentNullException">If s1 or s2 is null.</exception>
        public double Similarity(string s1, string s2)
            => 1.0 - Distance(s1, s2);
    }
}
