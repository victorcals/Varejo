using System.Collections.Generic;
using System.Linq;
using Atacadista.Models;
using Microsoft.AspNetCore.Mvc;

namespace Atacadista.Controllers{
    [ApiController]
  [Route("api/estoque")]
  public class EstoqueController : ControllerBase{
    private readonly DataContext _context;
        
    public EstoqueController(DataContext context) =>
            _context = context;
  }
}