namespace Lab4_GraphicEditor;

public class Triangle : IShape
{
    private double sideA, sideB, sideC;
    private IColor Color;
    private ISize Size;
    
    public Triangle(double a, double b, double c, IColor color, ISize size)
    {
        this.sideA = a;
        this.sideB = b;
        this.sideC = c;
        this.Color = color;
        this.Size = size;
    }
    
    public double GetArea()
    {
        double halfPer = this.GetPerimeter()/2;
        return Math.Sqrt(halfPer*(halfPer-this.sideA)*(halfPer-this.sideB)*(halfPer-this.sideC));
    }

    public double GetPerimeter()
    {
        return sideA + sideB + sideC;
    }
    
    public IColor GetColor()
    {
        return this.Color;
    }

    public ISize GetSize()
    {
        return this.Size;
    }
    public void Draw()
    {
        Console.WriteLine("A "+this.GetSize().GetName()+" triangle with area "+this.GetArea()+" cm2 and perimeter "+this.GetPerimeter()+" cm was drawn.");
        this.GetColor().Paint();
        Console.WriteLine("Now we have a "+this.GetSize().GetName()+" "+this.GetColor().GetName()+" triangle.");
        Console.WriteLine("///////////////////////////////////");
    }
}
