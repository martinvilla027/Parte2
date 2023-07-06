using Parte2.Strategies;

namespace Parte2.Agents
{
    public class AgentC : IAgentStrategy
    {
        public void Select()
        {
            Console.WriteLine("Agent C Selected!");
        }

        public double GetMedia(List<double> numbers)
        {
            numbers.Sort();

            double median = 0;

            if (numbers.Count != 0)
            {
                if (numbers.Count % 2 == 0)
                {
                    int averageIndex1 = numbers.Count / 2 - 1;
                    int avergageIndex2 = numbers.Count / 2;
                    median = (numbers[averageIndex1] + numbers[avergageIndex2] / 2.0);
                }
                else
                {
                    int averageIndex = numbers.Count / 2;
                    median = numbers[averageIndex];
                }

                return median;
            }

            return median;
        }

        public string GetStairCase(int size)
        {
            string diamondStairs = "";

            if (size > 0 && size < 100)
            {
                for (int i = 1; i <= size; i++)
                {
                    string space = new string(' ', size - i);
                    string step = new string('#', i);
                    string stairs = space + step + step.Substring(1);
                    diamondStairs += stairs.PadLeft(size) + Environment.NewLine;
                }

                for (int i = size - 1; i >= 1; i--)
                {
                    string space = new string(' ', size - i);
                    string step = new string('#', i);
                    string stairs = space + step + step.Substring(1);
                    diamondStairs += stairs.PadLeft(size) + Environment.NewLine;
                }

                return diamondStairs;
            }

            return diamondStairs;
        }
    }
}
