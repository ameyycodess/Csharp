class Exp
{
	public void Demo1()
	{
		int a=10, b=5, c=8, d=2;
		float x= 6.4F, y=3.0F;

		int ans1= a*b+c/d;
		int ans2=a*(b+c)/d;

		int ans3=a%c;
		float ans4=x%y;

		bool b1=a>b && c>d;
		bool b2=a<b && c>d;	
		bool b3=a<b || c>d;
		bool b4=!(a-b==c);

		System.Console.WriteLine("Order of Evalution");
		System.Console.WriteLine("a*b+c/d="+ ans1);
		System.Console.WriteLine("a*(b+c)/d="+ ans2);

		System.Console.WriteLine("Modulo Operations");
		System.Console.WriteLine("a%c="+ ans3);
		System.Console.WriteLine("x%y="+ ans4);	

		System.Console.WriteLine("Logical Operations");
		System.Console.WriteLine("a>b && c>d=" +b1);
		System.Console.WriteLine("a<b && c>d="+b2);
		System.Console.WriteLine("a<b || c>d="+b3);
		System.Console.WriteLine("!(a-b)==c="+b4);
	}
}
class Expressions
{
	public static void Main(string[] args)
	{
		Exp obj=new Exp();
		obj.Demo1();
	}
}		