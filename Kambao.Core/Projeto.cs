using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kambao.Core
{
    public class Projeto
    {
        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual Equipe equipe { get; set; }
    }
}
