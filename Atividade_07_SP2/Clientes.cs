using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_07_SP2 {
    class Clientes {
        public string nome { get; set; }
        public string endereco { get; set; }
        public float valor { get; protected set; }
        public float valorImposto { get; protected set; }
        public float total { get; protected set; }

        public virtual void PagarImposto(float imposto) {
            this.valor = imposto;
            this.valorImposto = this.valor * 10 / 100;
            this.total = this.valor + this.valorImposto;
        }


    }
}
