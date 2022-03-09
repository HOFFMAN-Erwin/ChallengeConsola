using System;
using System.IO;
using System.Collections.Generic;

namespace ChallengeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string ubicacionArchivo = @"C:\Users\Usuario\source\repos\ChallengeConsola\ChallengeConsola\ArchivoALeer\socios.csv";
            System.IO.StreamReader archivo = new System.IO.StreamReader(ubicacionArchivo);

            string separador = ";";
            string linea;

            while ((linea=archivo.ReadLine()) !=null)
            {
                string[] fila = linea.Split(separador);
                string nombre = fila[0];
                string edad = fila[1];
                string equipo = fila[2];
                string estadoCivil = fila[3];
                string nivelEstudios = fila[4];
                Console.WriteLine("Nombre {0}, edad {1}, equipo {2}, estado civil: {3}, nivel de estudios {4}", nombre,edad,equipo,estadoCivil,nivelEstudios);
            }*/

            string[] lineas = File.ReadAllLines(@"C:\Users\Usuario\source\repos\ChallengeConsola\ChallengeConsola\ArchivoALeer\socios.csv");


            foreach (var linea in lineas)
            {
                var valores = linea.Split(";");

                //Console.WriteLine("Nombre: " + valores[0] +" Edad: "+valores[1]+" Equipo: "+valores[2]+" Estado Civil: "+valores[3]+" Nivel de estudios: "+valores[4]);
                Console.WriteLine("Cantidad total de personas registradas: " + lineas.Length);

                
            }

            

        }


    }
}
