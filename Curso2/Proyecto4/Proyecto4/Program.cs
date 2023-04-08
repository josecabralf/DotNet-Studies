namespace Proyecto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Constructores
            /*// Usando constructor de 1 argumento
            CuentaBancaria cuenta0 = new CuentaBancaria("43A2");
            Console.WriteLine(cuenta0.ToString());

            // Usando constructor de 2 argumentos
            CuentaBancaria cuenta3 = new CuentaBancaria("43A3", "Sasquasch");
            Console.WriteLine(cuenta3.ToString());*/
            #endregion
            #region Propiedades
            // cuenta1.Saldo = -5;
            // Console.WriteLine("Saldo pos Asignación: {0}", cuenta.Saldo);
            #endregion
            #region Métodos
            /*// Llamar métodos:
            Console.WriteLine("Depositar 45:");
            cuenta1.Depositar(45);
            Console.WriteLine("Retirar 45:");
            cuenta1.Retirar(30);
            Console.WriteLine("Retirar 70:");
            cuenta1.Retirar(70);

            Console.WriteLine();
            Console.WriteLine(cuenta.ToString());*/
            #endregion

            // Usando constructor de 3 argumentos
            CuentaBancaria cuenta1 = new CuentaBancaria("43A4", "Theren Infelkir", 150);
            CuentaBancaria cuenta2 = new CuentaBancaria("24B3", "Joseph Joestar", 250);

            // Para acceder a miembros estáticos solo se usa el nombre de la clase
            CuentaBancaria.Banco = "Mi Banco";

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);

            Console.WriteLine("CAMBIANDO BANCO!");
            CuentaBancaria.AsignarBanco("Santander");
        }
    }
}