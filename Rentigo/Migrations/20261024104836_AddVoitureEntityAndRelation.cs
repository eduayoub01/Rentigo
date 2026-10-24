using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rentigo.Migrations
{
    /// <inheritdoc />
    public partial class AddVoitureEntityAndRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voitures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marque = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Modele = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Matricule = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Annee = table.Column<int>(type: "int", nullable: false),
                    PrixJour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EstDisponible = table.Column<bool>(type: "bit", nullable: false),
                    CategoryVoitureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voitures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Voitures_CategoriesVoitures_CategoryVoitureId",
                        column: x => x.CategoryVoitureId,
                        principalTable: "CategoriesVoitures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Voitures_CategoryVoitureId",
                table: "Voitures",
                column: "CategoryVoitureId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voitures");
        }
    }
}
