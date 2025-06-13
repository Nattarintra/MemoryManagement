using SkalProj_Datastrukturer_Minne.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne.TheStack
{
    internal class PushAndPop
    {
        public static void PushAndPopFromStack()
        {
            /*
             * Stack is a Last In, First Out (LIFO) data structure.
             * example: Push: A -> B -> C => [C, B, A]
             * If you want First In, First Out (FIFO). Reverse the stack and pop it.
             * Reverse example: Pop: => [A, B, C]
             * 
             */
            Stack<string> stacks = new();

            UI.Clear();
            UI.Print("*==============================================================*\n");
            UI.Print("Welcome to Stack world! Let's try Push and Pop \n");
            UI.Print("Enter +<Name> for enqueue  \n");
            UI.Print("Enter - for dequeue \n");
            UI.Print("Enter r for dequeue \n");
            UI.Print("Name 0 for exit the program \n ");
            UI.Print("Example: +Adam or - \n");
            UI.Print("*==============================================================*\n");

            do
            {
                Queue<string> queue = new();
                UI.Print("What would you like to do?: ");
                string input = UI.GetInput();

                char nav = input[0];
                string value = input.Substring(1);// Get the rest of the input after the first character
                switch (nav)
                {
                    case '+':
                        {
                            stacks.Push(value); // Add the input to the list
                            UI.Print($"Now {value}: is added");
                            UI.Print("Current Stack:");
                            foreach (var stack in stacks)
                            {
                                UI.Print(stack);
                            }
                            break;
                        }
                    case '-':
                        { // Pop the last item from the stack
                            if (stacks.Count > 0)
                            {
                                string poppedItem = stacks.Pop();
                                UI.Print($"Popped: {poppedItem}");
                            }

                            break;
                        }
                    case 'r':
                        { // 1. Reverse the stack
                            Stack<string> reversed = new Stack<string>();
                            while (stacks.Count > 0)
                            {
                                reversed.Push(stacks.Pop());
                            }
                            stacks = reversed;

                            UI.Print("Stack is now reversed!");
                            UI.Print("Now popping items one by one:");

                            // 2. Pop out one by one and display
                            while (stacks.Count > 0)
                            {
                                string item = stacks.Pop();
                                UI.Print($"Popped: {item}");
                            }

                            UI.Print("Stack is now empty!");

                            break;
                        }

                    case '0':
                        {
                            Environment.Exit(0);
                            UI.Print("Exit the program:");
                            break;
                        }
                    default:
                        {
                            UI.Print("Please enter a valid input (+, -, 0)");
                            continue; // Continue the loop to ask for input again
                        }
                }
            } while (true);
        }
    }
}
