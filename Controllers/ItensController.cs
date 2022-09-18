using Atacadista.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
//colocar onde está na pasta
namespace Atacadista.Controller
{
    [ApiController]
    [Route("api/item")]
    public class UserControler : ControllerBase
    {

        private static List<Item> itens = new List<Item>();

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {

            return Ok(itens);

        }


        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar([FromBody] Item item)
        {

            itens.Add(item);
            return Created("", item);

        }

        [HttpGet]
        [Route("buscar/{nome}")]
        public IActionResult Buscar([FromRoute] string produto)
        {
            for (int i = 0; i < itens.Count; i++)
            {
                if (itens[i].Produto.Equals(produto))
                {
                    return Ok(itens[i]);
                }
            }
            return NotFound();
        }


        /*

                [HttpPut]
                [Route("buscar/Alterar")]
                public IActionResult Alterar([FromRoute] string produto)
                {
                    verificar no git do prof metodo.
                }


                [HttpPost]
                [Route("buscar/deletar")]
                public IActionResult Deletar([FromBody] Item item)
                {
                verificar no git do prof metodo utilizado
                    item -= item;
                    return Delet("", item);

                }


              falta criar criar um relacionamento de dados → 
              Exemplo: TV = eletronico 
                       Batom = beleza */


    }

}