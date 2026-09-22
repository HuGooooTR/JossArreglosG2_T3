using System;
using System.Collections.Generic;
using System.Text;

namespace Arreglos.Logica
{
    public class MiArreglo
    {
        //Atributos o campos
        private int _tope;
        private int[] _arreglo;

        //Constructor
        public MiArreglo(int n)
        {
            N = n;
            _arreglo = new int[N];
            _tope = 0;
        }

        //Propiedades
        public int N { get; }
        public bool EstaVacio => _tope == 0;
        public bool EstaLleno => _tope == N;

        //Metodos
    }
}
