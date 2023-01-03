namespace Lab4_GraphicEditor;

public class Rectangle : IShape
{
    private double sideA, sideB;

    public Rectangle(double a, double b)
    {
        this.sideA = a;
        this.sideB = b;
    }
    
    public double GetArea()
    {
        return this.sideA * this.sideB;
    }

    public double GetPerimeter()
    {
        return 2 * (sideA + sideB);
    }

    public void Draw()
    {
        Console.WriteLine("A rectangle with area "+this.GetArea()+" cm2 and perimeter "+this.GetPerimeter()+" cm was drawn.");
    }
}
