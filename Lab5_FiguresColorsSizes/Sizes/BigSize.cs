namespace Lab4_GraphicEditor;

public class BigSize:ISize
{
    private string Name;

    public BigSize()
    {
        this.Name = "Big";
    }

    public string GetName()
    {
        return this.Name;
    }
}