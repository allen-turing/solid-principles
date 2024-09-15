namespace LSP
{
	public class Square : Rectangle
	{
		public Square(int side)
		{
			Width = side;
			Height = side;
		}

		public new int Height { set { base.Width = base.Height = value; } }
		public new int Width { set { base.Width = base.Height = value; } }

	}
}
