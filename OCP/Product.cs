namespace OCP
{
	public enum Color { RED, BLUE, GREEN, YELLOW, ORANGE };
	public enum Size { SMALL, MEDIUM, LARGE };
	public record Product(string Name, Color Color, Size Size);
}
