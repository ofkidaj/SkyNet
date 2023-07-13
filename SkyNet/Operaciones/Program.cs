using DTO;
using DTO.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet
{
    public partial class Program
    {
        static void IngresarEliminador()
        {
            String numeroDeSerie;
            String tipo;
            int prioridad;
            String objetivo;
            Int32 añoDeDestino;
            Boolean esValido;

            Console.WriteLine(" Bienvenido al programa de SkyNet");
            //numero de serie
            do
            {
                Console.WriteLine("Ingrese Numero De Serie Del Eliminador");
                numeroDeSerie = Console.ReadLine().Trim().ToUpper();
            } while (numeroDeSerie.Equals(string.Empty) || numeroDeSerie.Length != 7);
            //tipo
            do
            {
                Console.WriteLine("Ingrese Tipo Del Eliminador");
                Console.WriteLine("A)T-1");
                Console.WriteLine("B)T-800");
                Console.WriteLine("C)T-1000");
                Console.WriteLine("D)T-3000");
                tipo = Console.ReadLine().Trim().ToLower();
                if (tipo != ("a") && tipo != ("b") && tipo != ("c") && tipo != ("d"))
                {
                    esValido = false;
                }
                else
                {
                    esValido = true;
                    switch (tipo)
                    {
                        case "a":
                            tipo = "T-1";
                            break;
                        case "b":
                            tipo = "T-800";
                            break;
                        case "c":
                            tipo = "T-1000";
                            break;
                        case "d":
                            tipo = "T-3000";
                            break;
                    }
                }

            } while (esValido != true);
            //prioridad
            do
            {
                Console.WriteLine("Ingrese Prioridad Del Objetivo (1-5)");
                esValido = int.TryParse(Console.ReadLine().Trim(), out prioridad);

            } while (!esValido && prioridad != 1 && prioridad != 2 && prioridad != 3 && prioridad != 4 && prioridad != 5);
            //objetivo*
            do
            {
                Console.WriteLine("Ingrese Objetivo Del Eliminador");
                objetivo = Console.ReadLine().Trim().ToUpper();
                //priorisar a 999 a eliminadores

                List<Eliminador> filtradas = new EliminadorDAL().FiltrarEliminador(objetivo);
                filtradas.ForEach(eliminador => prioridad = 999);

            } while (objetivo.Equals(string.Empty));
            //año de destino
            do
            {
                Console.WriteLine("Ingrese Año De Destino Del Eliminador");
                esValido = Int32.TryParse(Console.ReadLine().Trim(), out añoDeDestino);
            } while (!esValido || añoDeDestino < 1997 || añoDeDestino > 3000);


            Eliminador e = new Eliminador()
            {
                NumeroDeSerie = numeroDeSerie,
                Tipo = tipo,
                Prioridad = prioridad,
                Objetivo = objetivo,
                AñoDeDestino=añoDeDestino
            };

            new EliminadorDAL().AgregarEliminador(e);

            Console.WriteLine("Numero de serie: {0}", e.NumeroDeSerie);
            Console.WriteLine("Tipo: {0}", e.Tipo);
            Console.WriteLine("Prioridad: {0}", e.Prioridad);
            Console.WriteLine("Objetivo: {0}", e.Objetivo);
            Console.WriteLine("Año de destino: {0}", e.AñoDeDestino);

        }
        static void MostrarEliminador()
        {
            List<Eliminador> eliminador = new EliminadorDAL().ObtenerEliminador();
            for (int i = 0; i < eliminador.Count(); i++)
            {
                Eliminador actual = eliminador[i];
                Console.WriteLine("{0}: Numero de serie: {1} Tipo: {2} Objetivo: {3}", i, actual.NumeroDeSerie, actual.Tipo, actual.Objetivo);
            }
        }


        static void BuscarEliminador()

        {
            Console.WriteLine("Ingrese Numero De Serie");
            List<Eliminador> filtradas = new EliminadorDAL().FiltrarEliminador(Console.ReadLine().Trim().ToUpper());
            filtradas.ForEach(e => Console.WriteLine("Numero de serie: {0} Tipo: {1} Objetivo: {2}", e.NumeroDeSerie, e.Tipo, e.Objetivo));
        }
    }
}
