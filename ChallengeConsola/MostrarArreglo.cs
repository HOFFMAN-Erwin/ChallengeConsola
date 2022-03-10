using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Linq;

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
            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(";");

                Console.WriteLine("Nombre: " + valores[0] +" Edad: "+valores[1]+" Equipo: "+valores[2]+" Estado Civil: "+valores[3]+" Nivel de estudios: "+valores[4]);
            }
        }

        public void CantidadDatos()
        {
            Console.WriteLine("Cantidad total de personas registradas: " + lineas.Length);
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

        public class CasadosUniversitarios
        {
            public int edad;
            public string nombre = "";
            public string cuadro = "";
            public string estadoCivil = "";
            public string estudios = "";
        }

        public CasadosUniversitarios crearHincha(int edad, string nombre, string cuadro, string estadoCivil, string estudios)
        {
            CasadosUniversitarios nuevoHincha = new CasadosUniversitarios();
            nuevoHincha.edad = edad;
            nuevoHincha.nombre = nombre;
            nuevoHincha.cuadro = cuadro;
            nuevoHincha.estudios = estudios;
            nuevoHincha.estadoCivil = estadoCivil;
            return nuevoHincha;
        }
        public void ListadoPersonasCasadasYUniversitarios()
        {


            List<CasadosUniversitarios> clientes = new List<CasadosUniversitarios>();

            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(";");
                if (valores[3] == "Casado" && valores[4] == "Universitario")
                {
                    clientes.Add(crearHincha(int.Parse(valores[1]), valores[0], valores[2], valores[3], valores[4]));
                }
            }

            List<CasadosUniversitarios> listaOrdenada = clientes.OrderBy(z => z.edad).ToList();

            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine("Edad: " + listaOrdenada[i].edad.ToString() + " Nombre: " + listaOrdenada[i].nombre + " Equipo: " + listaOrdenada[i].cuadro);
            }

            /*ArrayList listaCasadosUniversitarios = new ArrayList();


            foreach (var linea in lineas)
            {
                var valores = linea.Split(";");
                if (valores[3]=="Casado" && valores[4]=="Universitario")
                {
                    listaCasadosUniversitarios.Add(linea);
                }
                /*if (listaCasadosUniversitarios.Count > 99)
                {
                    break;
                }
            }
            listaCasadosUniversitarios.Sort();
            foreach (string linea in listaCasadosUniversitarios)
            {
                string[] nuevoArrayString = linea.Split(";");
                Console.WriteLine(linea);
            }*/
        }
    }   
}
