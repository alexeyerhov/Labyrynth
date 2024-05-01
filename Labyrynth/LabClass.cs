using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrynth
{
    public class Labirint
    {
        public int countOfExit = 0;

        public int HasExit(int startI, int startJ, int[,] lab)
        {
            if (lab[startI, startJ] == 1) return 0;

            countOfExit = 0;

            var i = startI;
            var j = startJ;

            Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
            stack.Push(new(i, j));

            while (stack.Count > 0)
            {

                var temp = stack.Pop();

                if (lab[temp.Item1, temp.Item2] == 2) { countOfExit++;}

                

                lab[temp.Item1, temp.Item2] = 1;

                if (temp.Item2 > 0 && lab[temp.Item1, temp.Item2 - 1] != 1)
                {
                    stack.Push(new (temp.Item1, temp.Item2 - 1)); // up
                }
                if (temp.Item2 + 1 < lab.GetLength(1) && lab[temp.Item1, temp.Item2 + 1] != 1)
                {
                    stack.Push(new(temp.Item1, temp.Item2 + 1)); // down
                }
                if (temp.Item1 > 0 && lab[temp.Item1-1, temp.Item2] != 1)
                {
                    stack.Push(new(temp.Item1 - 1, temp.Item2)); // left
                }
                if (temp.Item1 + 1 < lab.GetLength(0) && lab[temp.Item1 + 1, temp.Item2] != 1)
                {
                    stack.Push(new(temp.Item1 + 1, temp.Item2)); // right
                }

            }

            return countOfExit;
            

        }
    }
}
