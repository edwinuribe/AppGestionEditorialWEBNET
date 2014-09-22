using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Revistas : Documentos
    {
        private string tipoRevista;
        private int volumen;

        public string TipoRevista
        {
            get { return tipoRevista; }
            set { tipoRevista = value; }
        }

        public int Volumen
        {
            get { return volumen; }
            set { volumen = value; }
        }

        public Revistas()
            : base()
        {
            this.tipoRevista = "...Deportiva/Cientifica/Politica..";
            this.volumen = 0;
        }

        public Revistas(string codigo, string nombre, int paginas, string[] autores, string fecha, string editorial, string edicion, string tema, string idioma,string tipoRevista, int volumen)
            : base(codigo, nombre, paginas, autores, fecha, editorial, edicion, tema, idioma)
        {
            this.tipoRevista = tipoRevista;
            this.volumen = volumen;
        }

        public override string ToString()
        {
            return base.ToString()
                + "Tipo de Revista: " + this.tipoRevista
                +"\nVolumen: " + this.volumen;
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            Revistas r = (Revistas)obj;

            if (base.Equals(r) && this.tipoRevista == r.tipoRevista && this.volumen == r.volumen)
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string formatos()
        {
            return "";
        }
    }
}
