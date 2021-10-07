using BLL;
using System;
using System.Collections.Generic;
using Xunit;

namespace Theory.ClassData.TestProject.ClassData
{
    class ServiceOrientationTestData2:TheoryData<Orientation,Direction>
    {
        public ServiceOrientationTestData2()
        {
            Add(Orientation.North, Direction.Up);
            Add(Orientation.East, Direction.Right);
            Add(Orientation.South, Direction.Down);
            Add(Orientation.West, Direction.Left);


        }
    }
}
