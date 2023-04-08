namespace Proyecto14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto p1 = new Producto { Codigo = "A1", Precio = 123};
            Producto p2 = new Producto { Codigo = "A1", Precio = 150.5m };
            Producto p3 = new Producto { Codigo = "A1", Precio = 120.2m };

            Producto[] productos = new Producto[] { p1, p2, p3 };

            // El método Sort utiliza la implementación de la interfaz IComparable
            // Si no existiera, lanzaría errores de compilación
            Array.Sort(productos);

            foreach(Producto producto in productos)
            {
                Console.WriteLine("Código: {0} | Precio: {1}", producto.Codigo, producto.Precio);
            }
        }
    }
}