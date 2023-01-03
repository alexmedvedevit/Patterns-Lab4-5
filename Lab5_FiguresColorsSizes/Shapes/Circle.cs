namespace Lab4_GraphicEditor;

public class Circle : IShape
{
    private double Radius;
    private IColor Color;
    private ISize Size;

    public Circle(double r, IColor color, ISize size)
    {
        this.Radius = r;
        this.Color = color;
        this.Size = size;
    }
    
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
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
        Console.WriteLine("A "+this.GetSize().GetName()+" circle with area "+this.GetArea()+" cm2 and perimeter "+this.GetPerimeter()+" cm was drawn.");
        this.GetColor().Paint();
        Console.WriteLine("Now we have a "+this.GetSize().GetName()+" "+this.GetColor().GetName()+" circle.");
        Console.WriteLine("///////////////////////////////////");
    }
}
