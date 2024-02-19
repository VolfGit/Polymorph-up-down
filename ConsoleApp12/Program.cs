//Задание: Иерархия геометрических фигур

//Создайте базовый класс Shape с двумя свойствами: Name(строка) и Area(вещественное число). Этот класс будет представлять общие характеристики для всех геометрических фигур.

//Отнаследуйте от класса Shape три класса: Circle, Rectangle и Triangle. Каждый из этих классов должен иметь свои уникальные свойства и методы.

//Circle должен иметь радиус и метод для вычисления площади круга.
//Rectangle должен иметь длину и ширину, а также метод для вычисления площади прямоугольника.
//Triangle должен иметь три стороны и метод для вычисления площади треугольника.
//Создайте объекты каждого из классов и выведите информацию о них, включая их тип, имя и площадь.

//Попробуйте использовать полиморфизм, создав массив или список базового класса Shape и добавив в него объекты всех трех классов. Затем выполните итерацию по массиву и выведите информацию о каждой фигуре.

//Разработайте еще один производный класс от Shape по вашему выбору и добавьте его в массив. Убедитесь, что ваш код поддерживает расширяемость и работу с новыми типами фигур.

//Попробуйте выполнить это задание, а если у вас возникнут вопросы или трудности, не стесняйтесь спрашивать.

//Повыщающие приведение:
//Добавим класс Student, производный от Shape.
//Класс Student будет представлять студента с именем и средней оценкой. 
//Затем мы создадим объект Student и добавим его в массив Shape.
//Таким образом, мы будем использовать повышающее приведение.


//Понижающие приведение:

//if (shape is Square)
//{
//    Square square1 = (Square)shape;
//    Console.WriteLine("Square side" + square1.Side);
//}

class Square : Shape
{
    public int Side { get; set; }

    public override double AreaCount()
    {
        double Area = Side * Side;
        return Area;
    }
}
class Student : Shape
{
    public string studentName { get; set; }

}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Branch Slave");



        Student student = new Student();

        Circle circle = new Circle
        {
            Name = "Edi",
            radius = 22
        };
        Rectangle rectangle = new Rectangle
        {
            Name = "Bob",
            width = 21,
            height = 22,

        };
        Triangle triangle = new Triangle
        {
            Name = "Helo",

        };

        Hexagon hexagon = new Hexagon
        {

            Name = "Hexik",


        };


        List<Shape> shapeList = new List<Shape>()
        {


        };
        shapeList.Add(circle);
        shapeList.Add(triangle);
        shapeList.Add(rectangle);
        shapeList.Add(hexagon);
        shapeList.Add(student);


        Square square = new Square
        {
            Name = "Square1",
            Side = 10
        };

        shapeList.Add(square);

        //for( int i = 0; i < shapeList.Count; i++ )
        //{

        //    shapeList[i].PrintInfo(shapeList[i]);
        //}

        foreach (Shape shape in shapeList)
        {

            if (shape is Square)
            {
                Square square1 = (Square)shape;
                Console.WriteLine("Square side" + square1.Side);
            }




            else
            {


                shape.PrintInfo(shape);
            }
        }

    }


}

class Shape
{

    public string? Name { get; set; }

    public virtual double AreaCount()
    { return 0; }
    public void PrintInfo(Shape obj)
    {

        Console.WriteLine($"Type of Shape:{obj.GetType().Name} Name of shape {Name}  ");

        if (obj.GetType().Name == "Circle")
        {
            Console.WriteLine($"Area of {obj.GetType().Name} is {obj.AreaCount()}");
        }
        else if (obj.GetType().Name == "Rectangle")
        {
            Console.WriteLine($"Area of {obj.GetType().Name} is {obj.AreaCount()}");
        }
        Console.WriteLine(" ");
    }

}
class Circle : Shape
{
    //Circle должен иметь радиус и метод для вычисления площади круга.
    public double radius { get; set; }
    const double PI = 3.14;
    public override double AreaCount()
    {
        double Area = PI * (radius * radius);
        return Area;
    }
}
class Rectangle : Shape
{
    //Rectangle должен иметь длину и ширину, а также метод для вычисления площади прямоугольника.

    public int height { get; set; }
    public int width { get; set; }

    public override double AreaCount()
    {
        double Area = height * width;
        return Area;
    }


}
class Triangle : Shape
{
    public int side1 { get; set; }
    public int side2 { get; set; }
    public int side3 { get; set; }

    public double TriangleArea()
    {
        
        return 0;
    }

    //Triangle должен иметь три стороны и метод для вычисления площади треугольника.
}

class Hexagon : Shape
{
    public int cornersCount { get; set; }

    public double HexagonArea()
    {
        return 0;

    }
}