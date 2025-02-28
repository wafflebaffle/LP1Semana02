using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Altura de um cilindro: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Raio de um cilindro: ");
            double r = double.Parse(Console.ReadLine());

            //V = πr2a
            double v = Math.PI*Math.Pow(r, 2)*a;
            double vv = Math.Round(v, 3);
            Console.WriteLine(vv);
            
            //Sa = 2πr(r + a)
            double s = 2*Math.PI*(r*(r+a));
            double ss = Math.Round(s, 3);
            Console.WriteLine(ss);
        }
    }
}
