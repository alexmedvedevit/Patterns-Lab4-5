namespace Lab4_GraphicEditor;

public class Adapter: Ellipse, IShape
{
    public Adapter(double a, double b) : base(a, b)
    {
    }

    public double GetArea()
    {
        return 2 * Math.PI * Math.Sqrt((this.semiaxisA*this.semiaxisA+this.semiaxisB*this.semiaxisB)/2);
    }

    public double GetPerimeter()
    {
        return Math.PI * this.semiaxisB * this.semiaxisA;
    }

    public void Draw()
    {
        this.Calculate();
    }
}