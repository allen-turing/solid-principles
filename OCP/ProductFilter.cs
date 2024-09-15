namespace OCP
{
	public class ProductFilter
	{
		public IEnumerable<Product> ProductFilterBySize(IEnumerable<Product> products, Size size)
		{
			return products.Where(p => p.Size == size);
		}

		public IEnumerable<Product> ProductFilterByColor(IEnumerable<Product> products, Color color)
		{
			return products.Where(p => p.Color == color);
		}

		public IEnumerable<Product> ProductFilterBySizeAndColor(IEnumerable<Product> products, Size size, Color color)
		{
			return products.Where(p => p.Size == size && p.Color == color);
		}
	}
}
