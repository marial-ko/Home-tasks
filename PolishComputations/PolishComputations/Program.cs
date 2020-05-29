using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolishComputations
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите выражение в постфиксной форме:");
            var phrase = Console.ReadLine();
            var stack = new Stack<double>();
            var info = phrase.Split(' ');
            double number;
            var isWrong = false;
          
            for (int i = 0; i < info.Length; i++)
            {
                if (isWrong) break;
                var arg = info[i];
                bool isNum = double.TryParse(arg, out number);
                if (isNum)
                    stack.Push(number);
                else
                {
                    double secondOp;
                    switch (arg)
                    {
                        case "+":
                            if (stack.Count < 2)
                            {
                                Console.WriteLine("Не хватает операнда!");
                                isWrong = true;
                            }
                            else
                                stack.Push(stack.Pop() + stack.Pop());
                            break;

                        case "-":
                            if (stack.Count < 2)
                            {
                                Console.WriteLine("Не хватает операнда!");
                                isWrong = true;
                            }
                            else
                            {
                                secondOp = stack.Pop();
                                stack.Push(stack.Pop() - secondOp);
                            }
                            break;

                        case "^":
                            if (stack.Count < 2)
                            {
                                Console.WriteLine("Не хватает операнда!");
                                isWrong = true;
                            }
                            else
                            {
                                secondOp = stack.Pop();
                                if (secondOp >= 0)
                                    stack.Push(Math.Pow(stack.Pop(), secondOp));
                                else
                                {
                                    Console.WriteLine("Возведение в отрицательную степень. Выражение не имеет смысла");
                                    isWrong = true;
                                }
                            }
                            break;

                        case "*":
                            if (stack.Count < 2)
                            {
                                Console.WriteLine("Не хватает операнда!");
                                isWrong = true;
                            }
                            else
                                stack.Push(stack.Pop() * stack.Pop());
                            break;

                        case "/":
                            if (stack.Count < 2)
                            {
                                Console.WriteLine("Не хватает операнда!");
                                isWrong = true;
                            }
                            else
                            {
                                secondOp = stack.Pop();
                                if (secondOp != 0.0)
                                    stack.Push(stack.Pop() / secondOp);
                                else
                                {
                                    Console.WriteLine("Деление на ноль невозможно");
                                    isWrong = true;
                                }
                            }
                            break;

                        case "%":
                            if (stack.Count < 2)
                            {
                                Console.WriteLine("Не хватает операнда!");
                                isWrong = true;
                            }
                            else
                            {
                                secondOp = stack.Pop();
                                if (secondOp != 0.0)
                                    stack.Push(stack.Pop() % secondOp);
                                else
                                {
                                    Console.WriteLine("Деление на ноль невзможно");
                                    isWrong = true;
                                }
                            }
                            break;

                        case "!":
                            if (stack.Count == 0)
                            {
                                isWrong = true;
                                Console.WriteLine("Не хватает операнда!");
                            }
                            else
                            {
                                secondOp = stack.Pop();
                                if (secondOp >= 0)
                                    stack.Push(Fact(secondOp));
                                else
                                {
                                    Console.WriteLine("Факториал отрицательного числа. Выражение не имеет смысла");
                                    isWrong = true;
                                }
                            }
                            break;

                        case "@": /*смена знака числа*/
                            if (stack.Count == 0)
                            {
                                isWrong = true;
                                Console.WriteLine("Не хватает операнда!");
                            }
                            else
                            {
                                secondOp = stack.Pop();
                                stack.Push(secondOp * -1);
                            }
                            break;
                    }
                }
            }

            if (stack.Count == 1)
                Console.WriteLine($"{phrase} = {stack.Pop()}");
            else
                Console.WriteLine("Значение выражения не определено");
            Console.ReadLine();
        }


        private static double Fact(double number)
        {
            var result = 1;
            for (int i = 2; i <= number; i++)
                result *= i;
            return result;
        }
    }
}
