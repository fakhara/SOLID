namespace L_BAD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rektangel rektangel = new Rektangel
            {
                Bredd = 5,
                Höjd = 10
            };
            Console.WriteLine($"Rektangel Area: {rektangel.Area()}");
            Rektangel kvadratSomRektangel = new Kvadrat();
            kvadratSomRektangel.Bredd = 5;
            kvadratSomRektangel.Höjd = 10;

            Console.WriteLine($"Kvadrat Som Rektangel Arae: {kvadratSomRektangel.Area()}");
        }
    }
}