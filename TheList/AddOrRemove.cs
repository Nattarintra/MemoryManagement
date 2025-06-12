using PokemonSimulator.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne.TheList
{
    internal class AddOrRemove
    {
        public static void AddOrRemoveFromList()
        {
            /*
              * Loop this method untill the user inputs something to exit to main menue.
              * Create a switch statement with cases '+' and '-'
              * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
              * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
              * In both cases, look at the count and capacity of the list
              * As a default case, tell them to use only + or -
              * Below you can see some inspirational code to begin working.
             */

            List<string> theList = new List<string>();

            UI.Clear();
            UI.Print("*==============================================================*\n");
            UI.Print("Welcome to my List world! \n");
            UI.Print("Enter +<Name> for adding your name into the list  \n");
            UI.Print("Enter -<Name> for removing your name from the list \n");
            UI.Print("Name 0 for exit the program \n ");
            UI.Print("Example: +Adam or -Adam \n");
            UI.Print("*==============================================================*\n");

            do
            {
                UI.Print($"Current List Count: {theList.Count}, Capacity: {theList.Capacity}");
                UI.Print("What would you to do?: ");
                string input = UI.GetInput();

                char nav = input[0];
                string value = input.Substring(1);// Get the rest of the input after the first character
                switch (nav)
                {
                    case '+':
                        {
                            theList.Add(value); // Add the input to the list
                            UI.Print("Please enter a name to add:");
                            break;
                        }
                    case '-':
                        {
                            theList.Remove(value);
                            UI.Print("Please enter a name to remove:");
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
