using Dulceria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Infraestructura.AccesoDatos.Repositorio
{
    public class VehivuloRepositorioImpl : RepositorioImpl<Vehiculo>, IVehiculoRepositorio // Implementación del repositorio de Vehiculo
    {
        public VehivuloRepositorioImpl(DulceFacilDBContext dBcontext) : base(dBcontext)
        {
        }
    }
    
    }

