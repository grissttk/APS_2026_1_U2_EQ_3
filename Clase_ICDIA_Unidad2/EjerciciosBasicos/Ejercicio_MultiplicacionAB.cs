namespace Clase_ICDIA_Unidad2.EjerciciosBasicos;

public class Ejercicio_MultiplicacionAB : Ejercicio
{
    private int a;
    private int b;

    public int A
    {
        get => a;
        set => a = value;
    }
    public int B
    {
        get => b;
        set => b = value;
    }

    public Ejercicio_MultiplicacionAB(int a, int b) : base(2, 
        "MultiplicaciónAB", "Multiplicación de dos numeros (a*b)")
    {
        A = a;
        B = b;
    }

    public override void Ejecutar()
    {
        int resultado = A * B;
        Console.WriteLine("Resultado de la multiplicación " + resultado);
    }
}