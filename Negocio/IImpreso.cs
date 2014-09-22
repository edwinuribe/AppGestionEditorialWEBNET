using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public interface IImpreso
    {
        string Permisos(bool lectura, bool escritura);
    }
}
