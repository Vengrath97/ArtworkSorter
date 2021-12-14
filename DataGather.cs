using System;

namespace VenConSort
{
    class DataGather
    {
        //Requires user to provide a string that has int-type value
        public static int InputINT()
        {
            while (true)
            {
                string userData = Console.ReadLine();
                if (int.TryParse(userData, out int value)) 
                { 
                    return value; 
                }
                else 
                { 
                    Console.WriteLine("DataGather Error 001: user input data is not int-type."); 
                }
            }
        }

        //Requires user to provide a string with minimal amout of characters defined by input int min value
        public static string InputMIN(int min = 1, bool showError = true)
        {
            while (true)
            {
                string userData = Console.ReadLine();
                if (userData.Length >= min) 
                { 
                    return userData; 
                }
                else if (showError == true) 
                {
                    Console.WriteLine($"DataGather Error 002: user input data is required to be at least {min} characters long."); 
                }
            }
        }
    }
}
