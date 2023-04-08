using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto15
{
    // Estructura: tipo de dato de C# similar a una clase
    // Permiten crear entidades con atributos y métodos
    // Se utilizan para datos sencillos que no requieran de propiedades de clases (Ej. Herencia)
    
    // Creación: "struct"
    internal struct Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        // No se puede definir un constructor vacío en un struct
        // Todos los constructores deben llamar al constructor vacío implícito
        public Vector(double x, double y, double z) : this()
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double CalcModulo()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        } 

        public Vector Suma(Vector otro)
        {
            Vector v = new Vector(X + otro.X, Y + otro.Y, Z + otro.Z);
            return v;
        }

        public override string ToString()
        {
            return String.Format("[{0}, {1}, {2}]", X, Y, Z);
        }
    }
}
