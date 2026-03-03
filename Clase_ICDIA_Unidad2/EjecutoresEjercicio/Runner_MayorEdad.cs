using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_MayorEdad
{
    public Runner_MayorEdad()
    {
        Console.WriteLine("Dame la edad de la persona");
        int edad = int.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_MayoridaEdad(edad);
        ejercicio.Ejecutar();
    }
}