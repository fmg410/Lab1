namespace Lab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Problem problem = new Problem(10, 434180);
            Result r = problem.solve(10);
            Console.Write(problem.ToString());
            Console.WriteLine("Result");
            Console.Write(r.ToString());
            Console.WriteLine("Total value: " + r.total_value);
            Console.WriteLine("Total weight: " + r.total_weight);
        }
    }
}