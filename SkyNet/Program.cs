﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyNet
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            while (Menu()) ;
        }
        static bool Menu()
        {
            bool continuar = true;
            Console.WriteLine("1.Ingresar Eliminador");
            Console.WriteLine("2.Buscar Eliminador");
            Console.WriteLine("3.Mostrar Eliminador");
            Console.WriteLine("0.Destruir SkyNet");

            switch (Console.ReadLine().Trim())
            {
                case "1":
                    IngresarEliminador();
                    break;
                case "2":
                    BuscarEliminador();
                    break;
                case "3":
                    MostrarEliminador();
                    break;
                case "0":
                    continuar = false;
                    Console.WriteLine("SkyNet destruido");
                    break;

                default:
                    Console.WriteLine(" Ingrese tecla correctamente");
                    
                    break;
            }
            return continuar;
        }
    }
}
