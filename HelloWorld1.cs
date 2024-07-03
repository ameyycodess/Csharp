//using method
using System;
class Fsum
{
    public float x = 75.86f;
    public float y = 43.48f;
}
class HelloWorld1
{
    public static void Main(string[] args)
    {
       Fsum ob = new Fsum();
       Console.WriteLine(ob.x);
       Console.WriteLine(ob.y);
       Console.WriteLine("Sum = {0}",ob.x + ob.y);
    }
}