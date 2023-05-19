using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_07_SP2 {
    class PessoaJuridica : Clientes {
        public string cnpj { get; set; }
        public string ie { get; set; }
        public override void PagarImposto(float imposto) {
            this.valor = imposto;
            this.valorImposto = this.valor * 20 / 100;
            this.total = this.valor + this.valorImposto;
        }
    }
}
