using ExercicioMetodosAbstratos.Entities.Enums;
using ExercicioMetodosAbstratos.Entities;

List<Shape> list = new List<Shape>();

Console.Write("Entre numero figuras: ");
int n = int.Parse(Console.ReadLine());



for (int i = 0; i < n; i++) {
    Console.WriteLine($"Figura {i} :");
    Console.Write("Rectangle or Circle (r/c)? :");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (ch == 'r') {
        Console.Write("Largura :");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Altura :");
        double height = double.Parse(Console.ReadLine());
        list.Add(new Rectangle(width, height, color));    
    } else {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine());
        list.Add(new Circle(radius, color));
    }

}

Console.WriteLine("Shape Areas: ");
foreach (Shape shape in list) {
    Console.WriteLine(shape.Area());
}
