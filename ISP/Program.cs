// See https://aka.ms/new-console-template for more information
using ISP;


var document = new Document
{
	Id = 1,
	Name = "My Document",
	Content = "This is content of my document"
};

Console.WriteLine("New Modern Printer");
var modernPrinter = new ModernPrinter();
modernPrinter.Print(document);
modernPrinter.Fax(document);
modernPrinter.Scan(document);

Console.WriteLine();
Console.WriteLine("Old Printer Function");
var oldPrinter = new OldFashionedPrinter();
oldPrinter.Print(document);

