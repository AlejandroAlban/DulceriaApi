using Dulceria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Infraestructura.AccesoDatos.Repositorio
{
    public class EntregaRepositorioImpl : RepositorioImpl<Entrega>, IEntregaRepositorio
    {
        public EntregaRepositorioImpl(DulceFacilDBContext dBcontext) : base(dBcontext)
        {
        }
        // Implementar los metodos especificos del repositorio de tipo Entrega si es necesario
        // Por ejemplo, si hay metodos adicionales que solo se aplican a Entrega, se pueden agregar aqui
    }
    
 }

