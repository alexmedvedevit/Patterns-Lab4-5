using System.Drawing;

namespace Lab4_GraphicEditor;

public class RedColor:IColor
{
    private string Name;

    public RedColor()
    {
        this.Name = "Red";
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