namespace Lab4_GraphicEditor;

public class Ellipse
{
    protected double semiaxisA;
    protected double semiaxisB;
    private double perimeter, area;

    public Ellipse(double a, double b)
    {
        this.semiaxisA = a;
        this.semiaxisB = b;
    }

    public void Calculate()
    {
        this.perimeter = 2 * Math.PI * Math.Sqrt((this.semiaxisA*this.semiaxisA+this.semiaxisB*this.semiaxisB)/2);
        this.area = Math.PI * this.semiaxisB * this.semiaxisA;
        this.Apply();
    }

    public void Apply()
    {
        Console.WriteLine("An ellipse with area "+this.area+" cm2 and perimeter "+this.perimeter+" cm was drawn.");
    }
}