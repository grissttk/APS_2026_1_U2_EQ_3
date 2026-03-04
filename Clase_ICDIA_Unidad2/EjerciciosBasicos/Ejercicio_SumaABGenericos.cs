namespace Clase_ICDIA_Unidad2.EjerciciosBasicos;

public class Ejercicio_SumaABGenericos<T> : Ejercicio
{
    // T toma el tipo de dato que despues se les de
    private T a;
    private T b;

    public T A
    {
        get => a;
        set => a = value;
    }

    public T B
    {
        get => b;
        set => b = value;
    }

    public Ejercicio_SumaABGenericos() : base(7,
        "Suma con datos genericos", "Suma con datos genericos")
    {
        A = a;
        B = b;
    }

    public override void Ejecutar()
    {
        double resultado = Convert.ToDouble(A) + Convert.ToDouble(B);
        Console.WriteLine("La suma de A + B = " + resultado);
    }

}