using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Eliminador
    {
        private String numeroDeSerie;
        private String tipo;
        private int prioridad;
        private String objetivo;
        private Int32 añoDeDestino;

        public string NumeroDeSerie { get => numeroDeSerie; set => numeroDeSerie = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Prioridad { get => prioridad; set => prioridad = value; }
        public string Objetivo { get => objetivo; set => objetivo = value; }
        public int AñoDeDestino { get => añoDeDestino; set => añoDeDestino = value; }
    }
}
