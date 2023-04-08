using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto11
{
    internal class EmpleadoHonorarios : Empleado
    {
        public decimal SueldoBase { get; set; }

        // Al empleado con honorarios se le deduce parte de su sueldo en impuestos
        public override decimal Salario
        {
            get
            {
                return SueldoBase * 0.84m;
            }
        }

        public EmpleadoHonorarios(string nombre, string puesto, decimal sueldoBase) : base(nombre, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por Honorarios");
        }
    }
}
