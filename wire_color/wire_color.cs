using System;
using System.Collections.Generic;

namespace wire_color
{
    class wire_color
    {
        static void Main(string[] args)
        {
            int[] phase_A_Keys = {1, 2};
            int[] phase1_B_Keys = {0, 3, 4};
            int[] phase3_B_Keys = {3, 4};
            int[] phase_C_Keys = {0, 5, 6};

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

            Console.Write("Please enter a circuit number: ");
            int ckt_Num = Convert.ToInt32(Console.ReadLine());

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
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            else if (phase == "1")
            {
                Console.Write("Your wire color is ");
                Console.Write(single_Phase_Colors[ckt_Num % 4] + ".");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
