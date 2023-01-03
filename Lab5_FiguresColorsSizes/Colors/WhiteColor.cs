using System.Drawing;

namespace Lab4_GraphicEditor;

public class WhiteColor:IColor
{
    private string Name;

    public WhiteColor()
    {
        this.Name = "White";
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