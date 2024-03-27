using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraSueldosLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JefeDeTienda j1 = new JefeDeTienda();
            String nombre = "";
            int horas = 0;
            string opcion = "";

            Console.WriteLine("Programa ejecutado");

            do
            {
                do
                {
                    Console.WriteLine("Ingrese Nombre del Trabajador");
                    nombre = Console.ReadLine();
                } while (nombre == "");
                j1.Nombre = nombre;

                do
                {
                    try
                    {
                        Console.WriteLine("Ingrese Cantidad de Horas trabajadas");
                        horas = Convert.ToInt32(Console.ReadLine());
                        if (horas <= 0)
                        {
                            Console.WriteLine("Valor no Valido");
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Valor no Valido");
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Otro tipo de Errores" + ex.ToString());
                    }
                } while (horas <= 0);

                j1.CalcularSueldo(horas);

                Console.WriteLine("El nombre del trabajador es: " + j1.Nombre);
                Console.WriteLine("Monto Hora Normal es: " + j1.TotalNormal);
                Console.WriteLine("Monto Hora Extra es: " + j1.TotalExtra);
                Console.WriteLine("Monto Total a Pagar es: " + j1.Sueldo);

                Console.WriteLine("¿Desea calcular el sueldo de otro trabajador? (S/N)");
                opcion = Console.ReadLine().ToUpper();


            } while (!opcion.Equals("S"));


        }
    }
}
