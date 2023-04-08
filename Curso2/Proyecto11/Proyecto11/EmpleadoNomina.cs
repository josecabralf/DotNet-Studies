using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto11
{
    // Para que una clase que hereda de una abstracta compile, se debe cumplir 1/2 condiciones:
    // 1- La clase hija es abstracta
    // 2- La clase hace override a todos los componentes abstractos de la clase padre
    internal class EmpleadoNomina : Empleado
    {
        public decimal SueldoBase { get; set; }
        public override decimal Salario
        {
            get { return SueldoBase; }
        }
        public EmpleadoNomina(string nombre, string puesto, decimal sueldoBase) : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }
        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por Nomina");
        }
    }
}
