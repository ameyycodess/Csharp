class Prac1d_a
{
    public static void Main(string[] args)
    {
        int count;
        int a = 0;
        int b = 1;

        System.Console.Write("Enter the number of terms to generate in Fibonacci series:");
        count = int.Parse(System.Console.ReadLine());

        
        System.Console.Write("{0} {1} ", a, b);

        
        for (int i = 2; i < count; i++)
        {
            int next = a + b;
            System.Console.Write("{0} ", next);
            a = b;
            b = next;
        }

        
        System.Console.WriteLine();
    }
}
