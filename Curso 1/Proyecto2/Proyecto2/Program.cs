namespace Proyecto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sintaxis de Variables: type name = value;

            //Name: Reglas:
            // 1- Pueden contener letras y _
            // 2- Comienzan con letra
            // 3- No " "
            // 4- Case sensitive y camelCaseMethod
            // 5- No usar reserved keywords

            //Types: var or const
            //string [cadenas]
            //int (4 bytes) or long (8 bytes) [Ej. -1, 0, 1, ...]
            //float (4 bytes) or double (8 bytes) [Ej. 3,1426...]
            //bool [Booleano T/F, 0/1]
            //char [único caracter: Ej. "f"

            string mensaje = "Hola Mundo";
            char caracter = 'a';
            int nro = 10;
            long nrazo = 20000000000000000L;
            double fraccion = 1 / 3D;
            bool booleano = true;

            Console.WriteLine(mensaje);
            Console.WriteLine(caracter);
            Console.WriteLine(nro);
            Console.WriteLine(nrazo);
            Console.WriteLine(fraccion);
            Console.WriteLine(booleano);
            Console.WriteLine();


            //var.GetType(): devuelve el tipo de variable
            // Ej. mensaje.GetType: string
            Console.WriteLine(mensaje.GetType());
            Console.WriteLine();
            //Cambios de Tipo:

            //Se puede agrandar el espacio ocupado facilmente
            int newNum = 11;
            double newNum2 = newNum;

            //Para achicar:
            double newNum3 = 11.32;
            int newNum4 = (int)newNum3;
            Console.WriteLine(newNum3);
            Console.WriteLine(newNum4);

            //Conversiones de tipo usando métodos:
            int integer = 20;
            double dob = 11.25;
            bool boolean = true;

            Console.WriteLine(Convert.ToString(integer));
            Console.WriteLine(Convert.ToInt32(dob));
            Console.WriteLine(Convert.ToString(boolean));

            Console.ReadKey();
        }
    }
}