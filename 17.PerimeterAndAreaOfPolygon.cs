namespace _17.PerimeterAndAreaOfPolygon
{
    using System;
    /*
     * Write a program that calculates the perimeter and the area of given polygon (not necessarily convex) consisting of n floating-point coordinates in the 2D plane. Print the result rounded to two decimal digits after the decimal point. Use the input and output format from the examples. To hold the points, define a class Point(x, y). To hold the polygon use a Polygon class which holds a list of points. Find in Internet how to calculate the polygon perimeter and how to calculate the area of a polygon. 
     */
    class PerimeterAndAreaOfPolygon
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Polygon polygon = new Polygon();
            polygon = Initialize(n);

            PerimeterOfPolygon(polygon);
            AreaOfPolygon(polygon);
        }

        private static void PerimeterOfPolygon(Polygon polygon)
        {
            double answer = 0;
            for (int i = 0; i < polygon.listOfPoints.Count; i++)
            {
                double x1 = polygon.listOfPoints[i % polygon.listOfPoints.Count].X;
                double x2 = polygon.listOfPoints[(i + 1) % polygon.listOfPoints.Count].X;
                double distanceX = (x1 - x2);
                double y1 = polygon.listOfPoints[i % polygon.listOfPoints.Count].Y;
                double y2 = polygon.listOfPoints[(i + 1) % polygon.listOfPoints.Count].Y;
                double distanceY = (y1 - y2);

                answer += Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
            }
            Console.WriteLine("perimeter = {0:F2}", answer);
        }

        private static void AreaOfPolygon(Polygon polygon)
        {
            double answer = 0;
            for (int i = 0; i < polygon.listOfPoints.Count - 1; i++)
            {
                answer += (polygon.listOfPoints[i].X * polygon.listOfPoints[i + 1].Y) - (polygon.listOfPoints[i].Y * polygon.listOfPoints[i + 1].X);
            }
            Console.WriteLine("area = {0:F2}", Math.Abs(answer / 2));
        }

        private static Polygon Initialize(int n)
        {
            Polygon polygon = new Polygon();
            string input = Console.ReadLine();
            string[] currentRow;
            Point point;
            while (input != "")
            {
                currentRow = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                point = new Point(double.Parse(currentRow[0]), double.Parse(currentRow[1]));
                polygon.listOfPoints.Add(point);
                input = Console.ReadLine();
            }
            return polygon;
        }
    }
}
