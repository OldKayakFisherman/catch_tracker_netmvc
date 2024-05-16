using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CatchTrackerNetMVC.Web.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "catch_details",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    latitude = table.Column<double>(type: "REAL", nullable: false),
                    longitude = table.Column<double>(type: "REAL", nullable: false),
                    catch_date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    species = table.Column<string>(type: "TEXT", nullable: false),
                    weight = table.Column<double>(type: "REAL", nullable: false),
                    water_temperature = table.Column<double>(type: "REAL", nullable: false),
                    water_depth = table.Column<double>(type: "REAL", nullable: false),
                    sky_conditions = table.Column<string>(type: "TEXT", nullable: true),
                    air_temperature = table.Column<double>(type: "REAL", nullable: false),
                    terminal_tackle = table.Column<string>(type: "TEXT", nullable: true),
                    technique = table.Column<string>(type: "TEXT", nullable: true),
                    bait = table.Column<string>(type: "TEXT", nullable: true),
                    rod = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catch_details", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catch_media",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    file_size = table.Column<int>(type: "INTEGER", nullable: true),
                    filename = table.Column<string>(type: "TEXT", nullable: true),
                    extension = table.Column<string>(type: "TEXT", nullable: true),
                    mimetype = table.Column<string>(type: "TEXT", nullable: true),
                    upload_date = table.Column<DateTime>(type: "TEXT", nullable: true),
                    catch_detail_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catch_media", x => x.id);
                    table.ForeignKey(
                        name: "FK_catch_media_catch_details_catch_detail_id",
                        column: x => x.catch_detail_id,
                        principalTable: "catch_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "simple_search_index",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    catch_id = table.Column<int>(type: "INTEGER", nullable: true),
                    data = table.Column<string>(type: "TEXT", nullable: true),
                    catch_detail_id = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_simple_search_index", x => x.id);
                    table.ForeignKey(
                        name: "FK_simple_search_index_catch_details_catch_detail_id",
                        column: x => x.catch_detail_id,
                        principalTable: "catch_details",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_catch_media_catch_detail_id",
                table: "catch_media",
                column: "catch_detail_id");

            migrationBuilder.CreateIndex(
                name: "IX_simple_search_index_catch_detail_id",
                table: "simple_search_index",
                column: "catch_detail_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "catch_media");

            migrationBuilder.DropTable(
                name: "simple_search_index");

            migrationBuilder.DropTable(
                name: "catch_details");
        }
    }
}
