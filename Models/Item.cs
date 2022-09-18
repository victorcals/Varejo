using System;
namespace Varejo.Models
{
    public class Item
    {

        public Item()
        {
            CriadoEm = DateTime.Now;
        }

        public string Produto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

    }

}