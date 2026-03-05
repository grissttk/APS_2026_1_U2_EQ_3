using Clase_ICDIA_Unidad2.EjerciciosBasicos;

namespace Clase_ICDIA_Unidad2.EjecutoresEjercicio;

public class Runner_DistanciaEntreDosNumeros
{
    public Runner_DistanciaEntreDosNumeros()
    {
        int a,b, c, d;
        //punto 1
        a = 2;
        b = 4;
        //punto 2 
        c = 5;
        d = 3;

        Ejercicio ejercicio;
        ejercicio = new Distancia_EntreDosPuntos<int>(
            a, b, c, d);
        ejercicio.Ejecutar();
    }
}