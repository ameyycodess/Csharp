class Prac1a_cl
{
	public static void Main(string[] args)
	{
		int a,b,c,d,sum,pro;
		a = System.Convert.ToInt32(args[0]);
		b = System.Convert.ToInt32(args[1]);
		c = System.Convert.ToInt32(args[2]);
		d = System.Convert.ToInt32(args[3]);
		
		pro = a*b*c*d;
			
		System.Console.WriteLine("The product is = {0}",pro);	
	}
}