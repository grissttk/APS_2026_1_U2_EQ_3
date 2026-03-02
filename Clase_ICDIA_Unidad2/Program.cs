using Clase_ICDIA_Unidad2.EjecutoresEjercicio;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Clase_ICDIA_Unidad2");

        int idx = 1;

        switch (idx)
        {
         case 1:
             new RunnerEjercicio_ParImpar();
             break;
         
         case 2:
             new Runner_SumaAB();
             break;
        }
    }
}