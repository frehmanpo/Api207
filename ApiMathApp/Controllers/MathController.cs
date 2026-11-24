using Class207;
using Microsoft.AspNetCore.Mvc;

namespace ApiMathApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathController : ControllerBase
    {
        Class207.Math clsMathService = new Class207.Math();

        [HttpGet("Сумма")]
        public int SumTwo(int num1, int num2)
        {
            return clsMathService.Sum(num1, num2);
        }

        [HttpGet("Сложение трех чисел")]
        public int SumThree(int num1, int num2, int num3)
        {
            return clsMathService.Sum(num1, num2, num3);
        }

        [HttpGet("Вычитание")]
        public int SubTwo(int num1, int num2)
        {
            return clsMathService.Sub(num1, num2);
        }

        [HttpGet("Вычитание трех чисел")]
        public int SubThree(int num1, int num2, int num3)
        {
            return clsMathService.Sub(num1, num2, num3);
        }
        [HttpGet("Умножение")]
        public int Mul(int num1, int num2)
        {
            return (clsMathService.Mul(num1, num2));
        }

    }


}

