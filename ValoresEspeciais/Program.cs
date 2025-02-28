using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Integral Types:");

            sbyte sbmax = sbyte.MaxValue;
            sbyte sbmin = sbyte.MinValue;
            Console.WriteLine("sbyte: " + sbmax+ " is the max value and " + sbmin + " is the minimum value.");

            short shmax = short.MaxValue;
            short shmin = short.MinValue;
            Console.WriteLine("short: " + shmax+ " is the max value and " + shmin + " is the minimum value.");
            
            int inmax = int.MaxValue;
            int inmin = int.MinValue;
            Console.WriteLine("int: " + inmax+ " is the max value and " + inmin + " is the minimum value.");

            long lomax = long.MaxValue;
            long lomin = long.MinValue;
            Console.WriteLine("long: " + lomax+ " is the max value and " + lomin + " is the minimum value.");

            byte bymax = byte.MaxValue;
            byte bymin = byte.MinValue;
            Console.WriteLine("byte: " + bymax+ " is the max value and " + bymin + " is the minimum value.");

            ushort usmax = ushort.MaxValue;
            ushort usmin = ushort.MinValue;
            Console.WriteLine("ushort: " + usmax+ " is the max value and " + usmin + " is the minimum value.");
            
            uint uimax = uint.MaxValue;
            uint uimin = uint.MinValue;
            Console.WriteLine("uint: " + uimax+ " is the max value and " + uimin + " is the minimum value.");

            ulong ulmax = ulong.MaxValue;
            ulong ulmin = ulong.MinValue;
            Console.WriteLine("ulong: " + ulmax+ " is the max value and " + ulmin + " is the minimum value.");

            char chmax = char.MaxValue;
            char chmin = char.MinValue;
            Console.WriteLine("char: " + chmax+ " is the max value and " + chmin + " is the minimum value.");
            
            Console.WriteLine("Real Types:");
            
            float flmax = float.MaxValue;
            float flmin = float.MinValue;
            Console.WriteLine("float: " + flmax+ " is the max value and " + flmin + " is the minimum value.");

            double dbmax = double.MaxValue;
            double dbmin = double.MinValue;
            Console.WriteLine("double: " + dbmax+ " is the max value and " + dbmin + " is the minimum value.");

            decimal demax = decimal.MaxValue;
            decimal demin = decimal.MinValue;
            Console.WriteLine("decimal: " + demax+ " is the max value and " + demin + " is the minimum value.");
        }
    }
}
