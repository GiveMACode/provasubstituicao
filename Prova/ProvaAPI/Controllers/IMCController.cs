using Microsoft.AspNetCore.Mvc;
using ProvaAPI.Data;
using ProvaAPI.Models;
using ProvaAPI;
using Microsoft.EntityFrameworkCore;


namespace ProvaAPI.Controllers;
[Route("api/imc")]
[ApiController]
public class IMCController : ControllerBase
{
    private readonly AppDataContext _context;
    public IMCController(AppDataContext context) => _context = context;

    //GET: api/aluno/listar
    [HttpGet]
    [Route("listar")]
    public IActionResult Listar()
    {
        try{
            List<Aluno> alunos = _context.Alunos.Include(x=>x.IMC).ToList();
            return Ok(alunos);
        }
        catch(Exception e){
            return BadRequest(e.Message);
        }    
    }

    [HttpPost]
    [Route("cadastrar")]
    public IActionResult Cadastrar([FromBody] Aluno aluno){
         try{
          _context.Alunos.Add(aluno);
          return Created("", aluno);  
         }
          catch(Exception e){
            return BadRequest(e.Message);

    }
    }
    }
