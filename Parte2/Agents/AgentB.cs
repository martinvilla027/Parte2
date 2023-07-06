using Parte2.Strategies;

namespace Parte2.Agents
{
    public class AgentB : IAgentStrategy
    {
        public void Select()
        {
            Console.WriteLine("Agent B Selected!");
        }

        public double GetMedia(List<double> numbers)
        {
            double harmonicMedia = 0;
            double inversesSum = 0.0;

            if (numbers.Count != 0)
            {
                foreach (var num in numbers)
                {
                    inversesSum += 1.0 / num;
                }

                harmonicMedia = numbers.Count / inversesSum;
                return harmonicMedia;
            }

            return harmonicMedia;
        }

        public string GetStairCase(int size)
        {
            string stairs = "";

            if (size > 0 && size < 100)
            {
                for (int i = size; i >= 1; i--)
                {
                    string step = new string(' ', size - i) + new string('#', i);
                    stairs += step;
                    if (i != 1)
                    {
                        stairs += Environment.NewLine;
                    }
                }

                return stairs;
            }

            return stairs;
        }
    }
}
