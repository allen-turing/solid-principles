namespace ISP
{
	public class ModernPrinter : IPrinter, IScanner, IFaxer
	{
		public void Fax(Document document)
		{
			Console.WriteLine($"Faxing {document.Id} {document.Name} having {document.Content} ");
		}

		public void Print(Document document)
		{
			Console.WriteLine($"Printing {document.Id} {document.Name} having {document.Content} ");
		}

		public void Scan(Document document)
		{
			Console.WriteLine($"Scanning {document.Id} {document.Name} having {document.Content} ");
		}
	}
}
