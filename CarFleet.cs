using System;

public class CarFleet
{
    public class Worst_Solution
    {
        List<double> fleetStack;
        public int CarFleet(int target, int[] position, int[] speed)
        {
            fleetStack = new List<double>();

            var zippedList = position.Zip(speed, (p, s) => (p: p, s: (double)s)).OrderByDescending(x => x.p);
            foreach (var item in zippedList)
            {
                fleetStack.Add((target - item.p) / item.s);
                if (fleetStack.Count >= 2 && fleetStack[fleetStack.Count - 1] <= fleetStack[fleetStack.Count - 2])
                {
                    Console.WriteLine($"{fleetStack[fleetStack.Count - 1]}, {fleetStack[fleetStack.Count - 2]}");
                    fleetStack.RemoveAt(fleetStack.Count - 1);
                }
            }

            return fleetStack.Count;
        }
    }
    public class FastestSolution
    {
        public int CarFleet(int target, int[] position, int[] speed)
        {
            Stack<int> stack = new Stack<int>();
            Stack<int> temp = new Stack<int>();

            stack.Push(0);
            for (int i = 1; i < position.Length; i++)
            {
                bool addSelf = true;
                while (stack.Count > 0)
                {
                    float prevTime = ((target - position[stack.Peek()]) / (float)speed[stack.Peek()]);
                    float currentTime = ((target - position[i]) / (float)speed[i]);

                    temp.Push(stack.Pop());

                    if (prevTime >= currentTime && position[temp.Peek()] > position[i])
                    {
                        addSelf = false;
                        break;
                    }

                    if (prevTime <= currentTime && position[temp.Peek()] < position[i])
                    {
                        temp.Pop();
                    }
                }

                if (addSelf)
                {
                    stack.Push(i);
                }

                while (temp.Count > 0)
                {
                    stack.Push(temp.Pop());
                }

            }

            return stack.Count;
        }
    }
}
