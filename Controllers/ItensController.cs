using Varejo.Models;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
//colocar onde está na pasta
namespace Varejo.Controller
{//teste
    [ApiController]
    [Route("api/user")]
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
        [Route("buscar/produto")]
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


        // [Route("deletar/prodruto")]
        // [HttpDelete]
        // public IActionResult Deletar([FromRoute] string item)
        // {
        //     Item item = item.FirstOrDefault
        //     (
        //         it => it.Produto.Equals(produto)
        //     );
        //     if (item != null)
        //     {
        //         item.Remove(item);
        //         return Ok(item);
        //     }
        //     return NotFound();
        // }


        // [Route("alterar")]
        // [HttpPatch]
        // public IActionResult Alterar([FromBody] Item item)
        // {
        //     Item itemProcurado = item.FirstOrDefault
        //     (
        //         it => it.Produto.Equals(item.Produto)
        //     );
        //     if (itemProcurado != null)
        //     {
        //         itemProcurado.Produto = item.Produto;
        //         return Ok(item);
        //     }
        //     return NotFound();
        // }

        /* Baixar SQLlite
        versão utilizada no programa  --version 5.0.4
        https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/5.0.4
        comanda para colcoar no terminak ↓↓
        dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.4

        site do sqlite 
        https://sqlitebrowser.org/

        */


    }

}