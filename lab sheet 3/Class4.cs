using System;

public class Shape
{
    
    protected string shapeType;
    protected double area;

    public Shape(string shapeType)
    {
        this.shapeType = shapeType;
    }

    public virtual void CalculateArea(double val1, double val2 = 0)
    {
        
    }

    public virtual void DisplayShapeInfo()
    {
        Console.WriteLine($"Shape Type: {shapeType}");
        Console.WriteLine($"Area: {area}");
    }
}

public class Rectangle : Shape
{
    
    private double length;
    private double width;

    
    public Rectangle(double length, double width) : base("Rectangle")
    {
        this.length = length;
        this.width = width;
        CalculateArea(length, width);
    }

    
    public override void CalculateArea(double val1, double val2 = 0)
    {
        area = val1 * val2;
    }
}

public class Circle : Shape
{
    
    private double radius;

    
    public Circle(double radius) : base("Circle")
    {
        this.radius = radius;
        CalculateArea(radius);
    }

    
    public override void CalculateArea(double val1, double val2 = 0)
    {
        area = Math.PI * val1 * val1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Rectangle rectangle = new Rectangle(5, 3);
        
        rectangle.DisplayShapeInfo();

        Console.WriteLine();

        Circle circle = new Circle(4);
        circle.DisplayShapeInfo();
    }
}