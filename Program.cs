internal class Program

{
    private static void Main(string[] args)
    {
        Televisor televisor = new Televisor("Samsung", "Oled", 32, false);
        Domicilio domicilio = new Domicilio("Jonte", 5299, "Monte Castro");
        Persona persona = new Persona("Facundo ", domicilio);
        Persona persona2 = new Persona("Camila ", domicilio);
        // mostramos los datos del tv y a quien le pertenece
        Console.WriteLine("Datos del tv :" +televisor+ ", este le pertenece a "+persona.getNombre()+" y a "+persona2.getNombre());
        //mostramos nombre y domicilio gracias a ToString de cada clase solo imprimiendo el objeto persona
        Console.WriteLine(persona);
        Console.WriteLine(persona2);


    }
}