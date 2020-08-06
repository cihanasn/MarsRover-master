using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Test
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void MarsRover_Process_Failed_Test()
        {
            string[] expected = 
            {
                "1 3 N",
                "5 1 E"
            };

            //Requests
            Processor processor = new Processor();
            List<Vehicle> vehicles = new List<Vehicle>();

            string upperRightCoordinates = "5 5";

            string restOfInput_Line1 = "1 2 N";
            string restOfInput_Line2 = "LMLMLMLMM";

            vehicles.Add(processor.Process(upperRightCoordinates.Split(' ').ToArray(), restOfInput_Line1, restOfInput_Line2));

            restOfInput_Line1 = "3 3 E";
            restOfInput_Line2 = "MMRMMRMRRM";

            vehicles.Add(processor.Process(upperRightCoordinates.Split(' ').ToArray(), restOfInput_Line1, restOfInput_Line2));

            Assert.AreEqual(expected[0], vehicles[0].ShowFinalCoordinate());
            Assert.AreEqual(expected[1], vehicles[1].ShowFinalCoordinate());
        }

    }
}
