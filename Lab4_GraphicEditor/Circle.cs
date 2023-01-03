namespace Lab4_GraphicEditor;

public class Circle : IShape
{
    private double radius;

    public Circle(double r)
    {
        this.radius = r;
    }
    
    public double GetArea()
    {
        return Math.PI * radius * radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * radius;
    }

    public void Draw()
    {
        Console.WriteLine("A circle with area "+this.GetArea()+" cm2 and perimeter "+this.GetPerimeter()+" cm was drawn.");
    }
}
