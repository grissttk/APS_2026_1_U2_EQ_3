using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class RunnerEjercicio_ParImpar
{
    public RunnerEjercicio_ParImpar()
    {
        try
        {
            Console.WriteLine("Ingrese un número: ");
            int n = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new ParImpar(n);
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