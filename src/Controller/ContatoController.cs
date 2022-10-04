using ContatoAPI.Context;
using ContatoAPI.src.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContatoAPI.src.Controller;

[ApiController]
[Route("[controller]")]
public class ContatoController : ControllerBase
{
    private readonly AgendaContext _context;

    public ContatoController(AgendaContext context)
    {
        _context = context;
    }

    [HttpPost("Cadastrar")]
    public IActionResult Cadastrar(Contato contato)
    {
        _context.Add(contato);
        _context.SaveChanges();

        return CreatedAtAction(nameof(ObterPorId), new { id = contato.ContatoId }, contato);
    }

    [HttpGet("ObterPorId/{id}")]
    public IActionResult ObterPorId(int id)
    {
        var contato = _context.Contatos.Find(id);

        if (contato == null)
        {
            return NotFound();
        }

        return Ok(contato);
    }

    [HttpGet("ObterPorNome")]
    public IActionResult ObterPorNome(string nome)
    {
        var contato = _context.Contatos.Where(c => c.Nome.Contains(nome));

        return Ok(contato);
    }

    [HttpPut("Atualizar/{id}")]
    public IActionResult Atualizar(int id, Contato contato)
    {
        var agendaContatos = _context.Contatos.Find(id);

        if (agendaContatos == null)
        {
            return NotFound();
        }

        agendaContatos.Nome = contato.Nome;
        agendaContatos.Telefone = contato.Telefone;
        agendaContatos.Ativo = contato.Ativo;

        _context.Contatos.Update(agendaContatos);
        _context.SaveChanges();

        return Ok(agendaContatos);
    }

    [HttpDelete("Deletar/{id}")]
    public IActionResult Deletar(int id)
    {
        var agendaContatos = _context.Contatos.Find(id);

        if (agendaContatos == null)
        {
            return NotFound();
        }

        _context.Contatos.Remove(agendaContatos);
        _context.SaveChanges();

        return NoContent();
    }
}