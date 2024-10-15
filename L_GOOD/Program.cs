namespace L_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IForm rekangle = new Rektangel
            {
                Bredd = 5,
                Höjd = 10
            };
            Console.WriteLine($"Rektangel Area: {rekangle.Area()}");

            IForm kvadrat = new Kvadrat
            {
                Sida = 5
            };
            Console.WriteLine($"Kvadrat Area: {kvadrat.Area()}");

            IForm triangel = new Triangel
            {
                Base = 5,
                Height = 10,
            };
            Console.WriteLine($"Triangel Area: {triangel.Area()}");

        }
    }
}