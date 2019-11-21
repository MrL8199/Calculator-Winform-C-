using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CalculatorFull
{
    class PreFixHeper
    {
        // Những toán tử đặc biệt
        private const string UNARY_FUNCS = "sqrt|sqr|exp";
        
        // Xét độ ưu tiên toán tử
        public static int GetPriority(string op)
        {
            if (UNARY_FUNCS.IndexOf(op, StringComparison.OrdinalIgnoreCase) >= 0)
                return 3;
            if (op == "×" || op == "÷" || op == "%")
                return 2;
            if (op == "+" || op == "-")
                return 1;
            return 0;
        }

        // Chuẩn hóa, định dạng lại biểu thức đầu vào
        public static string FormatExpression(string expression)
        {
            expression = expression.ToLower().Replace(" ", "");
            expression = Regex.Replace(expression, @"(\+|\-|\×|\÷|\%|\^){3,}", match => match.Value[0].ToString());

            expression = Regex.Replace(expression, @"(\+|\-|\×|\÷|\%|\^)(\+|\×|\÷|\%|\^)", match =>
                match.Value[0].ToString()
            );
            expression = Regex.Replace(expression, @"\+|\-|\×|\÷|\%|\^|\)|\(", match =>
                String.Format(" {0} ", match.Value)
            );
            expression = expression.Replace("  ", " ");
            expression = expression.Trim();

            return expression;
        }

        #region Kiểm tra các kí tự trong biểu thức
        private static bool IsOperator(string str)
        {
            return Regex.Match(str, @"^(\+|\-|\×|\÷|\%|\^|" + UNARY_FUNCS + ")$").Success;
        }

        public static bool IsUnaryFunction(string str)
        {
            return Regex.Match(str, @"^(" + UNARY_FUNCS + ")$").Success;
        }

        public static bool IsOperand(string str)
        {
            return Regex.Match(str, @"^\d+$|^([a-z]|[A-Z])$").Success;
        }
        #endregion

        #region Chuyển đổi Trung Tố sang Biểu thực Tiền Tố
        public static string Infix2Prefix(string infix)
        {

            infix = FormatExpression(infix);

            string[] tokens = infix.Split(' ').ToArray();

            tokens = ProcessConvert(tokens).Split(' ').Reverse().ToArray();

            StringBuilder result = new StringBuilder();

            Array.ForEach(tokens, s => result.Append(s).Append(" "));
            return result.ToString();

        }

        private static string ProcessConvert(string[] tokens)
        {
            Stack<string> stack = new Stack<string>();
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < tokens.Length; i++)
            {
                string token = tokens[i];
                if (IsOperator(token))
                {
                    if ((i == 0) || (i > 0 && (IsOperator(tokens[i - 1]) || tokens[i - 1] == "(")))
                    {
                        if (token == "-")
                        {
                            result.Append(token + tokens[i + 1]).Append(" ");
                            i++;
                        }
                        else if (IsUnaryFunction(token))
                        {
                            stack.Push(token);
                        }
                    }
                    else
                    {
                        while (stack.Count > 0 && GetPriority(token) <= GetPriority(stack.Peek()))
                            result.Append(stack.Pop()).Append(" ");
                        stack.Push(token);
                    }
                }

                else
                {
                    if (token == "(")
                    {
                        stack.Push(token);
                    }
                    else
                    {
                        if (token == ")")
                        {
                            string x = stack.Pop();
                            while (x != "(")
                            {
                                result.Append(x).Append(" ");
                                x = stack.Pop();
                            }
                        }
                        else// (IsOperand(s))
                        {
                            result.Append(token).Append(" ");
                        }
                    }
                }
            }

            while (stack.Count > 0)
                result.Append(stack.Pop()).Append(" ");

            return result.ToString();
        }
        #endregion

        public static double EvaluatePrefix(string prefix)
        {
            return EvaluatePostfix(prefix.Trim().Split(' ').Reverse());
        }

        public static double EvaluatePostfix(string postfix)
        {
            return EvaluatePostfix(postfix.Trim().Split(' '));
        }

        // Tính giá trị biểu thức
        private static double EvaluatePostfix(IEnumerable<string> tokens)
        {
            Stack<double> stack = new Stack<double>();

            foreach (string s in tokens)
            {
                if (IsOperator(s))
                {
                    double x = stack.Pop();

                    if (IsUnaryFunction(s))
                    {
                        switch (s)
                        {
                            case "sqrt":
                                x = Math.Sqrt(x);
                                break;
                            case "sqr":
                                x *= x;
                                break;
                            case "exp":
                                x = Math.Exp(x);
                                break;
                            default:
                                throw new Exception("Invalid function");
                        }
                        stack.Push(x);
                    }
                    else
                    {
                        double y = stack.Pop();

                        switch (s)
                        {
                            case "+": y += x; break;
                            case "-": y -= x; break;
                            case "×": y *= x; break;
                            case "÷": y /= x; break;
                            case "%": y %= x; break;
                            case "^": y = Math.Pow(y, x); break;
                            default:
                                throw new Exception("Invalid operator");
                        }

                        stack.Push(y);
                    }
                }
                else  // IsOperand
                {
                    stack.Push(double.Parse(s));
                }

            }
            return stack.Pop();
        }
    }
}
