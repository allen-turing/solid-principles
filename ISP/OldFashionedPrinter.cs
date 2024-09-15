namespace ISP
{
	internal class OldFashionedPrinter : IMachine
	{
		[Obsolete("Not supported", true)]
		public void Fax(Document document)
		{
			throw new NotImplementedException();
		}

		public void Print(Document document)
		{
			Console.WriteLine($"Printing {document.Id} {document.Name} having {document.Content} ");
		}

		[Obsolete("Not supported", true)]
		public void Scan(Document document)
		{
			throw new NotImplementedException();
		}
	}
}
