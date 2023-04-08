namespace Proyecto13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UpCasting: tratar a instancias de una clase como si fuese del tipo de la interfaz
            IFiguraGeométrica f1 = new Circulo { Radio = 5 };
            IFiguraGeométrica f2 = new TrianguloRect { Base = 10, Altura = 8};
            IFiguraGeométrica f3 = new Rectangulo { Base = 4, Altura = 3 };
            IFiguraGeométrica f4 = new Circulo { Radio = 9 };

            IFiguraGeométrica[] figuras = { f1, f2, f3, f4 };

            foreach(var figura in figuras)
            {
                // Al haber hecho UpCasting no importa el tipo de figura, todas saben como
                // calcular su área
                Console.WriteLine(figura.CalcularArea());

                // De la misma forma, por haber hecho UpCasting, no podemos aplicar DatosFigura()
            }

            // DownCasting: tomar un objeto del tipo de la interfaz y devolverlo a su tipo original
            Circulo c = f1 as Circulo;
            Console.WriteLine("Datos Figura f1:");
            c.DatosFigura();
            
            // Interfaces permiten polimorfismo: un objeto de tipo Circulo, podría comportarse como
            // figura o como otra interfaz (ej. rueda)

            // Para cambiar de tipo se utiliza UpCasting y DownCasting
        }
    }
}