namespace ISP
{
	internal class OldFashionedPrinter : IPrinter
	{
		public void Print(Document document)
		{
			Console.WriteLine($"Printing {document.Id} {document.Name} having {document.Content} ");
		}
	}
}
