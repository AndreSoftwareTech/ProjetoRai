using EscolaProway.Context;
using EscolaProway.Models;

namespace EscolaProway.Repository;

public class ProfessorRepository : IProfessor
{
    private readonly AppDbContext _context;
    public ProfessorRepository(AppDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public IEnumerable<Professor> Professores => _context.Professores;
}
