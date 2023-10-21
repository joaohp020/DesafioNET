using System;
using System.Collections.Generic;
using System.Text;
using static Desafio.NET.Business.Models.Enums;

namespace Desafio.NET.Business.Models
{
    public class Chave
    {
        public Guid Id { get; set; }
        public ETipoChave TipoChave { get; set; }
        public string Descricao { get; set; }
    }
}
