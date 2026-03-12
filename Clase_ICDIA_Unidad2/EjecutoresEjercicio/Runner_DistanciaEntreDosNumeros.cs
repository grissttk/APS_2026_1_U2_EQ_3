using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_DistanciaEntreDosNumeros
{
    public Runner_DistanciaEntreDosNumeros()
    {
        int a,b, c, d;
        try
        {
            Console.WriteLine("Ingresa la coordenada X del punto 1");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la coordenada Y del punto 1");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la coordenada X del punto 2");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa la coordenada Y del punto 2");
            d = int.Parse(Console.ReadLine());

            Ejercicio ejercicio;
            ejercicio = new Distancia_EntreDosPuntos<int>(
                a, b, c, d);
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