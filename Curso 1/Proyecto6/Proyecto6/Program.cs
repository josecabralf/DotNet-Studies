namespace Proyecto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Conditionals: if, else if, else
            // Sintaxis: if (argumento) {cuerpo}
            bool t = true;
            if (t) ;
            {
                Console.WriteLine("Booleans!");
            }
            int a = 0;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine("Yooha");
            }
            else if (b < a)
            {
                Console.WriteLine("Yahoo");
            }
            else
            {
                Console.WriteLine("Wawaa");
            }

            // Ternary Operator:
            // type varName = (Test) ? True: False;
            // Si la condicion es True, se ejecuta la parte anterior al ":"
            // Si la condicion es False, se ejecuta la parte posterior al ":"
            int c = 3;
            string res = (c == 0) ? "C es igual 0" : "C no es igual a 0";
            Console.WriteLine(res);

            // Switch: execute a case based on expression
            // Sintaxis: Switch(testExpresion)
            // {Case A: [...] break; Case B: [...] break; default: [...] break;}
            // El programa va a ejecutar el caso de valor igual a la expresión
            switch (c)
            {
                case 1:
                    Console.WriteLine("Aruba");
                    break;
                case 2:
                    Console.WriteLine("Bahamas");
                    break;
                case 3:
                    Console.WriteLine("Come on Pretty Momma");
                    break;
                default:
                    Console.WriteLine(":(");
                    break;
            }
        }
    }
}