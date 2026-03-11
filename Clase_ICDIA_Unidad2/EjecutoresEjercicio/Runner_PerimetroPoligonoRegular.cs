using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_PerimetroPoligonoRegular
{
    public Runner_PerimetroPoligonoRegular()
    {
        int cantidadLados;
        int longitudLado;

        try
        {
            Console.WriteLine("Ingresa la cantidad de lados:");
            cantidadLados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la longitud de un lado:");
            longitudLado = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new Ejercicio_PerimetroPoligonoRegular<int>
                (cantidadLados, longitudLado);
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