using CalculationsAPI.Model;

namespace CalculationsAPI.Repository
{
    public interface ICalculations
    {
        public Task< Responce> Addition(RequestModel req);
        public Task<Responce> Subtraction(RequestModel req);
        public Task<Responce> Multiplication(RequestModel req);
        public Task<Responce> Division(RequestModel req);

        public Task<bool> IsPrime(double number);

        public bool IsEven(double number, out string color);
    }
}
