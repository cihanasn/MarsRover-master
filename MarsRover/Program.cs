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
            //string lowerRightCoordinates = "0 0";

            //Ex:5 5   
            string[] upperRightCoordinates = Console.ReadLine().Trim().Split(' ').ToArray();

            int maxX = Convert.ToInt32(upperRightCoordinates[0]);
            int maxY = Convert.ToInt32(upperRightCoordinates[1]);

            List<Vehicle> vehicles = new List<Vehicle>();

            for(int i = 1; i < 3; i++)
            {
                // * ----- Each Rover ----- * start
                Vehicle rover = new Rover();
                Position position = new Position();

                //First Line
                string restOfInput_Line1 = Console.ReadLine().Trim();
                foreach (char ch in restOfInput_Line1)
                {
                    if (Char.IsNumber(ch))
                    {
                        switch (position.x)
                        {
                            case 0:
                                position.x = int.Parse(ch.ToString());
                                break;
                            default:
                                position.y = int.Parse(ch.ToString());
                                break;
                        }
                    }
                    else
                    {
                        DirectionType directionType = (DirectionType)ch;
                        switch (directionType)
                        {
                            case DirectionType.North:
                                rover.directionType = directionType;
                                break;
                            case DirectionType.South:
                                rover.directionType = directionType;
                                break;
                            case DirectionType.West:
                                rover.directionType = directionType;
                                break;
                            case DirectionType.East:
                                rover.directionType = directionType;
                                break;
                            default:
                                break;
                        }
                    }
                }
                rover.position = position;

                //Second Line
                string restOfInput_Line2 = Console.ReadLine().Trim();
                foreach (char ch in restOfInput_Line2)
                {
                    CommandType cmdType = (CommandType)ch;
                    switch (cmdType)
                    {
                        case CommandType.Left:
                            rover.Left90Degrees();
                            break;
                        case CommandType.Right:
                            rover.Right90Degrees();
                            break;
                        case CommandType.Forward:
                            rover.ForwardOneGridPoint();
                            break;
                        default:
                            break;
                    }
                }




                // * ----- Each Rover ----- * finish
                vehicles.Add(rover);
            }

            foreach(Rover rover in vehicles)
            {
                rover.ShowFinalCoordinate();
            }

           
            
            Console.ReadKey();
        }
    }
}
