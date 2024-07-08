using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("blue", 2);
        Rectangle r1 = new Rectangle("yellow",3,6);
        Circle c1= new Circle("purple", 5);

        // Console.WriteLine(square1.GetArea());
        // Console.WriteLine(square1.GetColor());

        // Console.WriteLine(r1.GetArea());
        // Console.WriteLine(r1.GetColor());

        // Console.WriteLine(c1.GetArea());
        // Console.WriteLine(c1.GetColor());

        shapes.Add(square1);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"{color} - {area}");
        }


    }
}