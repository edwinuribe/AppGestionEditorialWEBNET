using System;


namespace Negocio
{
    public abstract class Documentos
    {
        #region "Atributos"
        private string codigo;
        private string nombre;
        private int paginas;
        private string[] autores;
        private string fecha;
        private string editorial;
        private string edicion;
        private string tema;
        private string idioma;
        #endregion

        #region "Propiedades"
        ///<summary>
        ///Obtiene o Estable el codigo del documento       
        ///</summary>
        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        ///<summary>
        ///Obtiene o Estable el nombre del documento       
        ///</summary>
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        ///<summary>
        ///Obtiene o Estable la cantidad de paginas documento       
        ///</summary>
        public int Paginas
        {
            get { return paginas; }
            set { paginas = value; }
        }

        public string this[int index] 
        {
            get { return autores[index]; }
            set { autores[index] = value; }
        }

        ///<summary>
        ///Obtiene o Estable la fecha de publicación del documento       
        ///</summary>
        ///
        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        ///<summary>
        ///Obtiene o Estable la editorial del documento       
        ///</summary>
        public string Editorial
        {
            get { return editorial; }
            set { editorial = value; }
        }
        ///<summary>
        ///Obtiene o Estable la edición del documento       
        ///</summary>
        public string Edicion
        {
            get { return edicion; }
            set { edicion = value; }
        }
        ///<summary>
        ///Obtiene o Estable el tema del documento       
        ///</summary>
        public string Tema
        {
            get { return tema; }
            set { tema = value; }
        }
        ///<summary>
        ///Obtiene o Estable el idioma del documento       
        ///</summary>
        public string Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }
        #endregion

        #region "Constructores"
        ///<summary>
        ///Contructor por defecto  de Documentos
        ///</summary>
        public Documentos() 
        {
          codigo = "0000-000";
          nombre = "Titulo del Documento" ;
          paginas =  0;
          autores = null;
          fecha = "dd/mm/aaaa";
          editorial = "Nombre Editorial" ;
          edicion = "Nuemero Edicion";
          tema = "Tema";
          idioma = "Español";
        }

        ///<summary>
        ///Contructor de inicialización Documentos
        ///</summary>
        ///<param name="codigo"> Codigo del documento</param>
        ///<param name="nombre"> Nombre del documento</param>
        ///<param name="paginas"> Paginas del documento</param>
        ///<param name="nombre"> Autores del documento</param> 
        ///<param name="fecha"> Nombre del documento</param>
        ///<param name="editorial"> Editorial del documento</param>
        ///<param name="edicion"> Edicion del documento</param>
        ///<param name="tema"> Tema del documento</param>
        ///<param name="idioma"> Idioma del documento</param>
        ///
        public Documentos(string codigo, string nombre, int paginas, string[] autores,string fecha, string editorial, string edicion,string tema, string idioma)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.paginas = paginas;
            this.autores = autores;
            this.fecha = fecha;
            this.editorial = editorial;
            this.edicion = edicion;
            this.tema = tema;
            this.idioma = idioma;
        }
        #endregion

        #region "Metodos Sobre Escritos"
        ///<summary>
        ///Retorna la describición de Dcoumento
        ///</summary>
        ///<return> Retorna la describición de Documento</return>
        public override string ToString()
        {
            return "Codigo : " + this.codigo + "\n" +
                    "Nombre: " + this.nombre + "\n" +
                    "Paginas: " + this.paginas + "\n" +
                    "Autores: " + imp(this.autores) + "\n" +
                    "Fecha: " + this.fecha + "\n" +
                    "Editorial: " + this.editorial + "\n" +
                    "Edición: " + this.edicion + "\n" +
                    "Tema: " + this.tema + "\n" +
                    "Idioma: " + this.idioma + "\n";

        }
        ///<summary>
        ///Retorna verdadero si los objetos comparados son iguales, falso para contario
        ///</summary>
        ///<return> Retorna verdadero o falso </return>
        public override bool Equals(object obj)
        {
            Documentos d = (Documentos)obj;
            bool result = false;

            if ((this.codigo == d.codigo) &&
                (this.nombre == d.nombre) &&
                (this.paginas == d.paginas) &&
                (this.autores == d.autores) &&
                (this.fecha == d.fecha) &&
                (this.editorial == d.editorial) &&
                (this.edicion == d.edicion) &&
                (this.tema == d.tema) &&
                (this.idioma == d.idioma))
                result = true;


            return result;
        }
        ///<summary>
        ///Retorna Codigo Has del objeto
        ///</summary>
        ///<return> Retorna hasCode del objeto</return>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion


        private string imp(string[] val)
        {
            string valor = "";

            foreach (string value in val)
                valor = valor + value.ToString() + ",";
                
            return valor;
        }
        public abstract string formatos();
    }
}
