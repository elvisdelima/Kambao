using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kambao.Core
{
    public class Faixa
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual int Ordem { get; set; }
        public virtual Projeto projeto { get; set; }
    }
}