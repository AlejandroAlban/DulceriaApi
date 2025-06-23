using Dulceria.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Dominio.Modelo.Abstracciones
{
    public interface IProductoRepositorio : IRepositorio<Producto>
    {
        // Declarar todos los métodos que se van a utilizar en el repositorio de producto
        // Si hay métodos específicos para Producto, se pueden agregar aquí
        // Por ejemplo, si necesitas un método para buscar productos por categoría o precio, lo puedes declarar aquí
    }
}
