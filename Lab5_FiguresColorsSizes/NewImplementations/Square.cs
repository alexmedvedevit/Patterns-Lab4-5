namespace Lab4_GraphicEditor;

public class Square : IShape
{
    private double SideA;
    private IColor Color;
    private ISize Size;

    public Square(double a, IColor color, ISize size)
    {
        this.SideA = a;
        this.Color = color;
        this.Size = size;
    }
    
    public double GetArea()
    {
        return this.SideA * this.SideA;
    }

    public double GetPerimeter()
    {
        return 4 * this.SideA;
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
        Console.WriteLine("A "+this.GetSize().GetName()+" square with area "+this.GetArea()+" cm2 and perimeter "+this.GetPerimeter()+" cm was drawn.");
        this.GetColor().Paint();
        Console.WriteLine("Now we have a "+this.GetSize().GetName()+" "+this.GetColor().GetName()+" square.");
        Console.WriteLine("///////////////////////////////////");
    }
}
