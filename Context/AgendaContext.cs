using ContatoAPI.src.Models;
using Microsoft.EntityFrameworkCore;

namespace ContatoAPI.Context;

public class AgendaContext : DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
    {
    }

    public DbSet<Contato> Contatos { get; set; }
}