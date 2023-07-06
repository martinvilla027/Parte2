namespace Parte2.Strategies
{
    public interface IAgentStrategy
    {
        double GetMedia(List<double> numbers);

        string GetStairCase(int size);
    }
}
