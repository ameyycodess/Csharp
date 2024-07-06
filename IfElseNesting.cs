
using System;

public class IfElseNesting
{
    public static void Main(string[] args)
    {
        int a = 325;
        int b = 712;
        int c = 478;
        
        Console.WriteLine("Largest Value is: ");
        
        if (a > b){
            if(a > c){
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        else{
            if (c > b){
                Console.WriteLine(c);
            }
            else{
                Console.WriteLine(b);
            }
        }
    }
}