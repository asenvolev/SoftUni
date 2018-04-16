﻿using System;
using System.Linq;

namespace GeneratingCombinations
{
    public class GeneratingCombinations
    {
        public static void Main()
        {
            var set = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var combLen = int.Parse(Console.ReadLine());
            var vector = new int[combLen];
            GenerateCombinations(set, vector);
        }

        private static void GenerateCombinations(int[] set, int[] vector, int index=0, int border = 0)
        {
            if (index == vector.Length)
            {
                Console.WriteLine(string.Join(" ",vector));
                return;
            }
            else
            {
                for (int i = border; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenerateCombinations(set, vector, index + 1, i + 1);
                }
            }
        }
    }
}