using System;
using System.ComponentModel.DataAnnotations;
using Atacadista.Validacao;

namespace Atacadista.Models
{
  public class Estoques
  {
    public Estoques() => CriadoEm = DateTime.Now;
    public int EstoquesId { get; set; }
    public string Codigo { get; set; }
    public string Produto { get; set; }
    public int EstoqueAtual { get; set; }
    public DateTime CriadoEm { get; set; }
  }
}
//teste