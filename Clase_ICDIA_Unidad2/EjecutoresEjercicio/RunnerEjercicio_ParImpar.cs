using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class RunnerEjercicio_ParImpar
{
    public RunnerEjercicio_ParImpar()
    {
        Console.WriteLine("Ingrese un número: ");
        int n = int.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new ParImpar(n);
        ejercicio.Ejecutar();
    }
}