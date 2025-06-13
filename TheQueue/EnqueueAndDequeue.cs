using SkalProj_Datastrukturer_Minne.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne.Queue
{
    internal static class EnqueueAndDequeue
    {
        public static void EnqueueAndDequeueFromQueue()
        {
            //Summary:
            /** First In, First Out (FIFO) → The first item that goes in is the first one to come out.
             * EnQueue:
                When someone or something is added to the queue, we call it an EnQueue.
                It goes to the back of the line..
            DeQueue:
                When we remove an item from the front, we call it a DeQueue.
                This removes the person who was first in line.

             */

            Queue<string> theQueue = new Queue<string>();

            UI.Clear();
            UI.Print("*==============================================================*\n");
            UI.Print("Welcome to ICA Queue Service \n");
            UI.Print("Enter +<Name> for enqueue  \n");
            UI.Print("Enter - for dequeue \n");
            UI.Print("Name 0 for exit the program \n ");
            UI.Print("Example: +Adam or - \n");
            UI.Print("*==============================================================*\n");

            do
            {

                UI.Print("What would you like to do?: ");
                string input = UI.GetInput();

                char nav = input[0];
                string value = input.Substring(1);// Get the rest of the input after the first character
                switch (nav)
                {
                    case '+':
                        {
                            theQueue.Enqueue(value);

                            UI.Print($"Now {value}: is queue number {theQueue.Count}");
                            break;
                        }
                    case '-':
                        {
                            if (theQueue.Count > 0)
                            {
                                string removed = theQueue.Dequeue();
                                UI.Print($"{removed} has been dequeued.");
                            }

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
                UI.Print("Current queue:");
                int position = 1;
                foreach (string name in theQueue)
                {
                    UI.Print($"{position}: {name}");
                    position++;
                }
            } while (true);
        }

    }
}
