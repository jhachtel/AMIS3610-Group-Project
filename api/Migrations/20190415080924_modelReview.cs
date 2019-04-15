using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace AMIS3610.GroupProject.Api.Migrations
{
    public partial class modelReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trail_Place_placeId",
                table: "Trail");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Gear_GearId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_People_PeopleId",
                table: "Trip");

            migrationBuilder.DropForeignKey(
                name: "FK_Trip_Place_PlaceId",
                table: "Trip");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropIndex(
                name: "IX_Trip_GearId",
                table: "Trip");

            migrationBuilder.DropIndex(
                name: "IX_Trip_PeopleId",
                table: "Trip");

            migrationBuilder.DropIndex(
                name: "IX_Trip_PlaceId",
                table: "Trip");

            migrationBuilder.DropIndex(
                name: "IX_Trail_placeId",
                table: "Trail");

            migrationBuilder.DropColumn(
                name: "GearId",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "PeopleId",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Trip");

            migrationBuilder.DropColumn(
                name: "placeId",
                table: "Trail");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Trail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Place",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Gear",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Trail");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Place");

            migrationBuilder.DropColumn(
                name: "Link",
                table: "Gear");

            migrationBuilder.AddColumn<int>(
                name: "GearId",
                table: "Trip",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PeopleId",
                table: "Trip",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Trip",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "placeId",
                table: "Trail",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Bio = table.Column<string>(nullable: true),
                    Contactinfo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Trip_GearId",
                table: "Trip",
                column: "GearId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_PeopleId",
                table: "Trip",
                column: "PeopleId");

            migrationBuilder.CreateIndex(
                name: "IX_Trip_PlaceId",
                table: "Trip",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Trail_placeId",
                table: "Trail",
                column: "placeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trail_Place_placeId",
                table: "Trail",
                column: "placeId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Gear_GearId",
                table: "Trip",
                column: "GearId",
                principalTable: "Gear",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_People_PeopleId",
                table: "Trip",
                column: "PeopleId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trip_Place_PlaceId",
                table: "Trip",
                column: "PlaceId",
                principalTable: "Place",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
