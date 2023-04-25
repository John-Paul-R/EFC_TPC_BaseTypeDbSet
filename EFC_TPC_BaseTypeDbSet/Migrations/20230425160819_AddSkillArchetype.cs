using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFC_TPC_CollectionNavigationInsertsOrder.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillArchetype : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ArchetypeId",
                table: "MartialSkill",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "ArchetypeId",
                table: "MagicSkill",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "SkillArchetype",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillArchetype", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MartialSkill_ArchetypeId",
                table: "MartialSkill",
                column: "ArchetypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicSkill_ArchetypeId",
                table: "MagicSkill",
                column: "ArchetypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_MagicSkill_SkillArchetype_ArchetypeId",
                table: "MagicSkill",
                column: "ArchetypeId",
                principalTable: "SkillArchetype",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MartialSkill_SkillArchetype_ArchetypeId",
                table: "MartialSkill",
                column: "ArchetypeId",
                principalTable: "SkillArchetype",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MagicSkill_SkillArchetype_ArchetypeId",
                table: "MagicSkill");

            migrationBuilder.DropForeignKey(
                name: "FK_MartialSkill_SkillArchetype_ArchetypeId",
                table: "MartialSkill");

            migrationBuilder.DropTable(
                name: "SkillArchetype");

            migrationBuilder.DropIndex(
                name: "IX_MartialSkill_ArchetypeId",
                table: "MartialSkill");

            migrationBuilder.DropIndex(
                name: "IX_MagicSkill_ArchetypeId",
                table: "MagicSkill");

            migrationBuilder.DropColumn(
                name: "ArchetypeId",
                table: "MartialSkill");

            migrationBuilder.DropColumn(
                name: "ArchetypeId",
                table: "MagicSkill");
        }
    }
}
