class FarToCel{
	public static void Main(string[] args){
		double a;
		System.Console.WriteLine("Enter Temprature = ");
		string ip = System.Console.ReadLine();
		a = System.Convert.ToDouble(ip);
		double Cel = ((a-32)/7.58);
		System.Console.WriteLine("{0} C",Cel);
	}
}