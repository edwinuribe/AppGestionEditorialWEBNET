using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
using Negocio;

namespace Web
{
    public partial class LINQObject : System.Web.UI.Page
    {

        protected void btnEjecutar_Click(object sender, EventArgs e)
        {
            tbResultado.Text = Ejemplo2();
        }


        private string Ejemplo1()
        {
            DocumentosRepositories dr = new DocumentosRepositories();

            string str = "";
            var soldOutDocuemntos =
            from p in dr.getLibros()
            where p.Capitulos > 10
            select p;


            str = "Libros";

            foreach (var x in soldOutDocuemntos)
            {
                str += x + "\n";
            }

            return str;
        }

        private string Ejemplo2()
        {
            DocumentosRepositories dr = new DocumentosRepositories();

            string str = "";
            var soldOutDocuemntos =
            from p in dr.getLibros()
            select new { p.Codigo, p.Nombre, p.Tema };


            str = "Libros";

            foreach (var x in soldOutDocuemntos)
            {
                str += x + "\n";
            }

            return str;
        }
    }
}