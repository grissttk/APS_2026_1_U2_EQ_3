using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_VoltearNumero
{
    public Runner_VoltearNumero()
    {
        Console.WriteLine("Dame un número de dos dígitos:");
        int numero = int.Parse(Console.ReadLine());

        Ejercicio ejercicio;
        ejercicio = new Ejercicio_VoltearNumero(numero);
        ejercicio.Ejecutar();
    }
}