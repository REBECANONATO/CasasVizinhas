using System;

namespace CasasVizinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = new int[8] { 1, 0, 1, 0, 0, 0, 1, 1 };

            Console.WriteLine(Solution.CellCompete(houses, 5));
        }
    }
    public class Solution
    {
        public static int[] CellCompete(int[] states, int days)
        {
            int leftNeighbor = 0;
            int rightNeighbor = 0;
            int[] previousState = null;

            for (int i = 0; i < days; i++)
            {
                previousState = states.Clone() as int[];
                for (int j = 0; j < states.Length; j++)
                {
                    if (j == 0)
                    {
                        leftNeighbor = 0;
                        rightNeighbor = previousState[j + 1];
                    }
                    else if (j == states.Length - 1)
                    {
                        leftNeighbor = previousState[j - 1];
                        rightNeighbor = 0;
                    }
                    else
                    {
                        leftNeighbor = previousState[j - 1];
                        rightNeighbor = previousState[j + 1];
                    }

                    states[j] = 1;
                    if (leftNeighbor == rightNeighbor)
                        states[j] = 0;
                }
            }

            return states;
        }
    }
}
