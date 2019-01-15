using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtyFinal.DataAccess.Migrations
{
    public partial class AddPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<Guid>(nullable: false),
                    PaymentDesc = table.Column<string>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: false),
                    PaymentAmount = table.Column<decimal>(nullable: false),
                    DebtorPersonID = table.Column<Guid>(nullable: true),
                    LoanID = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payments_Persons_DebtorPersonID",
                        column: x => x.DebtorPersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Loans_LoanID",
                        column: x => x.LoanID,
                        principalTable: "Loans",
                        principalColumn: "LoanID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_DebtorPersonID",
                table: "Payments",
                column: "DebtorPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_LoanID",
                table: "Payments",
                column: "LoanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.AddColumn<decimal>(
                name: "LoanAmount",
                table: "Loans",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
