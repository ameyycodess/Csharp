class IfN
{
	public void DemoFn()
	{
		int a = 325, b = 712, c = 478;
		System.Console.WriteLine("Largest Value : ");
		
		if(a > b)
		{
			if(a > c)
			{
				System.Console.WriteLine(a);
			}
			else
			{
				System.Console.WriteLine(c);
			}
		}
		else
		{
			if(c > b)
			{
				System.Console.WriteLine(c);
			}
			else
			{
				System.Console.WriteLine(b);
			}
		}
	}
}

class IfElseNesting
{
	public static void Main(string[] args)
	{
		IfN obj = new IfN();
		obj.DemoFn();
	}	
}