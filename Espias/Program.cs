using System;

namespace Espias
{
    class Persona
    {
	    public string nombre;
	    public string apellido;

	    public Persona() {
		nombre = 'Fulano';
		apellido = 'De tal';
	    }
    }

    class Anonymous
    {
	    static public void anonimiza(Persona p) { 
			p.nombre = 'xxxxxxxxx';
			p.apellido = 'xxxxxxxxx';
	    }
        static void Main(){
		Persona espía = new Persona();

		Console.WriteLine(espía.nombre);
		anonimiza(espía);
		Console.WriteLine(espía.nombre);

	    }
    }
}
