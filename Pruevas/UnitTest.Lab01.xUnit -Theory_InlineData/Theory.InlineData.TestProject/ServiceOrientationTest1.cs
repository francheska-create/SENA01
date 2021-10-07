using System;
using Xunit;
using BLL;


namespace Theory.InlineData.TestProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(Orientation.North, Direction.Up)]
        [InlineData(Orientation.East,Direction.Right)]
        [InlineData(Orientation.South, Direction.Down)]
        [InlineData(Orientation.West, Direction.Left)]
        public void ServiceOrientationTest1(Orientation orientation,Direction direction) 
        {
            ///Arrage
            ServiceOrientation serviceOrientation = new ServiceOrientation();

            ///Act
            var result = serviceOrientation.ToOrientation(direction);
            ///Assert
            Assert.Equal(orientation, result);


        
        
        }
    }
}
