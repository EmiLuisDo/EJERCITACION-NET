using System;
using System.Collections.Generic;

namespace EJERCICIO3_14843
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Emiliano", "Dominguez", Persona.masculino, new DateTime(2008, 6, 12)));
            personas.Add(new Persona("Sabrina", "Dominguez", Persona.femenino, new DateTime(2009, 9, 24)));
            personas.Add(new Persona("Luis", "Dominguez", Persona.masculino, new DateTime(1963, 6, 19)));
            personas.Add(new Persona("Nancy", "Ferreyra", Persona.femenino, new DateTime(1967, 7, 21)));
            personas.Add(new Persona("Fabian", "Alegre", Persona.masculino, new DateTime(2007, 5, 10)));
            personas.Add(new Persona("Gabriel", "Candia", Persona.masculino, new DateTime(1994, 12, 24)));
            personas.Add(new Persona("Vanesa", "Santos", Persona.femenino, new DateTime(1993, 4, 26)));
            personas.Add(new Persona("Carolina", "Dehle", Persona.femenino, new DateTime(2010, 1, 1)));
            personas.Add(new Persona("Nicolas", "Ibarra", Persona.masculino, new DateTime(1996, 7, 17)));
            personas.Add(new Persona("Alvaro", "Arganiaras", Persona.masculino, new DateTime(2005, 11, 18)));
            Tools.ordenarAlfabeticamente(personas);
            Tools.ObtnereMayores(personas);
            Tools.ObtenerHombres(personas);
            Tools.ObtenerMujeres(personas);
            Tools.ObtenerApellidoConLetra(personas, 'a');
            Tools.ObtenerCantidadPersonas(personas);
        }
    }
}
