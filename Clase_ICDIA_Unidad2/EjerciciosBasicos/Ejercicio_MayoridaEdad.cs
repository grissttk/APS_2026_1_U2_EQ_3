namespace Clase_ICDIA_Unidad2.EjerciciosBasicos;

public class Ejercicio_MayoridaEdad : Ejercicio
{
    private int edad;

    public int Edad
    {
        get => edad;
        set => edad = value;
    }

    public Ejercicio_MayoridaEdad(int edad) : base(3, "Checar si es ciudadano", 
        "Comprueba si la persona es mayor de edad")
    {
        Edad = edad;
    }

    public override void Ejecutar()
    {
        if (Edad >= 18)
        {
            Console.WriteLine("Es ciudadano");
        }
        else
        {
            Console.WriteLine("No es ciudadano");
        }
    }
}