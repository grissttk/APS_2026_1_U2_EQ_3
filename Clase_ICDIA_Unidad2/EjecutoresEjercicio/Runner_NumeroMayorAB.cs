using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_NumeroMayorAB
{
    public Runner_NumeroMayorAB()
    {
        try
        {
            Console.WriteLine("Ingresa A ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa B ");
            int b = int.Parse(Console.ReadLine());


            Ejercicio ejercicio;
            ejercicio = new NumeroMayorAB(a, b);
            ejercicio.Ejecutar();
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
            Console.WriteLine("Un argumento no cumple con las reestricciones de entrada");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}