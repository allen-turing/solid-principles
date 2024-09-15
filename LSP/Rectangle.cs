namespace LSP
{
	public class Rectangle
	{
		public int Height { get; set; }
		public int Width { get; set; }

		public Rectangle()
		{

		}
		public Rectangle(int width, int height)
		{
			Width = width;
			Height = height;
		}

		public int Area() => Width * Height;
	}
}
