using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_MayorEdad
{
    public Runner_MayorEdad()
    {
        try
        {
            Console.WriteLine("Dame la edad de la persona");
            int edad = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_MayoridaEdad(edad);
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