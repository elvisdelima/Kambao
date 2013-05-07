using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kambao.Core
{
    public class Quadro
    {
        public virtual List<Faixa> faixas { get; set; }
        public virtual List<Tarefa> tarefas { get; set; }
        
    }
}