class Depriciation{
	public static void Main(string[] args){
		double pur,yrs,salv;
		System.Console.WriteLine("Enter the Purchase");
		string purip = System.Console.ReadLine();
		System.Console.WriteLine("Enter the Salvage");
		string salvip = System.Console.ReadLine();
		System.Console.WriteLine("Enter the No. of Years");
		string yrsip = System.Console.ReadLine();
		

		pur = System.Convert.ToDouble(purip);
		salv = System.Convert.ToDouble(salvip);
		yrs = System.Convert.ToDouble(yrsip);

		double dep = (pur - salv) / yrs;
		System.Console.WriteLine(dep);
	}
}