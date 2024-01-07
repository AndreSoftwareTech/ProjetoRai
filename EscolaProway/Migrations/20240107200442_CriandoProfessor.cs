using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EscolaProway.Migrations
{
    /// <inheritdoc />
    public partial class CriandoProfessor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                                    insert into Professores(NomeProfessor, Especialidade)
                                    values('Andre', 'Csharp'),
                                    ('Andre Vitor', 'Java'),
                                    ('Vitor', 'Python')
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
