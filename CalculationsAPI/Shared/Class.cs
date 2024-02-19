using CalculationsAPI.Repository;

namespace CalculationsAPI.Shared
{
    public class SharedDelegate
    {
        public delegate ICalculations ServiceResolver(string key);
    }
}
