namespace D_BAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Switch wallSwitch = new Switch();
            Console.WriteLine("Trycka på strömbrytaren: ");
            wallSwitch.Toggle();
            wallSwitch.Toggle();
            wallSwitch.Toggle();

            Console.ReadLine();

        }
    }
}