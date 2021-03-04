using System;
using GeometryLib;
using Xunit;

namespace GeometryLibTests
{
    public class GeometryTests
    {
        [Fact]
        public void CanCalculateAreaOfCircle()
        {
            double area;
            
            area = Geometry.AreaOf(10);
            
            Assert.Equal(314.16, Math.Round(area, 2));
        }

        [Fact]
        public void ExceptionNegativeZeroRadius()
        {
            double area;

            Action act = () => area = Geometry.AreaOf(0);
            Action act2 = () => area = Geometry.AreaOf(-15);

            Assert.Throws<GeometricException>(act);
            Assert.Throws<GeometricException>(act2);
        }

        [Fact]
        public void CanCalculateAreaOfTriangle()
        {
            double area;

            area = Geometry.AreaOf(5, 5, 5);
            
            Assert.Equal(10.83, Math.Round(area, 2));
        }

        [Fact]
        public void ExceptionIncorrectSidesOfTriangle()
        {
            double area;

            Action act = () => area = Geometry.AreaOf(5, 2, 3);
            Action act2 = () => area = Geometry.AreaOf(1, 2, -3);

            Assert.Throws<GeometricException>(act);
            Assert.Throws<GeometricException>(act2);
        }

        [Fact]
        public void CanDetermineRightOrNot()
        {
            bool checkRight = false;

            checkRight = Geometry.IsRightTriangle(5, 3, 4);
            
            Assert.True(checkRight);
        }
    }
}