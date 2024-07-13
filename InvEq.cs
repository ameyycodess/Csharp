class InvEq
{
	public static void Main(string[] args)
	{
		int p = 1000;
		double r = 0.10;
		int n = 1;
		for(int i = 0; i <= 10; i++)
		{
			double v = p * (System.Math.Pow(1+r,n));
			System.Console.WriteLine(v);
			p = p + 1000;
			r = r + 0.10;
			n = n + 1;
		
		}
	}
}