class Cast
{
	public void Demo()
	{
		float sum;
		int i;
		sum=0.0F;
		for(i=1;i<=10; i++)
		{
			sum=sum+1/(float)i;
			System.Console.WriteLine("i="+i);
			System.Console.WriteLine("Sum= "+sum);
		}
	}
}

class Casting
{
	public static void Main(string[] args)
	{
	Cast obj=new Cast();
	obj.Demo();
	}
}