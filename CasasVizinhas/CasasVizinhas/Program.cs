using System;

namespace CasasVizinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = new int[8] { 1, 0, 1, 0, 0, 0, 1, 1 };

            var states = Solution.CellCompete(houses, 5);
            foreach (int state in states)
            {
                Console.WriteLine(state);
            }
        }
    }
    public class Solution
    {
        public static int[] CellCompete(int[] states, int days)
        {
            int leftCell = 0;
            int rightCell = 0;
            int[] nowStates = null;

            for (int day = 0; day < days; day++)
            {
                nowStates = states.Clone() as int[];
                for (int state = 0; state < states.Length; state++)
                {
                    if (state == 0)
                    {
                        if (leftCell == nowStates[state + 1])
                            states[state] = 0;
                        else
                            states[state] = 1;
                    }
                    else if (state == nowStates.Length - 1)
                    {
                        if (rightCell == nowStates[state - 1])
                            states[state] = 0;
                        else
                            states[state] = 1;
                    }
                    else
                    {
                        if (nowStates[state - 1] == nowStates[state + 1])
                            states[state] = 0;
                        else
                            states[state] = 1;
                    }
                }
            }
            return states;
        }
    }
}
