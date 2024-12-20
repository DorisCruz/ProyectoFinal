﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo
{
    public class Nodo
    {
        private int dato;
        private Nodo sig = null;
        private Nodo ant = null;

        public Nodo(int dato)
        {
            this.dato = dato;
        }

        public int Dato { get => dato; set => dato = value; }
        public Nodo Sig { get => sig; set => sig = value; } // Cambiado a public
        public Nodo Ant { get => ant; set => ant = value; } // Cambiado a public

        public override string ToString()
        {
            return string.Format("[{0}]", dato);
        }
    }
}
