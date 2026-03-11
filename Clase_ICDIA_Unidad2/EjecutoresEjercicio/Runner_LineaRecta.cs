using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_LineaRecta
{
    public Runner_LineaRecta()
    {
        int m, x, b;
        bool se_ejecuto = false;
        while (!se_ejecuto)
        {
            try
            {
                Console.WriteLine("Dame el valor de m:");
                m = int.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor de x:");
                x = int.Parse(Console.ReadLine());

                Console.WriteLine("Dame el valor de b:");
                b = int.Parse(Console.ReadLine());

                Ejercicio ejercicio;
                ejercicio = new Ejercicio_LineaRecta<int>(m, x, b);
                ejercicio.Ejecutar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error encontrado: " + ex.Message);
                se_ejecuto = false;
            }
            finally
            {
                Console.WriteLine("Intento de Ejecución Terminado!");
            }
        }
    }
}