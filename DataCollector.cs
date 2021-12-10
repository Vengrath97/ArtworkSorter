using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenConSort
{
    class DataCollector
    {
        public static int DataInt()
        {
            while (true)
            {
                int value;
                string userData = Console.ReadLine();
                if (int.TryParse(userData, out value)) {  return value; }
                else { Console.WriteLine("DataCollector Error1: Wrong data type."); }
            }
        }
        public static string DataMin(int i, bool ShowRequiredCharactersOnFailure = true)
        {
            while (true)
            {
                string userData = Console.ReadLine();
                if (userData.Length >= i) { return userData; }
                else if (ShowRequiredCharactersOnFailure == true)
                {
                    Console.WriteLine($"Wymaga się co najmniej {i} znaków");
                }
            }
        }
    }
}
