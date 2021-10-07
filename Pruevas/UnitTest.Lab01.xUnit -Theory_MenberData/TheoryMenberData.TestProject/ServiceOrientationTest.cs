using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using TheoryMenberData.TestProject.TestData;
using Xunit;

namespace TheoryMenberData.TestProject
{
    public class ServiceOrientationTest
    {
        #region Implementacion 01

        ///Ambito Global de la Clase de Prueva
        public static IEnumerable<object[]> Data => new List<object[]>
          {
          new object[]{ Orientation.North, Direction.Up },
          new object[]{ Orientation.East, Direction.Right },
          new object[]{ Orientation.South, Direction.Down },
          new object[]{ Orientation.West, Direction.Left }

         };
        [Fact]
        public void ToOrientation_ThrowsArgumentOutRangeExceptionTest01()
        {
            //Arrange
            var serviceOrientation = new ServiceOrientation();
            const string value = "-1";
            var direction = (Direction)Enum.Parse(typeof(Direction), value);
            ///Act
            //Assert
            ArgumentOutOfRangeException argumentOutOfRangeException = Assert.Throws<ArgumentOutOfRangeException>(() => serviceOrientation.ToOrientation(direction));
            Assert.Contains("Not expected direction value:", argumentOutOfRangeException.Message);

        }
        [Theory]
        [MemberData(nameof(Data))]

        public void ToOrientationTest(Orientation orientation, Direction direction)
        {
            //Arange
            var serviceOrientation = new ServiceOrientation();

            //Act
            var result = serviceOrientation.ToOrientation(direction);
            //Assert
            Assert.Equal(orientation, result);
        }

        #endregion
        #region Implementacion 02

        ///Ambito Global de la Clase de Prueva
        public static IEnumerable<object[]> GetData(int tests) {
            var data = new List<object[]>
          {
          new object[]{ Orientation.North, Direction.Up },
          new object[]{ Orientation.East, Direction.Right },
          new object[]{ Orientation.South, Direction.Down },
          new object[]{ Orientation.West, Direction.Left }

           };
            return data.Take(tests);
        }
        
        [Theory]
        [MemberData(nameof(GetData),2)]
        public void ToOrientationWithGetDataParanetersTest2(Orientation orientation ,Direction direction) 
        {
            ///Arrage
            var serviceOrientation = new ServiceOrientation();
            //Act
            var result = serviceOrientation.ToOrientation(direction);
            //Assert
            Assert.Equal(orientation,result);
        
        
        }
        [Fact]
        public void ToOrientation_ThrowsArgumentOutRangeExceptionTest02()
        {
            //Arrange
            var serviceOrientation = new ServiceOrientation();
            const string value = "-1";
            var direction = (Direction)Enum.Parse(typeof(Direction), value);
            ///Act
            //Assert
            ArgumentOutOfRangeException argumentOutOfRangeException = Assert.Throws<ArgumentOutOfRangeException>(() => serviceOrientation.ToOrientation(direction));
            Assert.Contains("Not expected direction value:", argumentOutOfRangeException.Message);

        }
        #endregion
        #region Implementacion 03

        [Theory]
        [MemberData(nameof(ServiceOrientationTestData.Data), MemberType= typeof(ServiceOrientationTestData))]
        public void ToOrientation_ThrowsArgumentOutRangeExceptionTestImplementacion03(Orientation orientation,Direction direction)
        {
            ///Arrage
            var serviceOrientation = new ServiceOrientation();
            //Act
            var result = serviceOrientation.ToOrientation(direction);
            //Assert
            Assert.Equal(orientation, result);
           
        }
        [Fact]
        public void ToOrientation_ThrowsArgumentOutRangeExceptionTest03()
        {
            //Arrange
            var serviceOrientation = new ServiceOrientation();
            const string value = "-1";
            var direction = (Direction)Enum.Parse(typeof(Direction), value);
            ///Act
            //Assert
            ArgumentOutOfRangeException argumentOutOfRangeException = Assert.Throws<ArgumentOutOfRangeException>(() => serviceOrientation.ToOrientation(direction));
            Assert.Contains("Not expected direction value:", argumentOutOfRangeException.Message);

        }
        #endregion

    }
}
