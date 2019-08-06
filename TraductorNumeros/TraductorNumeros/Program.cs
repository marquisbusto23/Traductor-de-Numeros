using System;

namespace TraductorNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi!");
            int numeros;
            string valor;
            int division;
            int division2;
            string[] cientos = { " ", "CIENTO", "DOSCIENTOS", "TRESCIENTOS", "CUATROCIENTOS", "QUINIENTOS", "SEISCIENTOS", "SETECIENTOS", "OCHOCIENTOS", "NOVECIENTOS" };

            string[] decenas = { "TREINTA", "CUARENTA", "CINCUENTA", "SESENTA", "SETENTA", "OCHENTA", "NOVENTA" };
            string[] unidades = { "CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ", "ONCE", "DOCE", "TRECE", "CATORCE", "QUINCE", "DIECISEIS", "DIECISIETE", "DIECIOCHO", "DIECINUEVE", "VEINTE", "VEINTIUNO", "VEINTIDOS", "VEINTITRES", "VEINTICUATRO", "VEINTICINCO", "VEINTISEIS", "VEINTISIETE", "VEINTIOCHO", "VEINTINUEVE" };


            int resto;
            int restodemil;

            while (true)
            {
                valor = "";
                Console.WriteLine("Ingrese un NUMERO entre 0 y 999");
                numeros = Convert.ToInt32(Console.ReadLine());
                if (numeros < 30)
                {
                    valor = unidades[numeros];
                    Console.WriteLine(valor);
                }
                if (numeros > 29 && numeros < 100)
                {
                    division = Convert.ToInt32(numeros / 10);
                    division = division - 3;
                    valor = decenas[division];
                    Console.Write(valor);
                    resto = (division + 3) * 10;
                    if (resto != numeros)
                    {
                        resto = numeros - resto;
                        valor = unidades[resto];
                        Console.Write("y " + valor);
                        Console.WriteLine();
                    }
                }
                if (numeros == 100)
                {
                    Console.WriteLine("CIEN");
                }
                if (numeros > 99 && numeros < 1000)
                {
                    division2 = Convert.ToInt32((numeros / 100));
                    valor = cientos[division2];
                    Console.Write(valor + " ");
                    resto = division2 * 100;
                    restodemil = numeros - resto;
                    if (restodemil < 30)
                    {
                        valor = unidades[restodemil];
                        Console.Write(valor);
                        Console.WriteLine();
                    }
                    if (restodemil > 29 && restodemil < 100)
                    {
                        division = Convert.ToInt32((restodemil / 10));
                        division = division - 3;
                        valor = decenas[division];
                        Console.Write(valor + " ");
                        resto = (division + 3) * 10;
                        if (resto != restodemil)
                        {

                            resto = restodemil - resto;
                            valor = unidades[resto];
                            Console.Write("y " + valor);
                            Console.WriteLine();
                        }
                    }

                }
                if (numeros > 999)
                {
                    Console.WriteLine("VALOR FUERA DEL RANGO ACTUAL!, INGRESE UN NUMERO ENTRE 0 Y 999!");
                    Console.WriteLine();
                }
            }
        }
    }
}
