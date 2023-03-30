using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace crash_course_delagetes2
{
    public delegate double CalcOperation(int a, int b);

    internal class Calculator
    {
        private Dictionary<string, CalcOperation> operations = new Dictionary<string, CalcOperation>();
        
        public Dictionary<string, CalcOperation> AddOperations()
        {
            operations["+"] = (a, b) => a + b;
            operations["-"] = (a, b) => a - b;
            operations["*"] = (a, b) => a * b;
            operations["/"] = (a, b) => a / b;
            operations["sin"] = (a, b) => Math.Sin(a);
            operations["cos"] = (a, b) => Math.Cos(a);
            operations["tan"] = (a, b) => Math.Tan(a);

            return operations;
        }

        public double MakeCalc(int a, int b,CalcOperation operation)
        {
            double result = operation.Invoke(a, b);
            return result;
        }

        private List<string> GetPostfixExpression(string expression)
        {
            List<string> operations = new() { "+", "-", "*", "/" };
            List<string> prefixOperation = new() { "sin", "cos", "tan" };
            List<string> postfixExpression = new List<string>();
            Stack<string> operationSymbols = new Stack<string>();
            List<string> tokkens = new List<string>();

            bool isDig;
            string current_number = string.Empty;

            foreach (var item in expression)
            {
                if (item != ' ')
                {
                    isDig = char.IsDigit(item);
                    if (isDig)
                    {
                        current_number += item;
                    }
                    else if (!isDig && current_number != string.Empty)
                    {
                        tokkens.Add(current_number);
                        current_number = string.Empty;
                        tokkens.Add(item.ToString());
                    }
                    else
                    {
                        tokkens.Add(item.ToString());
                    }

                }

            }
            tokkens.Add(current_number);

            Dictionary<string, int> operationPriorities = new Dictionary<string, int>();
            operationPriorities["("] = 5;
            operationPriorities["*"] = 4;
            operationPriorities["/"] = 3;
            operationPriorities["+"] = 2;
            operationPriorities["-"] = 1;

            foreach (var symbol in tokkens)
            {
                if (char.IsDigit(symbol, 0))
                {
                    postfixExpression.Add(symbol);
                }

                else if (prefixOperation.Contains(symbol))
                {
                    operationSymbols.Push(symbol);
                }

                else if (symbol == "(")
                {
                    operationSymbols.Push(symbol);
                }

                else if (symbol == ")")
                {
                    string operationFromStack = "";
                    while (operationSymbols.Count != 0)
                    {
                        operationFromStack = operationSymbols.Pop();

                        if (operationFromStack == "(")
                        {
                            break;
                        }
                        else
                        {
                            postfixExpression.Add(operationFromStack);
                        }
                    }
                }

                else if (operations.Contains(symbol))
                {
                    bool popStackOperation;
                    while (true)
                    {
                        popStackOperation = (
                            operationSymbols.Count != 0
                            && operations.Contains(operationSymbols.Peek())
                            && (operationPriorities[symbol] <= operationPriorities[operationSymbols.Peek()]
                            || prefixOperation.Contains(symbol.ToString()))
                            );
                        if (popStackOperation)
                        {
                            postfixExpression.Add(operationSymbols.Pop());
                        }
                        else
                        {
                            operationSymbols.Push(symbol);
                            break;
                        }
                    }

                }
            }


            while (operationSymbols.Count != 0)
            {
                string last = operationSymbols.Pop();
                postfixExpression.Add(last);
            }

            return postfixExpression;
        }

        public int CalculatePostfixExpression(string mathEquation, Dictionary<string, CalcOperation> operations)
        {
            Stack<string> stack_operators = new Stack<string>();

            string last_item = "";
            bool isDig;
            int result = 0;

            List<string> expression_ls = GetPostfixExpression(mathEquation);

            foreach (var item in expression_ls)
            {
                isDig = char.IsDigit(item, 0);
                if (isDig)
                {
                    stack_operators.Push(item);
                }
                else
                {
                    int second_item = Convert.ToInt32(stack_operators.Pop());
                    int first_item = Convert.ToInt32(stack_operators.Pop());
                    result = (int)MakeCalc(first_item, second_item, operations[item]);
                    stack_operators.Push(Convert.ToString(result));
                }
            }

            return result;
        }
    }
}
