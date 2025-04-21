using System;

public class Persona
{
    private String nombre;
    private Domicilio domicilio;

    public Persona(string nombre, Domicilio domicilio)
    {
        this.nombre = nombre;
        this.domicilio = domicilio;
    }
    public override string ToString()
    {
        return "Nombre "+this.nombre+"  domicilio :"+this.domicilio;
    }

    public String getNombre()
    {
        return this.nombre;
    }
}


