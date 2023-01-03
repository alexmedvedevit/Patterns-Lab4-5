namespace Lab4_GraphicEditor;

public class CommonSize:ISize
{
    private string Name;

    public CommonSize()
    {
        this.Name = "Common";
    }

    public string GetName()
    {
        return this.Name;
    }
}