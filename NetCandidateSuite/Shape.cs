using System;
using System.Collections.Generic;
using System.Text;

namespace NetCandidateSuite
{
    public class Shape
    {
        protected int NumberOfSides;

        public Shape(int sideCount)
        {
            NumberOfSides = sideCount;
        }
        
        public virtual string GetDescription()
        {
            return String.Format("{0}: I have {1} sides!", this.GetType().ToString(), NumberOfSides);
        }
    }

    public class Triangle : Shape
    {
        private const int SIDE_COUNT = 3;

        public enum TriangleType
        {
            Isosceles,
            Equilateral,
            Scalene,
            Acute,
            Obtuse
        }

        public TriangleType Type { get; private set; }

        private Triangle(TriangleType type, int sideCount) : base(sideCount)
        {
            Type = type;
        }
        
        public Triangle(TriangleType type) : this(type, SIDE_COUNT)
        {
            
        }
    }

    /// <summary>
    /// Change it so that Circle's GetDescription returns "Circles do not have sides!"
    /// </summary>
    public class Circle : Shape
    {
        public Circle(int sideCount) : base(sideCount)
        {
        }

        public override string GetDescription()
        {
            return "Circles do not have sides!";
        }
    }
}
