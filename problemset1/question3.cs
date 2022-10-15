
//question 3
namespace ex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double s, area;
            double a, b, c;

            a = 2;
            b = 2;
            c = 2;

            s = (a + b + c) / 2;
            area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            Console.WriteLine("Area = {0}", area);
        }
    }
}
