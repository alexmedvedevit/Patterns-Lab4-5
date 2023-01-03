namespace Lab4_GraphicEditor;

public class SmallSize:ISize
{
    private string Name;

    public SmallSize()
    {
        this.Name = "Small";
    }

    public string GetName()
    {
        return this.Name;
    }
}