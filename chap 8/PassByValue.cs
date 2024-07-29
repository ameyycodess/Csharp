class PbV
{
	static void Change(int m)
	{
		m = m + 10;
	}
	public void CFun()
	{
		int x = 100;
		Change(x);
		System.Console.WriteLine("x =" + x);
	} 
}

class PassByValue
{
	public static void Main()
	{	
		PbV obj = new PbV();
		obj.CFun();
	}
}