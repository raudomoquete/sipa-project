using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiPA.API.Migrations
{
    public partial class CompleteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RequestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    RequestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestTypes_Churches_Id",
                        column: x => x.Id,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weddings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeddingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodFatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodFatherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoMotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodMotherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Witness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WitnessIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CeremonialCelebrant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChurchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weddings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weddings_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parishioners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChurchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parishioners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parishioners_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parishioners_Weddings_Id",
                        column: x => x.Id,
                        principalTable: "Weddings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Christenings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ChristeningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodFatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodFatherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoMotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodMotherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CeremonialCelebrant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChurchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Christenings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Christenings_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Christenings_Parishioners_Id",
                        column: x => x.Id,
                        principalTable: "Parishioners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Confirmations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    ConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodFatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodFatherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoMotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GodMotherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CeremonialCelebrant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChurchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confirmations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Confirmations_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Confirmations_Parishioners_Id",
                        column: x => x.Id,
                        principalTable: "Parishioners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FirstCommunions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstCommunionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherIdentification = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CeremonialCelebrant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChurchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirstCommunions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FirstCommunions_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FirstCommunions_Parishioners_Id",
                        column: x => x.Id,
                        principalTable: "Parishioners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParishionerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Histories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Histories_Parishioners_ParishionerId",
                        column: x => x.ParishionerId,
                        principalTable: "Parishioners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Histories_RequestTypes_Id",
                        column: x => x.Id,
                        principalTable: "RequestTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Christenings_ChurchId",
                table: "Christenings",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Confirmations_ChurchId",
                table: "Confirmations",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstCommunions_ChurchId",
                table: "FirstCommunions",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Histories_ParishionerId",
                table: "Histories",
                column: "ParishionerId");

            migrationBuilder.CreateIndex(
                name: "IX_Parishioners_ChurchId",
                table: "Parishioners",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_ChurchId",
                table: "Weddings",
                column: "ChurchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Christenings");

            migrationBuilder.DropTable(
                name: "Confirmations");

            migrationBuilder.DropTable(
                name: "FirstCommunions");

            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Parishioners");

            migrationBuilder.DropTable(
                name: "RequestTypes");

            migrationBuilder.DropTable(
                name: "Weddings");
        }
    }
}
