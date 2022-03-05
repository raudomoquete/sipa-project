using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiPA.API.Migrations
{
    public partial class CompleteDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Churches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Churches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Christenings",
                columns: table => new
                {
                    ChristeningId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Christenings", x => x.ChristeningId);
                    table.ForeignKey(
                        name: "FK_Christenings_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Confirmations",
                columns: table => new
                {
                    ConfirmationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_Confirmations", x => x.ConfirmationId);
                    table.ForeignKey(
                        name: "FK_Confirmations_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FirstCommunions",
                columns: table => new
                {
                    FirstCommunionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_FirstCommunions", x => x.FirstCommunionId);
                    table.ForeignKey(
                        name: "FK_FirstCommunions_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChurchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RequestTypes_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weddings",
                columns: table => new
                {
                    WeddingId = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Weddings", x => x.WeddingId);
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChurchId = table.Column<int>(type: "int", nullable: true),
                    ChristeningId = table.Column<int>(type: "int", nullable: false),
                    FirstCommunionId = table.Column<int>(type: "int", nullable: false),
                    ConfirmationId = table.Column<int>(type: "int", nullable: false),
                    WeddingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parishioners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parishioners_Christenings_ChristeningId",
                        column: x => x.ChristeningId,
                        principalTable: "Christenings",
                        principalColumn: "ChristeningId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parishioners_Churches_ChurchId",
                        column: x => x.ChurchId,
                        principalTable: "Churches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Parishioners_Confirmations_ConfirmationId",
                        column: x => x.ConfirmationId,
                        principalTable: "Confirmations",
                        principalColumn: "ConfirmationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parishioners_FirstCommunions_FirstCommunionId",
                        column: x => x.FirstCommunionId,
                        principalTable: "FirstCommunions",
                        principalColumn: "FirstCommunionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Parishioners_Weddings_WeddingId",
                        column: x => x.WeddingId,
                        principalTable: "Weddings",
                        principalColumn: "WeddingId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Histories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestTypeId = table.Column<int>(type: "int", nullable: true),
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
                        name: "FK_Histories_RequestTypes_RequestTypeId",
                        column: x => x.RequestTypeId,
                        principalTable: "RequestTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "IX_Histories_RequestTypeId",
                table: "Histories",
                column: "RequestTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Parishioners_ChristeningId",
                table: "Parishioners",
                column: "ChristeningId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parishioners_ChurchId",
                table: "Parishioners",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Parishioners_ConfirmationId",
                table: "Parishioners",
                column: "ConfirmationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parishioners_FirstCommunionId",
                table: "Parishioners",
                column: "FirstCommunionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Parishioners_WeddingId",
                table: "Parishioners",
                column: "WeddingId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestTypes_ChurchId",
                table: "RequestTypes",
                column: "ChurchId");

            migrationBuilder.CreateIndex(
                name: "IX_Weddings_ChurchId",
                table: "Weddings",
                column: "ChurchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Histories");

            migrationBuilder.DropTable(
                name: "Parishioners");

            migrationBuilder.DropTable(
                name: "RequestTypes");

            migrationBuilder.DropTable(
                name: "Christenings");

            migrationBuilder.DropTable(
                name: "Confirmations");

            migrationBuilder.DropTable(
                name: "FirstCommunions");

            migrationBuilder.DropTable(
                name: "Weddings");

            migrationBuilder.DropTable(
                name: "Churches");
        }
    }
}
