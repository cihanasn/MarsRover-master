using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public static class Extension
    {
        public static void Left90Degrees(this Vehicle vehicle)
        {
            switch (vehicle.directionType)
            {
                case DirectionType.North:
                    vehicle.directionType = DirectionType.West;
                    break;
                case DirectionType.South:
                    vehicle.directionType = DirectionType.East;
                    break;
                case DirectionType.West:
                    vehicle.directionType = DirectionType.South;
                    break;
                case DirectionType.East:
                    vehicle.directionType = DirectionType.North;
                    break;
            }
        }

        public static void Right90Degrees(this Vehicle vehicle)
        {
            switch (vehicle.directionType)
            {
                case DirectionType.North:
                    vehicle.directionType = DirectionType.East;
                    break;
                case DirectionType.South:
                    vehicle.directionType = DirectionType.West;
                    break;
                case DirectionType.West:
                    vehicle.directionType = DirectionType.North;
                    break;
                case DirectionType.East:
                    vehicle.directionType = DirectionType.South;
                    break;
            }
        }

        public static void ForwardOneGridPoint(this Vehicle vehicle)
        {
            switch (vehicle.directionType)
            {
                case DirectionType.North:
                    vehicle.position.y = vehicle.position.y + 1;
                    break;
                case DirectionType.South:
                    vehicle.position.y = vehicle.position.y - 1;
                    break;
                case DirectionType.West:
                    vehicle.position.x = vehicle.position.x - 1;
                    break;
                case DirectionType.East:
                    vehicle.position.x = vehicle.position.x + 1;
                    break;
            }
        }


    }
}
