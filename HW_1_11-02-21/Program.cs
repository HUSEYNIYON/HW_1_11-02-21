using System;

namespace HW_1_11_02_21
{

    class Program
    {
        static void Main(string[] args)
        {
            MathOperation<double> Operation = new MathOperation<double>();
            while (true)
            {
                Console.Write("Первое число: "); double firstNumber = double.Parse(Console.ReadLine());
                Console.Write("Второе число: "); double secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine(@"Выберите комманду:
                    1. Суммирование ---> +
                    2. Вычитание    ---> -
                    3. Умножение    ---> *
                    4. Деление      ---> /
                    5. Выход        ---> !");
                switch (Console.ReadLine())
                {
                    case "+": Console.WriteLine(Operation.operSum(firstNumber, secondNumber)); break;
                    case "-": Console.WriteLine(Operation.operMin(firstNumber, secondNumber)); break;
                    case "*": Console.WriteLine(Operation.operMul(firstNumber, secondNumber)); break;
                    case "/": Console.WriteLine(Operation.operDiv(firstNumber, secondNumber)); break;
                    case "!": return;
                }
            }
        }
    }
}
