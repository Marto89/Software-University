﻿namespace _17.PerimeterAndAreaOfPolygon
{
    using System;
    public class Point
    {
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double X { get; private set; }
        public double Y { get; private set; }
    }
}
