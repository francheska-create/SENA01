using BLL;
using System;
using Theory.ClassData.TestProject.ClassData;
using Xunit;

namespace Theory.ClassData.TestProject
{
    public class ServiceOrientationTest
    {
        [Theory]
        [ClassData(typeof(ServiceOrientationTestData1))]
        public void ToOrientationTest1(Orientation oriention,Direction direction)
        {
            ///Arraje
            ServiceOrientation serviceOrientation = new ServiceOrientation();
            //Act
            var result = serviceOrientation.ToOrientation(direction);
            ///Assert
            Assert.Equal(oriention, result);
        }
        [Theory]
        [ClassData(typeof(ServiceOrientationTestData2))]
        public void ToOrientationTest2(Orientation oriention, Direction direction)
        {
            ///Arraje
            ServiceOrientation serviceOrientation = new ServiceOrientation();
            //Act
            var result = serviceOrientation.ToOrientation(direction);
            ///Assert
            Assert.Equal(oriention, result);
        }
    }
}
