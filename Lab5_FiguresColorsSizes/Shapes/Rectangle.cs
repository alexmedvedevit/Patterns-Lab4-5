namespace Lab4_GraphicEditor;

public class Rectangle : IShape
{
    private double sideA, sideB;
    private IColor Color;
    private ISize Size;

    public Rectangle(double a, double b, IColor color, ISize size)
    {
        this.sideA = a;
        this.sideB = b;
        this.Color = color;
        this.Size = size;
    }
    
    public double GetArea()
    {
        return this.sideA * this.sideB;
    }

    public double GetPerimeter()
    {
        return 2 * (sideA + sideB);
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
        Console.WriteLine("A "+this.GetSize().GetName()+" rectangle with area "+this.GetArea()+" cm2 and perimeter "+this.GetPerimeter()+" cm was drawn.");
        this.GetColor().Paint();
        Console.WriteLine("Now we have a "+this.GetSize().GetName()+" "+this.GetColor().GetName()+" rectangle.");
        Console.WriteLine("///////////////////////////////////");
    }
}
