﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Vagas.Backend.Application.Queries.ViewModels
{
    public class MunicipioViewModel
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public UfSiglaViewModel UfSigla { get; set; }
    }
}
