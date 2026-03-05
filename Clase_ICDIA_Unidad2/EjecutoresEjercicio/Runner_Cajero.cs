using Clase_ICDIA_Unidad2.Otros;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_Cajero
{
    public Runner_Cajero()
    {
        Console.WriteLine("Ingresa la cantidad a retirar:");
        int cantidad = int.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Cajero(cantidad);
        ejercicio.Ejecutar();
    }
}