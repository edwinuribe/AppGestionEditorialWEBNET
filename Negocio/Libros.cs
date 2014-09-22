using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Libros : Documentos, IDigital
    {
        /// <summary>
        /// # capitulos del libro
        /// </summary>
        private int capitulos;
        private string nivel;
        private int tipo;

        public Libros():base()
        {
            this.capitulos = 0;
            this.nivel = "basico";
            this.tipo = 0;
        }

        public Libros(string codigo, string nombre, int paginas, string[] autores, string fecha, string editorial, string edicion, string tema, string idioma, int capitulos, string nivel, int tipo)
            : base(codigo,nombre,paginas,autores,fecha,editorial,edicion,tema,idioma)
        {
            this.capitulos = capitulos;
            this.nivel =  nivel;
            this.tipo = tipo;
        }

        /// <remarks>Devuelve o Establece el nivel del Libro</remarks>
        public string Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        /// <remarks>Obtiene o Establece los capitulos del libro</remarks>
        public int Capitulos
        {
            get { return capitulos; }
            set { capitulos = value; }
        }

        
    
        public override string formatos()
        {
            string sl="[";
            foreach (String val in formato)
                sl = sl + val + ",";
            return sl+"]";
        }



        /// <returns>Retorna la descripción del objeto</returns>
        public override string ToString()
        {
            return base.ToString() + "\n" +
                   "Capitulos: " + this.capitulos + "\n" +
                   "Nivel: " + this.nivel;
        }

        public override bool Equals(object obj)
        {
            Libros l = (Libros)obj;
            bool result = false;

            if (base.Equals(l)&& (this.capitulos == l.capitulos) && (this.nivel == l.nivel))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region Implementacion de la Interfaz

        /// <remarks>Devuelve los tipos de formatos del documento</remarks>
        public string[] formato
        {
            get
            {
                return new string[]{
                    Out.CHM.ToString(),
                    Out.PDF.ToString(),
                    Out.Online.ToString()
                };
            }
        }

        public bool Guardar(string ruta)
        {
            throw new NotImplementedException();
        }

        public bool Imprimir()
        {
            throw new NotImplementedException();
        }

        /// <remarks>Establece los permisos del Libro</remarks>
        public string Permisos(bool lectura, bool escritura)
        {
            throw new NotImplementedException();
        }

        #endregion


    }
}
