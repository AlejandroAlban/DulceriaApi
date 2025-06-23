using Dulceria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Infraestructura.AccesoDatos.Repositorio
{
    public class ProductoRepositorioImpl: RepositorioImpl<Producto>, IProductoRepositorio
    {
        public ProductoRepositorioImpl(DulceFacilDBContext dBcontext) : base(dBcontext)
        {
        }
        // Implementar los metodos especificos del repositorio de tipo producto si es necesario
        // Por ejemplo, si hay metodos adicionales que solo se aplican a Producto, se pueden agregar aqui
    
    }
}
