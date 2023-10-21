using System;
using System.Collections.Generic;

namespace Desafio.NET.Business.Models
{
    public class Pagador
    {
        public Guid Id { get; set; }
        public Chave Chave { get; set; }
        public string Nome { get; set; }

        public ICollection<Transacao> Transacoes { get; set; }
    }
}
