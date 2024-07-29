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
				goto case 2;
			case 2:
				x=y+m;
				goto default;

			default:
				x=y-m;
				break;
				
		}
		System.Console.WriteLine(x);
	}
}
class Switchgoto
{
	public static void Main()
	{
		Ex obj= new Ex();
		obj.Demo();
	}
}