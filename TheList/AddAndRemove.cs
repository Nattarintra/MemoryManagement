using SkalProj_Datastrukturer_Minne.ConsoleUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkalProj_Datastrukturer_Minne.TheList
{
    internal class AddAndRemove
    {
        public static void AddAndRemoveFromList()
        {

            //QA Summury:
            /*
             * 1. Skriv klart implementationen av ExamineList-metoden så att undersökningen blir 
                genomförbar. 
                2.       När ökar listans kapacitet? (Alltså den underliggande arrayens storlek) :: 4 
                3.       Med hur mycket ökar kapaciteten? :: Duobles 4 -> 8 -> 16 -> 32 -> 64 osv.
                4.       Varför ökar inte listans kapacitet i samma takt som element läggs till? :: finns plats för 4 element i en array,
                6.       När är det då fördelaktigt att använda en egendefinierad array istället för en lista?:: När du vet exact lists

           

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
                UI.Print("What would you like to do?: ");
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
