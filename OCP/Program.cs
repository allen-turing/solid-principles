using OCP;

var productList = new List<Product>
{

	new Product("Apple", Color.RED, Size.SMALL),
	new Product("Orange", Color.ORANGE, Size.LARGE),
	new Product("Banana", Color.YELLOW, Size.MEDIUM),
};

var filter = new ProductFilter();

var redProduct = filter.ProductFilterByColor(productList, Color.RED);

foreach (var item in redProduct)
{
	Console.WriteLine(item);
}