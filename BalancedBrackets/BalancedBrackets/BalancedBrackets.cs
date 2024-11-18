using System.Text.RegularExpressions;

namespace BalancedBrackets
{
    public class BalancedBrackets
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Brackets input: \n");
            string brackets = Console.ReadLine();

            string result = IsBalanced(brackets) ? "Balanced" : "Not balanced";

            Console.WriteLine(result);
        }

        public static bool IsBalanced(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(')
                    stack.Push(')');
                else if (c == '[')
                    stack.Push(']');
                else if (c == '{')
                    stack.Push('}');
                else if (stack.Count == 0 || stack.Pop() != c)
                    return false;
            }

            return stack.Count == 0;
        }
    }
}
