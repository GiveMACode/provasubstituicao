using Microsoft.AspNetCore.Mvc;
using ProvaAPI.Data;
using ProvaAPI.Models;
using ProvaAPI;


namespace ProvaAPI.Controllers;
[Route("api/aluno")]
[ApiController]
public class AlunoController : ControllerBase
{
    private readonly AppDataContext _context;
    public AlunoController(AppDataContext context) => _context = context;

    //GET: api/aluno/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try{
            List<Aluno> alunos = _context.Alunos.ToList();
            return Ok(alunos);
        }
        catch(Exception e){
            return BadRequest(e.Message);
        }

        
    }
}
