using Parte2.Helpers;
using Parte2.Strategies;

namespace Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un tipo de agente (A, B o C): ");
            var agentType = Console.ReadLine();
            if (TransformEntryText.CheckAgentType(agentType))
            {
                Console.WriteLine("Ingrese una lista de números separados por comas para calcular su media: ");
                var entryData = Console.ReadLine()?.Split(',');
                if (entryData?.Length != 0)
                {
                    var transformResult = TransformEntryText.TransformMediaNumbers(entryData);
                    if (transformResult.Count != 0)
                    {
                        Console.WriteLine("Ingrese el tamaño deseado para la creación de la escalera: ");
                        var size = Console.ReadLine();
                        if (TransformEntryText.CheckStairSize(size))
                        {
                            var agent = AgentStrategyFactory.CreateAgentStrategy(agentType.ToUpper());

                            var media = agent.GetMedia(transformResult);
                            Console.WriteLine("La media para el agente " + agentType + " es: " + media);

                            var stair = agent.GetStairCase(Convert.ToInt32(size));
                            Console.WriteLine("La escalera para el agente " + agentType + " es: ");
                            Console.WriteLine(stair);
                        }
                        else
                        {
                            Console.WriteLine("Ingrese un tamaño válido!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ingrese solo números separados por comas!");
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar por lo menos un número para calcular la media!");
                }
            }
            else
            {
                Console.WriteLine("Agente incorrecto!");
            }
        }
    }
}