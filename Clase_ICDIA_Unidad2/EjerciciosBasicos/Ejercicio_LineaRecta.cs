using System.Numerics;
using System.Runtime.InteropServices.ComTypes;

namespace Clase_ICDIA_Unidad2.EjerciciosBasicos;

public class Ejercicio_LineaRecta<T> : Ejercicio where T : INumber<T>
{
    private T valor_m;
    private T valor_x;
    private T valor_b;

    public T ValorM
    {
        get { return valor_m; }
        set { valor_m = value; }
    }
    
    public T ValorX
    {
        get { return valor_x; }
        set
        {
            if (valor_x.CompareTo(0) > 0)
            {
                valor_x = value;
            }
            else
            {
                throw new Exception("El valor es invalido");
            }
        }
    }
    
    public T ValorB
    {
        get { return valor_b; }
        set { valor_b = value; }
    }

    public Ejercicio_LineaRecta(T m, T b, T x) : base(14, 
        "Linea Recta", "Genera un punto de una linea recta")
    {
        ValorM = m;
        ValorX = x;
        ValorB = b;
    }

    public override void Ejecutar()
    {
        T resultado = ValorM * ValorX + ValorB;
        Console.WriteLine("El resultado es: " + resultado);
    }
}
