namespace OCP
{
	public class BetterFilter : IFilter<Product>
	{
		public IEnumerable<Product> Filter(IEnumerable<Product> products, ISpecification<Product> spec)
		{
			ArgumentNullException.ThrowIfNull(products);
			foreach (var product in products)
			{
				if (spec.IsSatisfied(product))
				{
					yield return product;
				}
			}
		}
	}
}
