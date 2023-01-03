using System.Drawing;

namespace Lab4_GraphicEditor;

public class BlackColor:IColor
{
    private string Name;

    public BlackColor()
    {
        this.Name = "Black";
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