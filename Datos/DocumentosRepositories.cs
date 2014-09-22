using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Datos
{
    public class DocumentosRepositories
    {

        public IEnumerable<Documentos> getDocumentos()
        {
            List<Documentos> list = new List<Documentos>();

            Libros l = new Libros();
            Libros l2 = new Libros();
            Revistas r = new Revistas();
            Revistas r1 = new Revistas();
            Articulos art = new Articulos();
            Tesis t = new Tesis();

            list.Add(l);
            list.Add(l2);
            list.Add(r);
            list.Add(r1);
            list.Add(art);
            list.Add(t);

            return list;

        }

        public IEnumerable<Libros> getLibros()
        {
            List<Libros> list = new List<Libros>();
            string [] au ={"autor1", "autor2"};

            Libros l1 = new Libros("12345","XML al Descubierto", 356,au , "01/04/2001","MG Hill","Segunda Edicion", "XML","Español", 12,"Avanzado",1);
            Libros l2 = new Libros("12346", "Java", 234, au, "01/04/2010", "MG Hill", "Segunda Edicion", "Java", "Español", 8, "Avanzado", 1);
            Libros l3 = new Libros("12347", "Java Principiante", 130, au, "01/04/2012", "Printice Hall", "Quinta Edicion", "Java", "Español", 10, "Avanzado", 1);
            Libros l4 = new Libros("12346", "C# referencia", 433, au, "01/04/2013", "MG Hill", "Octava Edicion", "C#", "Español", 8, "Avanzado", 1);


            list.Add(l1);
            list.Add(l2);
            list.Add(l3);
            list.Add(l4);

            return list;

        }
    }
}
