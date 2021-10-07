using System;

namespace BLL
{
    public class ServiceOrientation
    {
        public static Orientation ToOrientation(Direction direction) => direction switch
        {
            Direction.Up    => Orientation.North,
            Direction.Right => Orientation.East,
            Direction.Down  => Orientation.South,
            Direction.Left  => Orientation.West,
            _ => throw new ArgumentOutOfRangeException(nameof(direction), $"Not expected direction value: {direction}"),
        };
    }
}