using PokemonSimulator.ConsoleUI;
using SkalProj_Datastrukturer_Minne.StackAndHeap;
using SkalProj_Datastrukturer_Minne.TheList;
using System;
using System.Diagnostics;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {


            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
          AddOrRemove.AddOrRemoveFromList();

        }



        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
            List<string> theQueue = new List<string>();

            UI.Clear();
            UI.Print("*==============================================================*\n");
            UI.Print("Welcome to ICA Queue Service \n");
            UI.Print("Enter +<Name> for enqueue  \n");
            UI.Print("Enter -<Name> for dequeue \n");
            UI.Print("Name 0 for exit the program \n ");
            UI.Print("Example: +Adam or -Adam \n");
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
                            theQueue.Add(value); // Add the input to the list
                            UI.Print($"Now {value}: is queue number {theQueue.Count}");
                            break;
                        }
                    case '-':
                        {
                            theQueue.Remove(value);
     
                            // Re-indexing is not needed for List, but to show the new positions:
                            UI.Print("Current Queue:");
                            for (int i = 0; i < theQueue.Count; i++)
                            {
                                UI.Print($"Now {theQueue[i]} queue number {i + 1}:");
                            }
                            UI.Print($"{value} has been dequeued.");
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

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
       
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack<string> stacks = new();

            UI.Clear();
            UI.Print("*==============================================================*\n");
            UI.Print("Welcome to Stack world! Let's try Push and Pop \n");
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
                        {
                            ReverseStack();
                            if (stacks.Count != 0)
                            {
                                stacks.Pop();
                                // Show current stack after pop
                                UI.Print("Current Stack:");
                                foreach (var stack in stacks)
                                {
                                    UI.Print(stack);
                                }
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
            } while (true);

        }

        private static void ReverseStack()
        {
            // Fix stack reversing logic here Pop()  
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

