using System;

namespace VenConSort
{
    class DataGather
    {
        // Change to false to not show errors, and just skip to re-requesting
        // input in all functions in this class
        //
        // Note, that you can also delete lanes with if (showError) condition
        static readonly bool showError = true;
        //Requires user to provide a string that has int-type value
        public static int InputINT()
        {
            while (true)
            {
                string userData = Console.ReadLine();
                if (int.TryParse(userData, out int value)) { return value; }
                if (showError) { Console.WriteLine("Error: user data is not int-type."); }
            }
        }
        //Requires user to provide a string with minimal amout of characters defined by input int min value
        public static string InputMIN(int min = 1)
        {
            while (true)
            {
                string userData = Console.ReadLine();
                if (userData.Length >= min) { return userData; }
                if (showError) { Console.WriteLine($"Error: user input data is required to be at least {min} characters."); }
            }
        }
    }
}