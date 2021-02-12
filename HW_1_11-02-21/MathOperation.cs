using System;
using System.Collections.Generic;
using System.Text;

namespace HW_1_11_02_21
{
    class MathOperation<T>
    {
            public delegate T Operation(T firstNumber, T secondNumber);
            /// <summary>
            /// Added two numbers
            /// </summary>
            /// <param name="firstNumber"></param>
            /// <param name="secondNumber"></param>
            /// <returns></returns>
            private static T Add(T firstNumber, T secondNumber)         
            {
                Console.Write($"{firstNumber} + {secondNumber} = ");
                return (dynamic)firstNumber + (dynamic)secondNumber;
            }
            /// <summary>
            /// Subtract two numbers
            /// </summary>
            /// <param name="firstNumber"></param>
            /// <param name="secondNumber"></param>
            /// <returns></returns>
            private static T Subtract(T firstNumber, T secondNumber)
            {
                Console.Write($"{firstNumber} - {secondNumber} = ");
                return (dynamic)firstNumber - (dynamic)secondNumber;
            }
            /// <summary>
            /// Multiply two numbers
            /// </summary>
            /// <param name="firstNumber"></param>
            /// <param name="secondNumber"></param>
            /// <returns></returns>
            private static T Multiply(T firstNumber, T secondNumber)
            {
                Console.Write($"{firstNumber} * {secondNumber} = ");
                return (dynamic)firstNumber * (dynamic)secondNumber;
            }
            /// <summary>
            /// Divide two numbers
            /// </summary>
            /// <param name="firstNumber"></param>
            /// <param name="secondNumber"></param>
            /// <returns></returns>
            private static T Divide(T firstNumber, T secondNumber)
            {
                if ((dynamic)secondNumber == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Деление на нол !");
                    Console.ForegroundColor = ConsoleColor.White;
                    return (dynamic)secondNumber;
                }
                else
                {
                    Console.Write($"{firstNumber} / {secondNumber} = ");
                    return (dynamic)firstNumber / (dynamic)secondNumber;
                }
            }
            public Operation operSum = Add;
            public Operation operMin = Subtract;
            public Operation operMul = Multiply;
            public Operation operDiv = Divide;
        }
    }

