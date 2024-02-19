using CalculationsAPI.Model;
using CalculationsAPI.Repository;
using static CalculationsAPI.Shared.SharedDelegate;

namespace CalculationsAPI.Service
{
    public class CalculationService:ICalculations
    {
       
        public async Task<Responce> Addition(RequestModel req)
        {
            try
            {
                if (req is not null)
                {
                    var colour = "";
                    var calculation = req.firstNum + req.secondNum;
                    var isEven = Convert.ToBoolean(IsEven(calculation, out colour));
                    var isPrime = Convert.ToBoolean(await IsPrime(calculation));

                    var res = new Responce()
                    {

                        Answer = calculation,
                        Colour = colour,
                        isEven = isEven,
                        isPrime = isPrime,
                        Message = "Calculation Succsefull."

                    };


                    return res;
                }
                else
                {
                    return new Responce() { Message = "Some error occured." };
                }
            }
            catch (Exception ex)
            {

                return new Responce() { Message= ex.Message };
            }
            
            
        }
        public async Task<Responce> Division(RequestModel req)
        {
            try
            {
                if (req is not null)
                {
                    if (req.secondNum == 0)
                        return new Responce() { Message = "Cant devide by 0." };
                    var colour = "";
                    var calculation = req.firstNum / req.secondNum;
                    var isEven = Convert.ToBoolean(IsEven(calculation, out colour));
                    var isPrime = Convert.ToBoolean(await IsPrime(calculation));

                    var res = new Responce()
                    {

                        Answer = calculation,
                        Colour = colour,
                        isEven = isEven,
                        isPrime = isPrime,
                        Message = "Calculation Succsefull."

                    };


                    return res;
                }
                else
                {
                    return new Responce() { Message = "Request can not be null or empty." };
                }
            }
            catch (Exception ex)
            {

                return new Responce() { Message = ex.Message };
            }


        }

        public async Task<Responce> Multiplication(RequestModel req)
        {
            try
            {
                if (req is not null)
                {
                    var colour = "";
                    var calculation = req.firstNum * req.secondNum;
                    var isEven = Convert.ToBoolean(IsEven(calculation, out colour));
                    var isPrime = Convert.ToBoolean(await IsPrime(calculation));

                    var res = new Responce()
                    {

                        Answer = calculation,
                        Colour = colour,
                        isEven = isEven,
                        isPrime = isPrime,
                        Message = "Calculation Succsefull."

                    };


                    return res;
                }
                else
                {
                    return new Responce() { Message = "Some error occured." };
                }
            }
            catch (Exception ex)
            {

                return new Responce() { Message = ex.Message };
            }


        }
        public async Task<Responce> Subtraction(RequestModel req)
        {
            try
            {
                if (req is not null)
                {
                    var colour = "";
                    var calculation = req.firstNum - req.secondNum;
                    var isEven = Convert.ToBoolean(IsEven(calculation, out colour));
                    var isPrime = Convert.ToBoolean(await IsPrime(calculation));

                    var res = new Responce()
                    {

                        Answer = calculation,
                        Colour = colour,
                        isEven = isEven,
                        isPrime = isPrime,
                        Message = "Calculation Succsefull."

                    };


                    return res;
                }
                else
                {
                    return new Responce() { Message = "Some error occured." };
                }
            }
            catch (Exception ex)
            {

                return new Responce() { Message = ex.Message };
            }


        }



        public bool IsEven(double number, out string color)
        {
            if (number > 0 && number % 2 == 0)
            {
                color = "Green";
                return true;
            }
            else { color = "Red"; return false; }
        }

        public async Task<bool> IsPrime(double number)

        {
            if (number <= 1)
            {
                return false;
            }

            // Check for divisibility from 2 to the square root of the number
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        
    }
}
