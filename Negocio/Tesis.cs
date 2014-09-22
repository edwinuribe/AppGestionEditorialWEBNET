using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Tesis : Documentos
    {
        private int capitulos;
        private string patrocinante;

        public int Capitulos
        {
            get { return capitulos; }
            set { capitulos = value; }
        }

        public string Patrocinante
        {
            get { return patrocinante; }
            set { patrocinante = value; }
        }

        public Tesis()
            : base()
        {
            this.capitulos = 0;
            this.patrocinante = "Institucion Patrocinante";
        }

        public Tesis(string codigo,string nombre,int paginas,string[] autores,string fecha,string editorial,string edicion,string tema,string idioma,int capitulos, string patrocinante)
            :base(codigo,nombre,paginas,autores,fecha,editorial,edicion,tema,idioma)
        {
            this.capitulos = capitulos;
            this.patrocinante = patrocinante;
        }

        public override string ToString()
        {
            return base.ToString()
                +"Capitulos: "+this.capitulos
                +"\nPatrocinante: "+this.patrocinante;
        }

        public override bool Equals(object obj)
        {
            bool result = false;
            Tesis t = (Tesis)obj;

            if (base.Equals(t) && this.capitulos == t.capitulos && this.patrocinante == t.patrocinante)
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
