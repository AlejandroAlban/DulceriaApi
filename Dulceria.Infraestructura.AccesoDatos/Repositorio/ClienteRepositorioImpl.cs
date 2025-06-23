using Dulceria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Infraestructura.AccesoDatos.Repositorio
{
    public class ClienteRepositorioImpl: RepositorioImpl<Cliente>, IClienteRepositorio
    {
        public ClienteRepositorioImpl(DulceFacilDBContext dBcontext) : base(dBcontext)
        {
        }
        // Implementar los metodos especificos del repositorio de tipo cliente si es necesario
        // Por ejemplo, si hay metodos adicionales que solo se aplican a TipoCliente, se pueden agregar aqui
       
        }
    
}
