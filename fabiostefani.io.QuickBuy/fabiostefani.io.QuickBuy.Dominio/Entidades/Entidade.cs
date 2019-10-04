using System.Collections.Generic;
using System.Linq;

namespace fabiostefani.io.QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        //public int Id { get; set; }
        public List<string> _mensagensValidacao { get; set; }
        private List<string> MensagensValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        public abstract void Validate();
        protected bool EhValido { get { return !MensagensValidacao.Any(); } }

        protected void LimparMensagensValidacao()
        {
            MensagensValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            MensagensValidacao.Add(mensagem);
        }
    }
}
