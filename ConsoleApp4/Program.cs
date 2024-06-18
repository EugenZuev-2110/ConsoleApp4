using FiguresLibrary;

try
{
    Console.Write("Insert a value of side A: ");
    var a = double.Parse(Console.ReadLine());       // Вводим первое значение
    Console.Write("Insert a value of side B: ");
    var b = double.Parse(Console.ReadLine());       // Вводим второе значение
    Console.Write("Insert a value of side C: ");
    var c = double.Parse(Console.ReadLine());       // Вводим третье значение
    IFigure figure = new Triangle(a, b, c);         // Создаем объект треугольника, в конструктор передаем введенные раннее значения. Объявляем переменную figure и присваиваем ей ссылку на этот треугольник
    Console.WriteLine(figure.GetArea());            // Вызываем метод для отображения площади фигуры
    Console.WriteLine($"Is rectangle: {(figure as Triangle).IsRect()}");   // Т.к. figure хранит ссылку на Triangle, мы можем привести figure к Triangle, а затем вызвать метод треугольника IsRect()
    Console.ReadKey();

    // То же самое, только с другими фигурами

    // Прямоугольник
    Console.Write("Insert a value of side A: ");
    a = double.Parse(Console.ReadLine());
    Console.Write("Insert a value of side B: ");
    b = double.Parse(Console.ReadLine());
    figure = new Rectangle(a, b);
    Console.WriteLine(figure.GetArea());
    Console.WriteLine($"Is square: {(figure as Rectangle).IsSquare()}");
    Console.ReadKey();

    // Окружность
    Console.Write("Insert a value of radius: ");
    a = double.Parse(Console.ReadLine());
    figure = new Circle(a);
    Console.WriteLine(figure.GetArea());
    Console.ReadKey();
}
catch
{
    Console.WriteLine("Incorrect data format!!!");
}