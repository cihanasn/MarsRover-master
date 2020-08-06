using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        //Happy Path
        static void Main(string[] args)
        {
            string[] upperRightCoordinates = Console.ReadLine().Trim().Split(' ').ToArray();
            string restOfInput_Line1 = "";
            string restOfInput_Line2 = "";
            Processor processor = new Processor();
            List<Vehicle> vehicles = new List<Vehicle>();
            for( int i = 1; i < 3; i++ )
            {
                restOfInput_Line1 = Console.ReadLine().Trim();
                restOfInput_Line2 = Console.ReadLine().Trim();
                vehicles.Add(processor.Process(upperRightCoordinates, restOfInput_Line1, restOfInput_Line2));
            }
            foreach (Rover rover in vehicles)
            {
                Console.WriteLine(rover.ShowFinalCoordinate());
            }
            Console.ReadKey();
        }
    }
}
