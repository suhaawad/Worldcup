using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace worldcup.Migrations
{
    /// <inheritdoc />
    public partial class addingthem2mfortheschedulandteam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScheduleTeams",
                columns: table => new
                {
                    SchedulesId = table.Column<int>(type: "int", nullable: false),
                    TeamsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduleTeams", x => new { x.SchedulesId, x.TeamsId });
                    table.ForeignKey(
                        name: "FK_ScheduleTeams_Schedule_SchedulesId",
                        column: x => x.SchedulesId,
                        principalTable: "Schedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScheduleTeams_Teams_TeamsId",
                        column: x => x.TeamsId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ScheduleTeams_TeamsId",
                table: "ScheduleTeams",
                column: "TeamsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScheduleTeams");
        }
    }
}
