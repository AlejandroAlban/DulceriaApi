using Dulceria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Infraestructura.AccesoDatos.Repositorio
{
    public class PedidoRepositorioImpl : RepositorioImpl<Pedido>, IPedidorepositorio
        {
        public PedidoRepositorioImpl(DulceFacilDBContext dBcontext) : base(dBcontext)
        {
        }
        // Implementar los metodos especificos del repositorio de tipo Pedido si es necesario
        // Por ejemplo, si hay metodos adicionales que solo se aplican a Pedido, se pueden agregar aqui
    }
    
 }

