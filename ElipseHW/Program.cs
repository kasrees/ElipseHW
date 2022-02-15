using ElipseHW;

class Program
{
    public static void Main (string[] args)
    {
        Point center = new Point
        {
            X = 0,
            Y = 0
        };

        try
        {
            Elipse elipse = new Elipse(center, 0, 2);

            Console.WriteLine(elipse.GetSquare().ToString());
            Console.WriteLine(elipse.GetPerimeter().ToString());
            Console.WriteLine($"{elipse}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}