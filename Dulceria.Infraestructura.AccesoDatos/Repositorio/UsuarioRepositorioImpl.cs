using Dulceria.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Infraestructura.AccesoDatos.Repositorio
{
    public class UsuarioRepositorioImpl : RepositorioImpl<Usuario>, IUsuarioRepositorio // Implementación del repositorio de Usuario
    {
        public UsuarioRepositorioImpl(DulceFacilDBContext dBcontext) : base(dBcontext)
        {
        }
    }
 }

