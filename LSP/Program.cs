// See https://aka.ms/new-console-template for more information

using LSP;
Console.WriteLine("Example of Liskov Substitution Principal\n");

var rectangle = new Rectangle(2, 10);
Console.WriteLine($"Area of Rectangle : 2*10 = {rectangle.Area()}");

var square = new Square(5);
Console.WriteLine($"Area of Square : 5 = {square.Area()}");