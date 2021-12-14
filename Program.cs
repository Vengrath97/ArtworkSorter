using System;
using System.Collections.Generic;
using System.IO;

namespace VenConSort
{
    class Program
    {
        static void Main()
        {
            FileService.MakeSureAllFilesThatAreRequiredForThisProgramToWorkExistAndCreateThemIfTheyDontAndThenLoadDataThatIsContainedWithinThemToProgramMemory(Memory.MovielistPath, Memory.SonglistPath);
            while (true) { MainMenu.MenuChoice(); }
        }
    }
}