﻿using Dulceria.Infraestructura.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dulceria.Dominio.Modelo.Abstracciones
{
    public interface IUsuarioRepositorio : IRepositorio<Usuario> // Interfaz para el repositorio de Usuario
    {
    }
}
