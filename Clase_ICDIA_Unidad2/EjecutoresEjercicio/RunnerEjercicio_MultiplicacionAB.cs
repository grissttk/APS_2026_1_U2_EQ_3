using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class RunnerEjercicio_MultiplicacionAB
{
    public RunnerEjercicio_MultiplicacionAB()
    {
        int a, b;
        Console.WriteLine("Dame el valor de A:");
        a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Dame el valor de B:");
        b = int.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_MultiplicacionAB(a, b);
        ejercicio.Ejecutar();
    }
}