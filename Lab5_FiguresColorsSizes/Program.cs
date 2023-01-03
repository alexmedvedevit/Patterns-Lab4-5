// See https://aka.ms/new-console-template for more information

using Lab4_GraphicEditor;

IShape CommonRedTriangle = new Triangle(3,3,3,new RedColor(),new CommonSize());
CommonRedTriangle.Draw();

IShape BigBlueCircle = new Circle(9, new BlueColor(), new BigSize());
BigBlueCircle.Draw();


// Для расширения класса был добавлен чёрный цвет, маленький размер и фигура квадрат

IShape SmallBlackRectangle = new Rectangle(1,2,new BlackColor(),new SmallSize());
SmallBlackRectangle.Draw();

IShape BigWhiteSquare = new Square(15,new WhiteColor(),new BigSize());
BigWhiteSquare.Draw();
