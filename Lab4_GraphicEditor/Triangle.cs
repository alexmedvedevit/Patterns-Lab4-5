namespace Lab4_GraphicEditor;

public class Triangle : IShape
{
    private double sideA, sideB, sideC;
    
    public Triangle(double a, double b, double c)
    {
        this.sideA = a;
        this.sideB = b;
        this.sideC = c;
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

    public void Draw()
    {
        Console.WriteLine("A triangle with area "+this.GetArea()+" cm2 and perimeter "+this.GetPerimeter()+" cm was drawn.");
    }
}
