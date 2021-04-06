using System;
using System.Linq;
using System.Collections.Generic;
namespace EJERCICIO3_14843
{
    public static class Tools{
        
        public static void ordenarAlfabeticamente(List<Persona> personas){
            Console.WriteLine("\nOrdenadas Alfabeticamente:");
            var ordenarAlfabeticamente = personas.OrderBy(x => x.NombreCompleto).ToList();
            
            foreach(Persona p in ordenarAlfabeticamente){
                Console.WriteLine(p);
            }
        }
        
        public static void ObtnereMayores(List<Persona> personas) {
            Console.WriteLine("\nMayores:");
            var mayores = personas.Where(x => x.sosMayor()).ToList();

            foreach(Persona p in mayores){
                Console.WriteLine(p);
            }
        }
        
        public static void ObtenerHombres(List<Persona> personas){
            Console.WriteLine("\nHombres:");
            
            var hombres = personas.Where(x=>x.sosHombre()).ToList();
            foreach(Persona p in hombres){
                Console.WriteLine(p);
            }
        }
        public static void ObtenerMujeres(List<Persona> personas){
            Console.WriteLine("\nMujeres:");
            var mujeres = personas.Where(x=>x.sosMujer()).ToList();
            
            foreach(Persona p in mujeres){
                Console.WriteLine(p);
            }
        }
        public static void ObtenerApellidoConLetra(List<Persona> personas, Char letra){
            letra = Char.ToUpper(letra);
            Console.WriteLine("\nApellidos con letra '"+letra+":'");
            
            var apellidosComenzadosConLetra = personas.Where(x => x.apellidoEmpiezaCon(letra) ).ToList();
            
            foreach (Persona ape in apellidosComenzadosConLetra){
                Console.WriteLine(ape);
            }
        }

        public static void ObtenerCantidadPersonas(List<Persona> personas){
            Console.WriteLine("\nCantidad de Personas:");
            Console.WriteLine(personas.Count());
        }
    }
}