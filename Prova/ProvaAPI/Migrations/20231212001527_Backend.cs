using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProvaAPI.Migrations
{
    public partial class Backend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IMCs",
                columns: table => new
                {
                    IMCId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ValorImc = table.Column<float>(type: "REAL", nullable: false),
                    Classificacao = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IMCs", x => x.IMCId);
                });

            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    AlunoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: true),
                    DataDeNascimento = table.Column<string>(type: "TEXT", nullable: true),
                    IMCId = table.Column<int>(type: "INTEGER", nullable: false),
                    Classificacao = table.Column<int>(type: "INTEGER", nullable: false),
                    Peso = table.Column<float>(type: "REAL", nullable: false),
                    Altura = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.AlunoId);
                    table.ForeignKey(
                        name: "FK_Alunos_IMCs_IMCId",
                        column: x => x.IMCId,
                        principalTable: "IMCs",
                        principalColumn: "IMCId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "IMCs",
                columns: new[] { "IMCId", "Classificacao", "ValorImc" },
                values: new object[] { 1, "Magreza", 0f });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "AlunoId", "Altura", "Classificacao", "DataDeNascimento", "IMCId", "Nome", "Peso" },
                values: new object[] { 1, 115f, 0, "10 de Setembro de 2000", 1, "xuxu beleza", 0f });

            migrationBuilder.CreateIndex(
                name: "IX_Alunos_IMCId",
                table: "Alunos",
                column: "IMCId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");

            migrationBuilder.DropTable(
                name: "IMCs");
        }
    }
}
