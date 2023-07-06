using Parte2.Agents;

namespace Parte2.Strategies
{
    public static class AgentStrategyFactory
    {
       public static IAgentStrategy CreateAgentStrategy(string agentType)
        {
            return agentType switch
            {
                "A" => new AgentA(), 
                "B" => new AgentB(),
                "C" => new AgentC(),
                _ => throw new NotSupportedException()
            }; 
        }
    }
}
