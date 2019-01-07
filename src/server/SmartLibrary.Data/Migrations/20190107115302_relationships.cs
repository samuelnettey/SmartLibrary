using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SmartLibrary.Data.Migrations
{
    public partial class relationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompetitionId",
                table: "Memebers");

            migrationBuilder.CreateTable(
                name: "MemberCompetition",
                columns: table => new
                {
                    MemberId = table.Column<int>(nullable: false),
                    CompetitionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberCompetition", x => new { x.MemberId, x.CompetitionId });
                    table.ForeignKey(
                        name: "FK_MemberCompetition_Competitions_CompetitionId",
                        column: x => x.CompetitionId,
                        principalTable: "Competitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberCompetition_Memebers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Memebers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MemberIdentity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MemberId = table.Column<int>(nullable: false),
                    RealName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberIdentity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberIdentity_Memebers_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Memebers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberCompetition_CompetitionId",
                table: "MemberCompetition",
                column: "CompetitionId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberIdentity_MemberId",
                table: "MemberIdentity",
                column: "MemberId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberCompetition");

            migrationBuilder.DropTable(
                name: "MemberIdentity");

            migrationBuilder.AddColumn<int>(
                name: "CompetitionId",
                table: "Memebers",
                nullable: false,
                defaultValue: 0);
        }
    }
}
