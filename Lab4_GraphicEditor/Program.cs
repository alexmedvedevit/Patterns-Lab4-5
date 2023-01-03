using System;

namespace Lab4_GraphicEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape triangle = new Triangle(4,4,4),
                rectangle = new Rectangle(5,9);
            triangle.Draw();
            rectangle.Draw();

            IShape ellipse = new Adapter(6, 3);
            ellipse.Draw();
        }
    }
}
