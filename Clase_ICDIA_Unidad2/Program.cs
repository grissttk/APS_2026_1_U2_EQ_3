using Clase_ICDIA_Unidad2.EjecutoresEjercicio;
using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

class Program
{
    static void Main(string[] args)
    {
        List<Ejercicio> listaEjercicios = new List<Ejercicio>();
        listaEjercicios.Add(new ParImpar());
        listaEjercicios.Add(new Ejercicio_PerimetroPoligonoRegular<int>());
        
        foreach (Ejercicio item in listaEjercicios)
        {
            Console.WriteLine(item);
        }
        
        #region Menu
        /*
        Console.WriteLine("Menu Clase_ICDIA_Unidad2:");
        Console.WriteLine("1. Ejercicio Par Impar");
        Console.WriteLine("2. Ejercicio Suma AB");
        Console.WriteLine("3. Ejercicio Mayor Edad");
        Console.WriteLine("4. Ejercicio Número Mayor AB");
        Console.WriteLine("5. Ejercicio Voltear Numero AB");
        Console.WriteLine("6. Ejercicio Multiplicacion AB");
        Console.WriteLine("7. Ejercicio Suma Genericos AB");
        Console.WriteLine("8. Ejercicio Cajero AB");
        Console.WriteLine("9. Ejercicio IMC");
        Console.WriteLine("10. Distancia Entre Dos Puntos");
        Console.WriteLine("11. Promedio de tres calificaciones");
        Console.WriteLine("12. Determina si un numero es primo");
        Console.WriteLine("13. Factorial");
        Console.WriteLine("14. Linea Recta");
        Console.WriteLine("15. Perimetro de un Poligono Regular");
        Console.WriteLine();
        */
        #endregion

        int idx = 14;

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
             new Runner_VoltearNumero();
             break;
         
         case 6:
             new RunnerEjercicio_MultiplicacionAB();
             break;
         
         case 7:
             new Runner_SumaABGenericos();
             break;
         
         case 8:
             new Runner_Cajero();
             break;
         
         case 9:
             new Runner_IMC();
             break;
         
         case 10:
             new Runner_DistanciaEntreDosNumeros();
             break;
         
         case 11:
             new Runner_Promedio3Calificaciones();
             break;
         
         case 12:
             new Runner_NumPrimo();
             break;
         
         case 13:
             new Runner_Factorial();
             break;
         
         case 14:
             new Runner_LineaRecta();
             break;
         
         case 15:
             new Runner_PerimetroPoligonoRegular();
             break;
        }
    }
}