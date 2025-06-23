using Dulceria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Infraestructura.AccesoDatos.Repositorio
{
    public class RutaRepositorioImpl : RepositorioImpl<Ruta>, IRutaRepositorio // Implementación del repositorio de Ruta
    {
        public RutaRepositorioImpl(DulceFacilDBContext dBcontext) : base(dBcontext)
        {
        }
    }
}
