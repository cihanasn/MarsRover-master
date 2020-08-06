using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public enum CommandType
    {
        Left = 'L', Right = 'R', Forward = 'M'
    }

    public enum DirectionType
    {
        North = 'N', South = 'S', West = 'W', East = 'E'
    }

    public abstract class Vehicle
    {
        public Position position { get; set; }
        public DirectionType directionType { get; set; }

        public abstract void ShowFinalCoordinate();

    }

    public class Rover : Vehicle
    {


        public override void ShowFinalCoordinate()
        {
            //Rover
            Console.WriteLine(" * ------ Rover Output ------ * ");
            Console.WriteLine(position.x + " " + position.y + " " + (char)directionType);

        }

    }




}
