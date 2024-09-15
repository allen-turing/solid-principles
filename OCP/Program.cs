using OCP;

var productList = new List<Product>
{

	new Product("Apple", Color.RED, Size.SMALL),
	new Product("Orange", Color.ORANGE, Size.LARGE),
	new Product("Banana", Color.YELLOW, Size.MEDIUM),
	new Product("Cherry", Color.RED, Size.SMALL),
};
#region Product Filter Approach 1
var filter = new ProductFilter();

var redProduct = filter.ProductFilterByColor(productList, Color.RED);
var redProduct2 = filter.ProductFilterBySize(productList, Size.SMALL);
var redProduct3 = filter.ProductFilterBySizeAndColor(productList, Size.SMALL, Color.RED);

foreach (var item in redProduct)
{
	Console.Write("Filter by Color: RED ");
	Console.WriteLine(item);
}

foreach (var item in redProduct2)
{
	Console.Write("Filter by Size: SMALL ");
	Console.WriteLine(item);
}

foreach (var item in redProduct3)
{
	Console.Write("Filter by Color: RED and Size SMALL ");
	Console.WriteLine(item);
}
#endregion

#region Product Filter Approach 2

var pf = new BetterFilter();
Console.WriteLine("*******Approach 2*******");
foreach (var redItems in pf.Filter(productList, new ColorSpecification(Color.RED)))
{
	Console.Write("Approach 1 -> Filter by Color: RED ");
	Console.WriteLine(redItems);
}

foreach (var smallSize in pf.Filter(productList, new SizeSpecification(Size.SMALL)))
{
	Console.Write("Approach 1 -> Filter by Size: Small ");
	Console.WriteLine(smallSize);
}

foreach (var smallSize in pf.Filter(productList,
	new AndSpecification<Product>(new ColorSpecification(Color.RED),
									new SizeSpecification(Size.SMALL))))
{
	Console.Write("Approach 1 -> Filter by Color: RED and Size: Small ");
	Console.WriteLine(smallSize);
}

#endregion