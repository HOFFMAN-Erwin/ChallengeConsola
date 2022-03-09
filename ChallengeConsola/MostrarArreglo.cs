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

                Console.WriteLine("Nombre: " + valores[0] +" Edad: "+valores[1]+" Equipo: "+valores[2]+" Estado Civil: "+valores[3]+" Nivel de estudios: "+valores[4]);
            }
        }

        public void CantidadDatos()
        {
            Console.WriteLine("Cantidad total de personas registradas: " + lineas.Length);
        }
        public void PromedioEdadSociosRacin()
        {
       
            int[] arregloRacing = new int[lineas.Length];

            for (int i = 0; i < lineas.Length; i++)
            {
                arregloRacing[i] = Convert.ToInt32(linea[i]);
            }
            
            double sumatoria = 0;
            
            foreach (var linea in lineas)
            {
                var hinchas = lineas[2];
                if (hinchas=="Racing")
                {
                    sumatoria += arregloRacing[1];
                }
            }

            double promedio = sumatoria / arregloRacing.Length;
            Console.WriteLine("Promedio de edades de los hinchas de racing: " + promedio);
        }

        public void ListadoPersonasCasadas()
        {
            
        }

        public void ValorLineas()
        {
            for (int i = 0; i < lineas.Length; i++)
            {
                Console.WriteLine(lineas[1]);
            }
        }
    }   
}
