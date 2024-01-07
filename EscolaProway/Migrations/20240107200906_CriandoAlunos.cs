using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaProway.Migrations
{
    /// <inheritdoc />
    public partial class CriandoAlunos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    insert into Alunos(NomeAluno, NomeMateria, IdProfessor)
                                    values('Leo', 'Csharp', 1),
                                    ('Rai', 'Java', 2),
                                    ('Yves Joni Sutter ', 'Python', 3)
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
