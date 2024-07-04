/*write a c# program to read the price of an item in decimal for ex 75.95 and print the output in paise for example 75.95 paise using command line input*/

using System;
class Q1{
	public static void Main(string[] args){
		decimal x;
		Console.WriteLine("Enter the Price = ");
		string ip = Console.ReadLine();
		x = Convert.ToDecimal(ip);
		decimal x1 = x * 100;
		Console.WriteLine("Price = {0} Paise",x1);
	}
}