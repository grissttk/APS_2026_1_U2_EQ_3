using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_SumaABGenericos
{
    public Runner_SumaABGenericos()
    {
        int a, b;
        Console.WriteLine("Dame el valor de a: ");
        a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Dame el valor de b: ");
        b = int.Parse(Console.ReadLine());

        Ejercicio ejercicio = new Ejercicio_SumaABGenericos<int>(a, b);
        ejercicio.Ejecutar();
    }
}