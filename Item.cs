using System;
namespace Varejo.Models
{
    public class Item
    {

        public Item()
        {
            CriadoEm = DateTime.Now;
        }

        // private int Id { get; set; }
        public string Produto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }

        internal void Remove(Item item)
        {
            throw new NotImplementedException();
        }
    }

}