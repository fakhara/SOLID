namespace L_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IForm rektangel = new Rektangel { Bredd = 10, Höjd= 5};
            IForm triangel = new Triangel { Base = 6, Height = 8 };
            IForm kvadrat = new Kvadrat { Sida = 4 };
            var calculator = new AreaCalculator();
            Console.WriteLine($"Area of Rectangle: {calculator.CalculateArea(rektangel)}");
            Console.WriteLine($"Area of Triangle: {calculator.CalculateArea(triangel)}");
            Console.WriteLine($"Area of Kvadrat: {calculator.CalculateArea(kvadrat)}");

            Console.ReadLine();
        }
    }
}