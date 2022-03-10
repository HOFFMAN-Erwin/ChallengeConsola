using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using System.Collections.Specialized;

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

        /*public void CapturaDatos()
        {
            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(";");

                Console.WriteLine("Nombre: " + valores[0] +" Edad: "+valores[1]+" Equipo: "+valores[2]+" Estado Civil: "+valores[3]+" Nivel de estudios: "+valores[4]);
            }
        }*/

        public void CantidadDatos()
        {
            Console.WriteLine("Cantidad total de personas registradas: " + lineas.Length+"\n");
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
            Console.WriteLine("El promedio de edad de los socios de racing es de: "+promedioEdad+"\n");
        }

        public Usuario CrearHincha(int edad, string nombre, string cuadro, string estadoCivil, string estudios)
        {
            Usuario nuevoHincha = new Usuario();
            nuevoHincha.edad = edad;
            nuevoHincha.nombre = nombre;
            nuevoHincha.cuadro = cuadro;
            nuevoHincha.estudios = estudios;
            nuevoHincha.estadoCivil = estadoCivil;
            return nuevoHincha;
        }
        //Deberia realizarse una encapsulacion correcta para proteger los datos sensitivos.
        public Equipo CrearEquipo(List<Usuario> miembros,string nombre)
        {
            Equipo nuevoEquipo = new Equipo();
            int nSocios=miembros.Count;
            int edadMenor=999;
            int edadMayor=0;
            int edadSum=0;
            double promedioEdad=0;

            

            foreach (Usuario item in miembros)
            {
                edadSum += item.edad;
                if (edadMenor>item.edad)
                {
                    edadMenor = item.edad;
                }

                if (edadMayor < item.edad)
                {
                    edadMayor = item.edad;
                }
            }
            promedioEdad = edadSum / nSocios;

            nuevoEquipo.nSocios = nSocios;
            nuevoEquipo.edadMenor = edadMenor;
            nuevoEquipo.edadMayor = edadMayor;
            nuevoEquipo.nombre = nombre;
            nuevoEquipo.promedioEdad = promedioEdad;
            return nuevoEquipo;       
        }
        public void ListadoPersonasCasadasYUniversitarios()
        {

            List<Usuario> hinchas = new List<Usuario>();

            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(";");
                if (valores[3] == "Casado" && valores[4] == "Universitario")
                {
                    hinchas.Add(CrearHincha(int.Parse(valores[1]), valores[0], valores[2], valores[3], valores[4]));
                }
            }

            hinchas = hinchas.OrderBy(z => z.edad).ToList();

            for (int i = 0; i < 99; i++)
            {
                Console.WriteLine(" Nombre: " + hinchas[i].nombre + " Edad: " + hinchas[i].edad.ToString() +  " Equipo: " + hinchas[i].cuadro+"\n");
            }

        }

        public void ListaHinchaRiver()
        {
            List<Usuario> hinchasRiver = new List<Usuario>();
            Dictionary<string, List<Usuario>> diccionarioRiver = new Dictionary<string, List<Usuario>>();
            List<Usuario> nombreSumados = new List<Usuario>();

            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(";");
                if (valores[2] == "River")
                {
                    hinchasRiver.Add(CrearHincha(int.Parse(valores[1]), valores[0], valores[2], valores[3], valores[4]));
                }
            }

            foreach (Usuario item in hinchasRiver)
            {
                if (!diccionarioRiver.ContainsKey(item.nombre))
                {
                   diccionarioRiver.Add(item.nombre, new List<Usuario>());
                }

                diccionarioRiver[item.nombre].Add(item);
            }


            foreach (var item in diccionarioRiver)
            {
                nombreSumados.Add(CrearHincha(item.Value.Count, item.Key, "", "", ""));
            }

            nombreSumados = nombreSumados.OrderByDescending(z => z.edad).ToList();

            Console.WriteLine("Nombres mas comunes entre los hinchas de river\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Nombre: "+nombreSumados[i].nombre + " || Cantidad de hinchas: " + nombreSumados[i].edad.ToString());
            }
        }

        public void ListadoCantidadSocios()
        {
            List<Usuario> hinchas = new List<Usuario>();
            Dictionary<string, List<Usuario>> diccionarioEquipos = new Dictionary<string, List<Usuario>>();
            List<Equipo> equipos = new List<Equipo>();

            foreach (string linea in lineas)
            {
                string[] valores = linea.Split(";");
                
                hinchas.Add(CrearHincha(int.Parse(valores[1]), valores[0], valores[2], valores[3], valores[4]));
                
            }

            foreach (Usuario item in hinchas)
            {
                if (!diccionarioEquipos.ContainsKey(item.cuadro))
                {
                    diccionarioEquipos.Add(item.cuadro, new List<Usuario>());
                }

                diccionarioEquipos[item.cuadro].Add(item);
            }

            
            foreach (var item in diccionarioEquipos)
            {
                equipos.Add(CrearEquipo(item.Value, item.Key));

            }

           equipos = equipos.OrderByDescending(z => z.nSocios).ToList();

            Console.WriteLine("Datos de edades de los socios en los clubes\n");

            foreach (Equipo item in equipos)
            {
                Console.WriteLine("Equipo: " +item.nombre +" || Numero de Socios: " + item.nSocios + " || Promedio de edades: " + item.promedioEdad + " || Menor edad registrada: " + item.edadMenor + " || Mayor edad registrada: " + item.edadMayor+"\n");
            }

            for (int i = 0; i < 5; i++)
            {

            }
        }

        public void MostrarCodigo()
        {
            do
            {
                Console.WriteLine("Bienvenidos al challenge!\nEscriba un numero entre el 1 y el 5 para ver el resultado de las consignas.\nIngrese 0 para finalizar");
                int valor = int.Parse(Console.ReadLine());
                switch (valor)
                {
                    case 1:
                        CantidadDatos();
                        break;
                    case 2:
                        PromedioEdadSociosRacin();
                        break;
                    case 3:
                        ListadoPersonasCasadasYUniversitarios();
                        break;
                    case 4:
                        ListaHinchaRiver();
                        break;
                    case 5:
                        ListadoCantidadSocios();
                        break;
                    case 0: break;
                    default:
                        Console.WriteLine("Se ingreso un numero fuera de rango.\n");
                        break;
                }
            } while (true);
        }
    }   
}
