using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Negocio;

namespace Consola
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /*
            * DocumentosRepositories dr = new DocumentosRepositories();

            foreach (Documentos value in dr.getDocumentos())
                System.Console.WriteLine(value);

         
            */

            DocumentosRepositories ll = new DocumentosRepositories();

            foreach (Libros value in ll.getLibros())
                System.Console.WriteLine(value);

            System.Console.ReadKey();

        }

    }
}
