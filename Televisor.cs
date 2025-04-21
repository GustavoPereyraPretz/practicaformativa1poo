using System;


public class Televisor
{
    private String marca;
    private String modelo;
    private int cant_pulg;
    private bool estado;
	public Televisor(string marca, string modelo, int cant_pulg, bool estado)
    {
        this.marca = marca;
        this.modelo = modelo;
        this.cant_pulg = cant_pulg;
        this.estado = estado;
    }

    public override string ToString()
    {
        return "Marca " + this.marca + ", modelo " + this.modelo + ", cantidad de pulgadas " + this.cant_pulg + ", estado(prendido): " + this.estado;
    }
  public int obtenerCanalActual()
    {
    System.Console.WriteLine("hello world");
    return 0;
    }
}
