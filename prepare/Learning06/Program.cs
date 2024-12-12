using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square i1 =new Square("Blue", 3);
        shapes.Add(i1);

        Rectangle i2 = new Rectangle("Red",22,12);
        shapes.Add(i2);

        Circle i3 = new Circle ("black",80);
        shapes.Add(i3);

        foreach ( Shape i in shapes)
        {
            string color = i.GetColor();
            double area = i.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");

        }
    }
}