using System;
using System.Formats.Asn1;
using System.Linq.Expressions;
using Unit_Test_Frameworks;

namespace TaskOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write line, please");
            string line = Console.ReadLine();

            int count1 = StringActions.CountUnequalSymbols(line);
            int count2 = StringActions.CountEqualLatinLetters(line);
            int count3 = StringActions.CountEqualFigures(line);

            Console.WriteLine("Unequal symbols in string : " + count1);
            Console.WriteLine("Equal Latin letters in string :  " + count2);
            Console.WriteLine("Equal figures in string : " + count3);
        }
    }       
}
