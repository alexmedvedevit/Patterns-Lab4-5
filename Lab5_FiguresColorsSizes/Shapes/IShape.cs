namespace Lab4_GraphicEditor;

public interface IShape
{
    double GetArea();
    double GetPerimeter();
    IColor GetColor();
    ISize GetSize();
    void Draw();
}