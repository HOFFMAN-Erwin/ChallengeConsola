using System;
using System.IO;
using System.Collections.Generic;

namespace ChallengeConsola
{
    class Program
    {
        static void Main(string[] args)
        {

            MostrarArreglo Muestra = new MostrarArreglo();
            Muestra.CapturaDatos();
            
            /*string[] lineas = File.ReadAllLines(@"C:\Users\Usuario\source\repos\ChallengeConsola\ChallengeConsola\ArchivoALeer\socios.csv");

            foreach (var linea in lineas)
            {
                var valores = linea.Split(";");

                //Console.WriteLine("Nombre: " + valores[0] +" Edad: "+valores[1]+" Equipo: "+valores[2]+" Estado Civil: "+valores[3]+" Nivel de estudios: "+valores[4]);
                //Console.WriteLine("Cantidad total de personas registradas: " + lineas.Length);

            }*/
            
        } 
        
       

    }     
}
