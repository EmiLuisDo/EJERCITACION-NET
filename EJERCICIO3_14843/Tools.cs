using System;
using System.Linq;
using System.Collections.Generic;
namespace EJERCICIO3_14843
{
    public static class Tools{
        
        public static void ordenarAlfabeticamente(List<Persona> personas){
            Console.WriteLine("\nOrdenadas Alfabeticamente:");
            personas.Sort();
            foreach(Persona p in personas){
                Console.WriteLine(p);
            }
        }
        
        public static void ObtnereMayores(List<Persona> personas) {
            Console.WriteLine("\nMayores:");
            List<Persona> mayores = personas.FindAll(
                delegate(Persona per)
                {
                    return per.sosMayor();
                }
            );
            foreach(Persona p in mayores){
                Console.WriteLine(p);
            }
        }
        
        public static void ObtenerHombres(List<Persona> personas){
            Console.WriteLine("\nHombres:");
            List<Persona> hombres = personas.FindAll(
                delegate(Persona per)
                {
                    return per.sosHombre();
                }
            );
            foreach(Persona p in hombres){
                Console.WriteLine(p);
            }
        }
        public static void ObtenerMujeres(List<Persona> personas){
            Console.WriteLine("\nMujeres:");
            List<Persona> mujeres = personas.FindAll(
                delegate(Persona per)
                {
                    return per.sosMujer();
                }
            );
            foreach(Persona p in mujeres){
                Console.WriteLine(p);
            }
        }
        public static void ObtenerApellidoConLetra(List<Persona> personas, Char letra){
            letra = Char.ToUpper(letra);
            Console.WriteLine("\nApellidos con letra '"+letra+":'");
            
            List<String> apellidosComenzadosConLetra = new List<String> ();
            foreach(Persona p in personas){
                if((!apellidosComenzadosConLetra.Contains(p.Apellido)) && p.apellidoEmpiezaCon(letra)){
                    apellidosComenzadosConLetra.Add(p.Apellido);
                }
            }
            foreach(String ape in apellidosComenzadosConLetra){
                Console.WriteLine(ape);
            }
        }
        public static void ObtenerCantidadPersonas(List<Persona> personas){
            Console.WriteLine("\nCantidad de Personas:");
            Console.WriteLine(personas.Count());
        }
    }
}