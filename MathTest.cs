class Math
{
	public void DemoFn()
	{
		System.Console.WriteLine("Sines of angle from 0 to 90 degrees");
		for(double theta = 0.0; theta <= 90.00; theta += 15)
		{
			double x = System.Math.Sin(theta * System.Math.PI / 180);
			System.Console.Write("\nSin" + theta);
			System.Console.Write(" ={0:F4}" + x);
		}
	}
}

class MathTest
{
	public static void Main(string[] args)
	{
		Math obj = new Math();
		obj.DemoFn();
	}
}