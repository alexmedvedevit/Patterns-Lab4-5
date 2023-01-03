using System.Drawing;

namespace Lab4_GraphicEditor;

public class BlueColor:IColor
{
    private string Name;

    public BlueColor()
    {
        this.Name = "Blue";
    }

    public string GetName()
    {
        return this.Name;
    }

    public void Paint()
    {
        Console.WriteLine("Painting the shape "+this.Name);
    }
}