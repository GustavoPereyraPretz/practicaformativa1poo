using System;

public class Domicilio
{
	private String calle;
	private int numero;
	private String barrio;

    public Domicilio(string calle, int numero, string barrio)
    {
        this.calle = calle;
        this.numero = numero;
        this.barrio = barrio;
    }
    public override String ToString()
    {
        return "Calle " + calle + " nro " + numero + " barrio " + barrio;
    }
    

}

