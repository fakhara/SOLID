namespace I_BAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker worker = new Worker();
            IWorker unemployed = new Unemployed();

            Console.WriteLine("Worker: ");
            worker.Work();
            worker.Eat();

            Console.WriteLine("\nUnemployed:");
            unemployed.Work();
            unemployed.Eat();
        }
    }
}