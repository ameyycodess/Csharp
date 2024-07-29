class Ex
{
	public void Demo()
	{
		int m, x,y;
		m=2;
		y=5;
		switch(m)	
		{
			case 1:
				x=y;
				break;
			case 2:
				x=y+m;
				break;

			default:
				x=y-m;
				break;
				
		}
		System.Console.WriteLine(x);
	}
}
class Switch1
{
	public static void Main()
	{
		Ex obj= new Ex();
		obj.Demo();
	}
}