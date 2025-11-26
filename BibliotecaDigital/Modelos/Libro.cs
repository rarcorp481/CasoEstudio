using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDigital.Modelos
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AnioPublicacion { get; set; }
        public string Descripcion { get; set; }

        public Libro(string titulo, string autor, int anio, string descripcion)
        {
            Titulo = titulo;
            Autor = autor;
            AnioPublicacion = anio;
            Descripcion = descripcion;
        }
    }
}
