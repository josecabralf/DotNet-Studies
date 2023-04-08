using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    internal class Agenda
    {
        #region Propiedades
        private const int TAM = 20;
        private Contacto[] _contactos;

        // Para añadir nuevo elemento o eliminar
        private int _index;

        public int NroContactos { get { return _index; } }
        #endregion

        public Agenda()
        {
            _index = 0;
            _contactos = new Contacto[TAM];
        }

        public void AgregarContacto(Contacto c)
        {
            if(_index < TAM)
            {
                _contactos[_index] = c;
                _index++;
            }
            else { Console.WriteLine("Agenda llena!"); }
        }

        public void BorrarUltContacto()
        {
            if (0 < _index)
            {
                _contactos[_index] = null;
                _index--;
            }
            else { Console.WriteLine("Agenda Vacía!"); }
        }

        private bool NoHayContactos()
        {
            if (_index == 0) { return true; }
            else { return false;}
        }

        public void MostrarAsc()
        {
            if (NoHayContactos()) { return; }

            Contacto[] ordenados = new Contacto[_index];
            Array.Copy(_contactos, ordenados, _index);
            Array.Sort(ordenados);

            Console.WriteLine(CadContactos(_contactos));
        }

        public void MostrarDesc()
        {
            Contacto[] ordenados = new Contacto[_index];
            Array.Copy(_contactos, ordenados, _index);
            Array.Sort(ordenados);
            Array.Reverse(ordenados);

            Console.WriteLine(CadContactos(_contactos));
        }

        public Contacto BuscarPorNom(string nom)
        {
            foreach(Contacto c in _contactos)
            {
                if(c != null && c.Nombre == nom) { return c; }
            }
            return null;
        }

        public override string ToString()
        {
            return CadContactos(_contactos);
        }
        public void MostrarContactos() { Console.WriteLine(this); }
        private string CadContactos(Contacto[] contactos)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _index; i++)
            {
                if (_contactos[i] == null) { continue; }

                string dato = string.Format("{0}.\n{1}\n", i + 1, contactos[i]);
                sb.Append(dato);
            }

            return sb.ToString();
        }
    }
}
