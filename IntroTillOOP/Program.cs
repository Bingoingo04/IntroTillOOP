namespace IntroTillOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            double area1 = circle1.GetArea();
            Console.WriteLine($"Arean för en cirkel med radie 5 är: {area1}");

            Circle circle2 = new Circle(6);
            double area2 = circle2.GetArea();
            Console.WriteLine($"Arean för en cirkel med radie 6 är: {area2}");
        }
    }

    public class Circle
    {
        private double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2), 2);
        }
    }
}
