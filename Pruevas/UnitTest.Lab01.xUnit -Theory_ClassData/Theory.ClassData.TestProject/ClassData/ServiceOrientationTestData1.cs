using BLL;
using System;
using System.Collections;
using System.Collections.Generic;


namespace Theory.ClassData.TestProject.ClassData
{
    public class ServiceOrientationTestData1 : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] { Orientation.North, Direction.Up };
            yield return new object[] { Orientation.East, Direction.Right };
            yield return new object[] { Orientation.South, Direction.Down };
            yield return new object[] { Orientation.West, Direction.Left };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}

