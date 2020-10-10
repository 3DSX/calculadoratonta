using System;
using System.Globalization;
using Calculaora.Utils;

namespace Calculadora
{
    class Program
    {
        public static void Main(string[] args)
        {

            string calculadora = "Calculadora";

            Console.WriteLine(new string('=', calculadora.Length));
            Console.WriteLine(calculadora);
            Console.WriteLine(new string('=', calculadora.Length));
            CalculadoraStart();

        }

        public static void CalculadoraStart()
        {
            Console.WriteLine("1 - Suma");
            Console.WriteLine(new string('=', 10));
            Console.WriteLine("Elige Opcion");
            string rtaUsuario = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(rtaUsuario))
            {
                Console.WriteLine("No escribas espacios. volviendo...");
                CalculadoraStart();
                return;
            }
            else
            {
                switch (rtaUsuario)
                {

                    case "1":
                        CultureInfo ci = (CultureInfo)CultureInfo.CurrentCulture.Clone();
                        ci.NumberFormat.CurrencyDecimalSeparator = ".";

                        Console.WriteLine("Escribe un numero");
                        string numero1Rta = Console.ReadLine();

                        if (!float.TryParse(numero1Rta, NumberStyles.Any, ci, out float parsedResult1))
                        {

                            Console.WriteLine("No escribas espacios. volviendo...");
                            CalculadoraStart();
                            return;
                        }

                        Console.WriteLine("Escribe un segundo numero");
                        string numero2Rta = Console.ReadLine();

                        if (!float.TryParse(numero2Rta, NumberStyles.Any, ci, out float parsedResult2))
                        {
                            Console.WriteLine("No escribas espacios. volviendo...");
                            CalculadoraStart();
                            return;
                        }

                        float resultado = Utils.Suma(parsedResult1, parsedResult2);

                        Console.WriteLine(new string('=', 10));
                        Console.WriteLine("El resultado es " + resultado);

                        return;


                    default:
                        Console.WriteLine("Elige una opción listada");
                        Console.WriteLine(new string('=', 10));
                        CalculadoraStart();
                        break;
                }

            }
        }
    }
}
