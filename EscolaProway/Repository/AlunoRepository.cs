using EscolaProway.Context;
using EscolaProway.Models;

namespace EscolaProway.Repository
{
    public class AlunoRepository: IAluno
    {
        private readonly AppDbContext _context;
        public AlunoRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IEnumerable<Aluno> Alunos => _context.Alunos;
    }
}
