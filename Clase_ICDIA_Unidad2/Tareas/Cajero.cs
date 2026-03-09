namespace Clase_ICDIA_Unidad2.Tareas;

public class Cajero : Ejercicio
{
    private int cantidad;

    public int Cantidad
    {
        get => cantidad;
        set => cantidad = value;
    }

    public Cajero(int cantidad) : base(5, "Cajero Automatico",
        "Calcula cuantos billetes entregar")
    {
        Cantidad = cantidad;
    }

    public override void Ejecutar()
    {
        int restante = Cantidad;

        int b1000 = restante / 1000;
        restante = restante % 1000;

        int b500 = restante / 500;
        restante = restante % 500;

        int b200 = restante / 200;
        restante = restante % 200;

        int b100 = restante / 100;
        restante = restante % 100;

        int b50 = restante / 50;
        restante = restante % 50;

        int b20 = restante / 20;
        restante = restante % 20;

        Console.WriteLine("Billetes de 1000: " + b1000);
        Console.WriteLine("Billetes de 500: " + b500);
        Console.WriteLine("Billetes de 200: " + b200);
        Console.WriteLine("Billetes de 100: " + b100);
        Console.WriteLine("Billetes de 50: " + b50);
        Console.WriteLine("Billetes de 20: " + b20);

        Console.WriteLine("El resto son monedas: " + restante);
    }
}