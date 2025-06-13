using SkalProj_Datastrukturer_Minne.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne.CheckParams
{
    internal class CheckParam
    {
        public static void CheckParamsFromInput()
        {

            /*
             Use a stack to keep track of the order of opening brackets.
             When a closing bracket is encountered, pop and check if it matches the most recent opening one.
             If all pairs match and the stack is empty at the end → Well-formed.
             If there's any mismatch or the stack isn't empty at the end → Not well-formed.
             */

            UI.Write("Enter a string to check: ");
            string input = UI.GetInput();

            Stack<char> stack = new Stack<char>();

            // Pairing of opening and closing
            Dictionary<char, char> matches = new Dictionary<char, char>
            {
                { ')', '(' },
                { '}', '{' },
                { ']', '[' }
            };

            bool wellFormed = true;

            foreach (char c in input)
            {
                // If it's an opening, push it onto the stack
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                // If it's a closing
                else if (c == ')' || c == '}' || c == ']')
                {
                    // If the stack is empty or the top doesn't match → Invalid
                    if (stack.Count == 0 || stack.Peek() != matches[c])
                    {
                        wellFormed = false;
                        break;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                // Skip other characters
            }

            // If the stack is not empty at the end, it means there are still unmatched opening brackets
            if (stack.Count != 0)
            {
                wellFormed = false;
            }

            if (wellFormed)
                UI.Print("The string is well-formed!");
            else
                UI.Print("The string is NOT well-formed.");
        }
    }
}
