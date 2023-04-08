﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto10
{
    // Indicar Herencia
    internal class Empleado : Persona
    {
        public string Puesto { get; set; }
        public decimal Sueldo { get; set; }

        // Inicialización de una clase hija
        public Empleado(string name, int age, string puesto, decimal sueldo) : base(name, age)
        { 
            Puesto = puesto;
            Sueldo = sueldo;
        }

        // Modificar método padre
        public override void Saludar()
        {
            Console.WriteLine("Hola {0}, {1}", Name, Puesto);
        }

        public void Trabajar()
        {
            Console.WriteLine("{0} está trabajando", Name);
        }

        public override string ToString()
        {
            return String.Format("{0}: {1} | {2} | Sueldo: ${3}", Name, Age, Puesto, Sueldo);
        }
    }
}
