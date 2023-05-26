namespace prrimefactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("enter the number");
            int x=Convert.ToInt32(Console.ReadLine());
            PrimeFactors p=new PrimeFactors();
            p.prime(x);
        }
    }
}