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
        

        public void ListadoPersonasCasadas()
        {
            
        }


        public void PromedioEdadSociosRacin()
        {

            int edad = 0;
            int contSociosRacing = 0;

            foreach (var linea in lineas)
            {
                var valores = linea.Split(";");
                if (valores[2] == "Racing")
                {
                    contSociosRacing++;

                    edad = edad + Convert.ToInt32(valores[1]);
                }
            }

            double promedioEdad = (edad / contSociosRacing);
            Console.WriteLine(promedioEdad);
        }

    }   
}
