namespace LabProject3June28
{
    interface IShape
    {
        public double calculateArea()
        {
            return 0.0;
        }
        public double calculatePerimeter()
        {
            return 0.0;
        }

    }
    class Circle : IShape
    {
        public double radius { get; set; }
        static readonly double PI = 3.14;
        public double calculateArea()
        {
            double area = 0.0;
            area = PI * radius * radius;
            return area;
        }
        public double calculatePerimeter()
        {
            double perimeter = 0.0;
            perimeter = 2 * PI * radius;
            return perimeter;
        }
    }
    class Rectangle : IShape
    {
        public double length { get; set; }
        public double width { get; set; }
        public double calculateArea()
        {
            double area = 0.0;
            area = length * width;
            return area;
        }
        public double calculatePerimeter()
        {
            double perimeter = 0.0;
            perimeter = 2 * (length + width);
            return perimeter;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle r = new Rectangle();
            r.length = 10;
            r.width = 8;
            c.radius = 4;
            Console.WriteLine("The area of the rectangle is " + r.calculateArea().ToString());
            Console.WriteLine("The perimeter of the rectangle is " + r.calculatePerimeter().ToString());
            Console.WriteLine("The area of the circle is " + c.calculateArea().ToString());
            Console.WriteLine("The perimeter of the circle is " + c.calculatePerimeter().ToString());
        }
    }
}
