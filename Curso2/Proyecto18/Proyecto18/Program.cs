using System.Text;

namespace Proyecto18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region String

            /*// Concatenación de Cadenas
            Console.WriteLine("Hola" + " mundo");
            Console.WriteLine(String.Concat("Hola ", "mundo"));

            string cad = "Cadena de Prueba";

            // Obtener tamaño de cadena
            Console.WriteLine(cad);
            Console.WriteLine("Tamaño: " + cad.Length);

            // Mínuscula Mayuscula
            Console.WriteLine("Min: " + cad.ToLower());
            Console.WriteLine("May: " + cad.ToUpper());

            // Método Replace(car a cambiar, car colocado)
            Console.WriteLine("Replace: " + cad.Replace("a", "A"));

            // Método Substring(indice car ini, cant car)
            Console.WriteLine("Substring (1-8): " + cad.Substring(1, 8));

            // Método Contains("cad a chequear")
            Console.WriteLine("Cadena contiene 'i'?" + cad.Contains("i"));

            // Método StartWith
            Console.WriteLine("Cadena empieza con Cad?" + cad.StartsWith("Cad"));

            // Verificar si cad es nula/vacía
            string nula = null;
            // IsNullOrEmpty or IsNullOrWhiteSpace
            Console.WriteLine("nula es null? " + string.IsNullOrEmpty(nula));
            Console.WriteLine("cad es null? " + string.IsNullOrWhiteSpace(cad));

            // Obtener posición de subcadena
            Console.WriteLine("Posición de cad 'de': " + cad.IndexOf("de"));*/
            #endregion

            #region StringBuilder
            /*StringBuilder sb = new StringBuilder("Cadena de Prueba");

            // Capacity: # de car que puede contener sin aumentar de tam
            Console.WriteLine("Cadena {0} \nLength: {1} \nCapacity: {2}",
                sb, sb.Length, sb.Capacity);

            sb.EnsureCapacity(30); // Fijar una capacidad de 30 cars
            Console.WriteLine("Nueva capacidad: {0}", sb.Capacity);

            // sb con concatenación: Append
            // object[]: permite arreglo de cualquier tipo de dato
            object[] datos = { "cadena", 0, 1.3, false, 'c', 8 };

            foreach(object dato in datos)
            {
                sb.Append(" " + dato);
            }
            Console.WriteLine(sb);

            // Insertar en pos det: Insert(pos, cad)
            sb.Insert(0, "Comienzo ");
            Console.WriteLine(sb);*/
            #endregion

            #region Formato Cadenas
            /*int naranjas = 8;
            int platanos = 2;
            int manzanas = 6;

            string res = string.Format("Hay {0} platanos, {1} naranjas, {2} manzanas",
                platanos, naranjas, manzanas);
            Console.WriteLine(res);

            // Especificar # de decimales
            Console.WriteLine("Pi = {0:0.00}", Math.PI);

            // Ajustar dato con 10 caracteres de espacio: [Para datos tabulados]
            Console.WriteLine(">{0, 10}<", 5);
            // Ajustar dato con 10 caracteres de espacio a la izq:
            Console.WriteLine(">{0, -10}<", 5);

            // Mostrar datos en != formatos:
            int num = 126;
            Console.WriteLine("Nro: {0:N}", num);
            Console.WriteLine("Científico: {0:E}", num);
            Console.WriteLine("Moneda: {0:C}", num);
            Console.WriteLine("Porcentaje: {0:P}", num);
            Console.WriteLine("Hexadecimal: {0:X}", num);*/
            #endregion

            #region Fechas
            /*Console.Write("Fecha y Hora Actual: ");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine();

            Console.WriteLine("Fecha Personalizada: ");
            // Fechas: Año, Mes, Día, Hora, Minuto, Segundo
            DateTime dt = new DateTime(2017, 2, 3, 20, 0, 5);
            // Acceso a atributos de DateTime
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Month);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.DayOfWeek);
            Console.WriteLine(dt.Hour);
            Console.WriteLine(dt.Minute);
            Console.WriteLine(dt.Second);

            // Agregar/Restar tiempo de una fecha:
            Console.WriteLine(dt);
            Console.WriteLine("Agregar días: " + dt.AddDays(10));
            Console.WriteLine("Restar Horas: " + dt.AddHours(-10));*/
            #endregion

            #region Nros Aleatorios
            /*// Generar nros pseudo aleatorios
            // Random(seed): genera nros aleatorios según una seed
            Random random = new Random(503);

            // Generar nros entre 2 lims: Next(lim inf, lim sup + 1)
            int mes = random.Next(1, 13);
            int dado = random.Next(1, 7);
            
            double prob = random.NextDouble();

            int[] array = new int[5];
            // Agregar nros del 0 al 100 a un arreglo
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 101);
                Console.WriteLine(array[i]);
            }*/
            #endregion
        }
    }
}