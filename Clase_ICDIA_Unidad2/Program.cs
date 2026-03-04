using Clase_ICDIA_Unidad2.EjecutoresEjercicio;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pan");
        Console.WriteLine("Clase_ICDIA_Unidad2");

        int idx;
        idx = int.Parse(Console.ReadLine());

        switch (idx)
        {
         case 1:
             new RunnerEjercicio_ParImpar();
             break;
         
         case 2:
             new Runner_SumaAB();
             break;
         
         case 3:
             new Runner_MayorEdad();
             break;
         
         case 4:
             new Runner_NumeroMayorAB();
             break;
         
         case 5:
             new RunnerEjercicio_MultiplicacionAB();
             break;
        }
    }
}