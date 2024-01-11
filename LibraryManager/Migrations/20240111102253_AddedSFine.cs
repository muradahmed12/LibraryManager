using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManager.Migrations
{
    /// <inheritdoc />
    public partial class AddedSFine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FineAmount",
                table: "Fines");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedTime",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedTime",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedTime",
                table: "LibraryMembers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedTime",
                table: "Fines",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedTime",
                table: "Borrowings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedTime",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModifiedTime",
                table: "AudsitTrail",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "SFines",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FineAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SFineId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SFinesId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    FineId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DbEntryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SFines", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SFines_Fines_FineId",
                        column: x => x.FineId,
                        principalTable: "Fines",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SFines_SFines_SFinesId",
                        column: x => x.SFinesId,
                        principalTable: "SFines",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SFines_FineId",
                table: "SFines",
                column: "FineId");

            migrationBuilder.CreateIndex(
                name: "IX_SFines_SFinesId",
                table: "SFines",
                column: "SFinesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SFines");

            migrationBuilder.DropColumn(
                name: "LastModifiedTime",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastModifiedTime",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "LastModifiedTime",
                table: "LibraryMembers");

            migrationBuilder.DropColumn(
                name: "LastModifiedTime",
                table: "Fines");

            migrationBuilder.DropColumn(
                name: "LastModifiedTime",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastModifiedTime",
                table: "Borrowings");

            migrationBuilder.DropColumn(
                name: "LastModifiedTime",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "LastModifiedTime",
                table: "AudsitTrail");

            migrationBuilder.AddColumn<decimal>(
                name: "FineAmount",
                table: "Fines",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
