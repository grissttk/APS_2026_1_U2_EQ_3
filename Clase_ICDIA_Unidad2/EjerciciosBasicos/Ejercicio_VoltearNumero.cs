namespace Clase_ICDIA_Unidad2.EjerciciosBasicos;

public class Ejercicio_VoltearNumero : Ejercicio
{
    private int numero;

    public int Numero
    {
        get => numero;
        set => numero = value;
    }

    public Ejercicio_VoltearNumero(int numero) : base(4, "Voltear número",
        "Invierte un número de dos dígitos")
    {
        Numero = numero;
    }

    public override void Ejecutar()
    {
        int decena = Numero / 10;
        int unidad = Numero % 10;

        int volteado = unidad * 10 + decena;

        Console.WriteLine("Número volteado: " + volteado);
    }
}