using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace wtamucis3312final.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationalParks",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ParkName = table.Column<string>(type: "TEXT", nullable: false),
                    ParkState = table.Column<string>(type: "TEXT", nullable: false),
                    ParkAbbreviation = table.Column<string>(type: "TEXT", nullable: true),
                    ParkProperName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationalParks", x => x.NationalParkId);
                });

            migrationBuilder.CreateTable(
                name: "UserData",
                columns: table => new
                {
                    UserDataId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserData", x => x.UserDataId);
                });

            migrationBuilder.CreateTable(
                name: "UserNationalParks",
                columns: table => new
                {
                    NationalParkId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserDataId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserNationalParks", x => new { x.NationalParkId, x.UserDataId });
                    table.ForeignKey(
                        name: "FK_UserNationalParks_NationalParks_NationalParkId",
                        column: x => x.NationalParkId,
                        principalTable: "NationalParks",
                        principalColumn: "NationalParkId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserNationalParks_UserData_UserDataId",
                        column: x => x.UserDataId,
                        principalTable: "UserData",
                        principalColumn: "UserDataId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserNationalParks_UserDataId",
                table: "UserNationalParks",
                column: "UserDataId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserNationalParks");

            migrationBuilder.DropTable(
                name: "NationalParks");

            migrationBuilder.DropTable(
                name: "UserData");
        }
    }
}
