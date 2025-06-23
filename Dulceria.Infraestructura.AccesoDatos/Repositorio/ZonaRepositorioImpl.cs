using Dulceria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Infraestructura.AccesoDatos.Repositorio
{
    public class ZonaRepositorioImpl: RepositorioImpl<Zona>, IzonaRepositorio // Implementación del repositorio de Zona
    {
        public ZonaRepositorioImpl(DulceFacilDBContext dBcontext) : base(dBcontext)
        {
        }
    }
    {
    }
}
