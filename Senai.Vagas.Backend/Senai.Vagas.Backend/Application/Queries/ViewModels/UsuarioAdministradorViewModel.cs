﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Vagas.Backend.Application.Queries.ViewModels
{
    public class UsuarioAdministradorViewModel
    {
        public long Id { get; set; }
        public string NIF { get; set; }
        public UsuarioViewModel Usuario { get; set; }
    }
}
