﻿using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
   public interface IUsuarioRepository
    {
        public Usuario GetUsuario(string usuario);
    }
}
