class Output
{
	static void Square(int x, out int y)
	{
		y = x * x;
	}

	public static void Main(string[] args)
	{
		int m;
		Square(10, out m);
		System.Console.Write(m);
	}
}