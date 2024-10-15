namespace D_GOOD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISwitchable lightBulb = new LightBulb();
            ISwitchable spotLight = new SpotLight();

            Switch lampen = new Switch(lightBulb);
            Console.WriteLine("Switching the lightBulb:");
            for(int i = 0; i < 3; i++)
            {
                lampen.Toggle();
            }
            Switch spotlight = new Switch(spotLight);
            Console.WriteLine("\nSwitching the spotligt: ");
            for(int i = 0; i < 3; i++)
            {
                spotlight.Toggle();
            }
        }
    }
}