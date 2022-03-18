using System;
// Importing name space to create dictionaries.
using System.Collections.Generic;

namespace wire_color
{
    class wire_color
    {
        static void Main(string[] args)
        {
            // Creating arrays containing keys for each phase.
            int[] phase_A_Keys = {1, 2};
            int[] phase1_B_Keys = {0, 3, 4};
            int[] phase3_B_Keys = {3, 4};
            int[] phase_C_Keys = {0, 5, 6};

            /* Creating a dictionary and running "for each" statements on
               the arrays above to assign multiple keys to each value.*/
            Dictionary<int, string> low_Volt_Colors =
                new Dictionary<int, string>();
            foreach (int num in phase_A_Keys)
            {
                low_Volt_Colors.Add(num, "black");
            }
            foreach (int num in phase3_B_Keys)
            {
                low_Volt_Colors.Add(num, "red");
            }
            foreach (int num in phase_C_Keys)
            {
                low_Volt_Colors.Add(num, "blue");
            }

            Dictionary<int, string> high_Volt_Colors =
                new Dictionary<int, string>();
            foreach (int num in phase_A_Keys)
            {
                high_Volt_Colors.Add(num, "brown");
            }
            foreach (int num in phase3_B_Keys)
            {
                high_Volt_Colors.Add(num, "orange");
            }
            foreach (int num in phase_C_Keys)
            {
                high_Volt_Colors.Add(num, "yellow");
            }

            Dictionary<int, string> single_Phase_Colors =
                new Dictionary<int, string>();
            foreach (int num in phase_A_Keys)
            {
                single_Phase_Colors.Add(num, "black");
            }
            foreach (int num in phase1_B_Keys)
            {
                single_Phase_Colors.Add(num, "red");
            }

            // Creating a control variable.
            string loop = "y";

            /* Creating loop that allows users to run program multiple times
               without ending execution.*/
            while (loop == "y" || loop == "Y")
            {
                /* Implementing exception handling to catch format exceptions
                   that may occer throughout the program.*/ 
                try
                {
                    Console.WriteLine("Please enter a circuit number.");
                    Console.WriteLine("NOTE: Enter number in standard form.");
                    int ckt_Num = Convert.ToInt32(Console.ReadLine());

                    /* If the user enters any number below 1, the progrm will
                       print a note and skip to the next iteration.*/
                    if(ckt_Num < 1)
                    {
                        Console.WriteLine(
                            "\nNOTE: Circuit numbers range from 1 and up.\n");
                        continue;
                    }

                    Console.WriteLine(
                    "\nIs this a single phase or three phase circuit?");
                    Console.WriteLine(
                        "NOTE: SINGLE PHASE = '1'\n      THREE PHASE = '3'\n");
                    Console.Write("Please specify phase system: ");
                    string phase = Console.ReadLine();
                    Console.WriteLine();

                    if (phase == "3")
                    {
                        Console.WriteLine("\nWhat is the circuit's voltage?");
                        Console.WriteLine(
                            "NOTE: Three Phase Voltage Standards: " +
                            "120, 208, 240, 277, 480\n");
                        Console.Write("Please enter a voltage: ");
                        string volt = Console.ReadLine();
                        Console.WriteLine();

                        if (volt == "120" || volt == "208" || volt == "240")
                        {
                            Console.Write("Your wire color is ");
                            Console.Write(low_Volt_Colors[ckt_Num % 6] + ".");
                        }
                        else if (volt == "277" || volt == "480")
                        {
                            Console.Write("Your wire color is ");
                            Console.Write(high_Volt_Colors[ckt_Num % 6] + ".");
                        }
                        /* If the user enters anything other than the
                           voltages listed above, the program will print a
                           a message and skip to the next iteration.*/
                        else
                        {
                            Console.WriteLine("Invalid input\n");
                            continue;
                        }
                    }
                    else if (phase == "1")
                    {
                        Console.Write("Your wire color is ");
                        Console.Write(single_Phase_Colors[ckt_Num % 4] + ".");
                    }
                    /* The program will print a message and skip to the next
                       iteration if neither '1' or '3' were entered.*/
                    else
                    {
                        Console.WriteLine("Invalid input\n");
                        continue;
                    }
                }
                /* Catches exception when user does not enter an integer and
                   skips to the next iteration.*/
                catch (FormatException)
                {
                    Console.WriteLine("\nERROR: Please use integers only.\n");
                    continue;
                }

                // Value of "loop" variable is changed to prevent infinite loop.
                loop = "";

                // "While" loop continues to run till user answers yes or no.
                while(loop != "y"   
                      && loop != "Y"
                      && loop != "n"
                      && loop != "N")
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Would you like to try another circuit?\n"
                        + "NOTE: YES = 'y'/'Y', NO = 'n'/'N'");
                    loop = Console.ReadLine();
                    Console.WriteLine("\n");
                    if (loop != "y"
                        && loop != "Y"
                        && loop != "n"
                        && loop != "N")
                    {
                        Console.WriteLine("Invalid input");
                    }
                }
            }
        }
    }
}
