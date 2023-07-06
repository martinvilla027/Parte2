using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte2.Helpers
{
    public static class TransformEntryText
    {
        public static List<double> TransformMediaNumbers(string[] numbers)
        {
            List<double> result = new List<double>();

            foreach (var textNumber in numbers)
            {
                if (double.TryParse(textNumber, out double number))
                {
                    result.Add(number);
                }
                else
                {
                    return result;
                }
            }

            return result;
        }

        public static bool CheckAgentType(string type)
        {
            if (type == "A" || type == "B" || type == "C")
            {
                return true;
            }

            return false;
        }

        public static bool CheckStairSize(string size)
        {
            if (int.TryParse(size, out int number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
