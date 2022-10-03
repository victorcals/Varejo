using System.Collections.Generic;
using System.Linq;
using Atacadista.Models;
using Microsoft.AspNetCore.Mvc;
namespace Atacadista.Controllers
{
  [ApiController]
  [Route("api/item")]
  public class ItemController : ControllerBase
  {
    private DataContext _context;

    public ItemController(DataContext context) => _context = context;

    private static List<Itens> itens = new List<Itens>();



    [Route("Listar")]
    [HttpGet]
    public IActionResult Listar() =>
        Ok(_context.Itens.ToList());



    [Route("cadastrar")]
    [HttpPost]
    public IActionResult Cadastrar([FromBody] Itens item)
    {

      _context.Itens.Add(item);
      _context.SaveChanges();
      return Created("", item);

    }

    [Route("buscar/{codigo}")]
    [HttpGet]
    public IActionResult Buscar([FromRoute] string Codigo)
    {
      Itens item =
          _context.Itens.FirstOrDefault
      (
          f => f.Codigo.Equals(Codigo)
      );

      return item != null ? Ok(item) : NotFound();
    }


    [Route("deletar/{id}")]
    [HttpDelete]
    public IActionResult Deletar([FromRoute] int id)
    {
      Itens Item =
          _context.Itens.Find(id);
      if (Item != null)
      {
        _context.Itens.Remove(Item);
        _context.SaveChanges();
        return Ok(Item);
      }
      return NotFound();
    }


    [Route("alterar")]
    [HttpPatch]
    public IActionResult Alterar([FromBody] Itens item)
    {
      {
        _context.Itens.Update(item);
        _context.SaveChanges();
        return Ok(item);
      }
    }

    /* Baixar SQLlite
    versão utilizada no programa  --version 5.0.4
    https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.Sqlite/5.0.4
    comanda para colcoar no terminak ↓↓
    dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 5.0.4

    site do sqlite 
    https://sqlitebrowser.org/ teste

    */


  }

  public class EstoqueController : ControllerBase
  {

    private DataContext _context;

    public EstoqueController(DataContext context) => _context = context;

    private static List<Estoques> estoques = new List<Estoques>();



    [Route("Listar")]
    [HttpGet]
    public IActionResult ListarEstoque() =>
        Ok(_context.Estoques.ToList());



    [Route("cadastrar")]
    [HttpPost]
    public IActionResult CadastrarEstoque([FromBody] Estoques item)
    {

      _context.Estoques.Add(item);
      _context.SaveChanges();
      return Created("", item);

    }

    [Route("buscar/{codigo}")]
    [HttpGet]
    public IActionResult BuscarEstoque([FromRoute] string Codigo)
    {
      Estoques item =
          _context.Estoques.FirstOrDefault
      (
          f => f.Codigo.Equals(Codigo)
      );

      return item != null ? Ok(item) : NotFound();
    }


    [Route("deletar/{id}")]
    [HttpDelete]
    public IActionResult DeletarEstoque([FromRoute] int id)
    {
      Estoques Estoque =
          _context.Estoques.Find(id);
      if (Estoque != null)
      {
        _context.Estoques.Remove(Estoque);
        _context.SaveChanges();
        return Ok(Estoque);
      }
      return NotFound();
    }


    [Route("alterar")]
    [HttpPatch]
    public IActionResult AlterarEstoque([FromBody] Estoques item)
    {
      {
        _context.Estoques.Update(item);
        _context.SaveChanges();
        return Ok(item);
      }
    }
  }
}