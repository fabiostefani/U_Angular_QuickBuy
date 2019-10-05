using fabiostefani.io.QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fabiostefani.io.QuickBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }

        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
        public virtual Usuario Usuario { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
            {
                AdicionarCritica("Pedido não pode ficar sem item de pedido");
            }

            if (string.IsNullOrEmpty(Cep))
            {
                AdicionarCritica("CEP não foi informado.");
            }

            if (FormaPagamentoId == 0)
            {
                AdicionarCritica("Não foi informado a Forma de Pagamento");
            }
        }
    }
}
