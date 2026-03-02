using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_SumaAB
{
    public Runner_SumaAB()
    {
        int a, b;
        Console.WriteLine("Dame el valor de A:");
        a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Dame el valor de B:");
        b = int.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_SumaAB(a, b);
        ejercicio.Ejecutar();
    }
}