using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public interface IDigital
    {      
        bool Guardar(string ruta);

        bool Imprimir();

        string Permisos(bool lectura,bool escritura);

        string[] formato { get; }
    }
}
