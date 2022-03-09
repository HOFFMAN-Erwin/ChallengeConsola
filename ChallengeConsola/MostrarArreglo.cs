using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace ChallengeConsola
{
    class MostrarArreglo
    {
        ArrayList Lista;

        string[] lineas = File.ReadAllLines(@"C:\Users\Usuario\source\repos\ChallengeConsola\ChallengeConsola\ArchivoALeer\socios.csv");

            public MostrarArreglo()
        {

            Lista = new ArrayList();

        }

        public void CapturaDatos()
        {
            foreach (var linea in lineas)
            {
                var valores = linea.Split(";");

                //Console.WriteLine("Nombre: " + valores[0] +" Edad: "+valores[1]+" Equipo: "+valores[2]+" Estado Civil: "+valores[3]+" Nivel de estudios: "+valores[4]);
                //Console.WriteLine("Cantidad total de personas registradas: " + lineas.Length);
            }
        }
   
        }   
}
