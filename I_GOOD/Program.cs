namespace I_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker worker = new Worker();
            IEater unemployed = new Unemployed();

            Console.WriteLine("Worker:");
            worker.Work();
            ((IEater)worker).Eat();

            Console.WriteLine("\nUnemployed:");
            unemployed.Eat();
        }
    }
}