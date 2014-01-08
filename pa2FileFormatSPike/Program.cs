
using System;
using System.IO;
using System.Linq;

namespace pa2FileFormatSPike
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"D:\Allen\Code\EDF\edf\spanparameters\cme.20131206.a.pa2\cme.20131206.a.pa2";
            var fileParser = new Pa2FileParser();


            fileParser.Parse(file);

            var distinctFirstcharacterofEachLine = File.ReadAllLines(file).Select(l => l.First()).Distinct().OrderBy(s => s).ToList();

            foreach (var c in distinctFirstcharacterofEachLine)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
