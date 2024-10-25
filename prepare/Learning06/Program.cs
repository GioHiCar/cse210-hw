using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("green", 5);
        shapes.Add(square);
        
        Rectangle rectangle = new Rectangle("blue", 5, 6);
        shapes.Add(rectangle);

        Circle circle = new Circle("yellow", 5);
        shapes.Add(circle);

        foreach(Shape s in shapes){
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape had an area of {area}");
        }
    }
}