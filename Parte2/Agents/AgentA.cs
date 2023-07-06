using Parte2.Strategies;

namespace Parte2.Agents
{
    public class AgentA : IAgentStrategy
    {
        public void Select()
        {
            Console.WriteLine("Agent A Selected!");
        }

        public double GetMedia(List<double> numbers)
        {
            double media = 0;

            if (numbers.Count != 0)
            {
                double sum = 0;

                foreach (var num in numbers)
                {
                    sum += num;
                }

                media = sum / numbers.Count;
                return media;
            }

            return media;
        }

        public string GetStairCase(int size)
        {
            string stairs = "";

            if (size > 0 && size < 100)
            {
                for (int i = 1; i <= size; i++)
                {
                    string step = new string(' ', size - i) + new string('#', i);
                    stairs += step;
                    if (i != size)
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
