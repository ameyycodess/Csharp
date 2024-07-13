class RevNum
{
	public static void Main(string[] args)
	{
		System.Console.WriteLine("Enter the Number = ");
		int num = int.Parse(System.Console.ReadLine());

		int rvrsd = revNum(num);

		System.Console.WriteLine("The Reversed number is {0} ",rvrsd);
	}

	static int revNum(int num)
	{
		int revn = 0;
		while(num!=0)
		{
			int rem=num%10;
			revn = revn * 10 + rem;
			num = num / 10;
		}

		return revn;
	}
}