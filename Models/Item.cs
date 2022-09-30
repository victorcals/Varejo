using System;
using System.ComponentModel.DataAnnotations;
using Atacadista.Validacao;


namespace Atacadista.Models
{
    public class Itens
    {

       public Itens() => CriadoEm = DateTime.Now;
        public int ItensId {get; set; }
        public string Produto { get; set; }

        [CodEmUso]
        public string Codigo {get; set; }
        public string Marca {get; set; }
        public string Modelo {get; set; }
        public int Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

    }

}