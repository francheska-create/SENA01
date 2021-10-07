using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheoryCustomAttributeTestProject.DataAttribute;
using Xunit;
using BLL;

namespace TheoryCustomAttributeTestProject.TestsData
{
    public class ToOrientationTest
    {
        [Theory]
        [CsvData("InputData.csv")]
        public void ToOrientationWhisthcsvTestData(string orientation, string direction)
        {
            ///Arrage
            var orientations = (Orientation)Enum.Parse(typeof(Orientation), orientation);
            var directions = (Direction)Enum.Parse(typeof(Direction), direction);
            var ServiceOrientation = new ServiceOrientation();

            ///Act
            var result = ServiceOrientation.ToOrientation(directions);
            ///Assert
            Assert.Equal(orientations, result);
        }
        [Fact]
        public void ToOrientation_TrowsArgumentOutofRangeExceptionTest()
        {

            ///Arange
            var serviceOrientation = new ServiceOrientation();
            const string Value = "-1";
            var direction = (Direction)Enum.Parse(typeof(Direction), Value);
            ///Act

            ///Assert
            var argumentOutOfRangeException = Assert.Throws<ArgumentOutOfRangeException>(() => ServiceOrientation.ToOrientation(direction));
            Assert.Contains("Not expected direction value:", argumentOutOfRangeException.Message);





        }
       
    }
}