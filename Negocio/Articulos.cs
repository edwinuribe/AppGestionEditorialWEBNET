using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Articulos : Documentos
    {
        private string tipoArticulo;

        public Articulos():base()
        {
            this.tipoArticulo = "...Cientifico/Investigativo...";
        }

        public Articulos(string codigo,string nombre, int paginas,string[] autores, string fecha, string editorial,string edicion, string tema,string idioma,string tipoArticulo)
            : base(codigo, nombre, paginas, autores, fecha, editorial, edicion, tema, idioma)
        {
            this.tipoArticulo = tipoArticulo;
        }
        public string TipoArticulo
        {
            get { return tipoArticulo; }
            set { tipoArticulo = value; }
        }
        public override string formatos()
        {
            return "";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            Articulos a = (Articulos)obj;

            if (base.Equals(a) && this.tipoArticulo == a.tipoArticulo)
                result = true;

            return result;
        }

        public override string ToString()
        {
            return base.ToString()
                + "Tipo de Revista: " + this.tipoArticulo;
        }
    }
}
