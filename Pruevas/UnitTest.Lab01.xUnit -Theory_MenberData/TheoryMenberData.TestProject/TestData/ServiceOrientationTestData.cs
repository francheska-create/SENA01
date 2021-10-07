using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheoryMenberData.TestProject.TestData
{
    class ServiceOrientationTestData
    {
        public static IEnumerable<object[]> Data => new List<object[]>
          {
          new object[]{ Orientation.North, Direction.Up },
          new object[]{ Orientation.East, Direction.Right },
          new object[]{ Orientation.South, Direction.Down },
          new object[]{ Orientation.West, Direction.Left }

         };
    }
}
