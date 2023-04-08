using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto4
{
    internal class CuentaBancaria
    {
        #region Propiedades
        // Propiedades Automáticas: pueden utilizarse para leer/escribir datos directamente
        public string NoCuenta { get; set; }
        public string Usuario { get; set; }

        // Propiedades Completas: pueden utilizarse get y set para hacer validaciones
        // Backing Field: campo para guardar valor para propiedad completa
        private decimal _saldo;
        public decimal Saldo
        {
            get { return _saldo; }
            set
            {
                // Evitar que saldo sea negativo

                // Con if - else
                /*if(value < 0) { _saldo = 0; }
                else { _saldo = value; }*/

                // Con operador ternario: reduce if-else a 1 sola línea
                _saldo = value < 0 ? 0 : value;
            }
        }

        // Propiedades Estáticas: no cambian y son las mismas para todos los objetos
        public static string Banco { get; set; }
        #endregion

        #region Constructores
        // Construir Constructor de Objetos: Sintaxis
        // Pueden existir varios constructores para varias Aplicaciones

        // Constructor con solo NoCuenta [Constructor Base]
        public CuentaBancaria(string noCuenta)
        {
            NoCuenta = noCuenta;
        }

        // Constructor con NoCuenta y Usuario
        // Para no repetir código del constructor anterior se utiliza
        // ": this(noCuenta)" Eso llama al constructor que solo realize el NoCuenta
        public CuentaBancaria(string noCuenta, string usuario) : this(noCuenta)
        {
            Usuario = usuario;
        }

        // Constructor para todos los Atributos
        public CuentaBancaria(string noCuenta, string usuario, decimal saldo) : 
            this(noCuenta, usuario)
        {
            Saldo = saldo;
        }

        // Constructor Vacío (solo se genera por default cuando no existe
        // otro constructor)
        public CuentaBancaria() { }
        #endregion

        #region Métodos
        public void Retirar(decimal cantidad)
        {
            if(Saldo < cantidad)
            {
                Console.WriteLine("Saldo insuficiente. No se ha realizado transacción.");
                return;
            }
            Saldo -= cantidad;
            Console.WriteLine("Saldo Restante: {0}", Saldo);
        }

        public void Depositar(decimal cantidad)
        {
            Saldo += cantidad;
            Console.WriteLine("Saldo Final: {0}", Saldo);
        }
        

        // Método ToString()
        public override string ToString()
        {
            return String.Format("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", NoCuenta, Usuario, Saldo);
        }

        // Método Estático: solo modifican propiedades estáticas
        // Notar que estos no pueden modificar propiedades no estáticas
        public static void AsignarBanco(string banco)
        {
            Console.WriteLine("Asignando Banco {0}", banco);
            Banco = banco;
        }
        #endregion

        #region Miembros Estáticos
        // Los miembros estáticos pertenecen a la clase, no a las instancias
        // Para acceder a ellos solo se necesita el nombre de la Clase
        #endregion
    }
}
