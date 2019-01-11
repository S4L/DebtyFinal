using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtyFinal.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Credentials",
                columns: table => new
                {
                    CredentialID = table.Column<Guid>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Credentials", x => x.CredentialID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentID = table.Column<Guid>(nullable: false),
                    PayAmount = table.Column<double>(nullable: false),
                    PayDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentID);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    PersonID = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PersonCredentialCredentialID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.PersonID);
                    table.ForeignKey(
                        name: "FK_Persons_Credentials_PersonCredentialCredentialID",
                        column: x => x.PersonCredentialCredentialID,
                        principalTable: "Credentials",
                        principalColumn: "CredentialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loans",
                columns: table => new
                {
                    LoanID = table.Column<Guid>(nullable: false),
                    LoanName = table.Column<string>(nullable: false),
                    LoanDesc = table.Column<string>(nullable: true),
                    LoanDate = table.Column<string>(nullable: false),
                    DeadLine = table.Column<string>(nullable: false),
                    LoanAmount = table.Column<string>(nullable: false),
                    PaymentID = table.Column<Guid>(nullable: false),
                    CreditorPersonID = table.Column<Guid>(nullable: false),
                    DebtorPersonID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loans", x => x.LoanID);
                    table.ForeignKey(
                        name: "FK_Loans_Persons_CreditorPersonID",
                        column: x => x.CreditorPersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Persons_DebtorPersonID",
                        column: x => x.DebtorPersonID,
                        principalTable: "Persons",
                        principalColumn: "PersonID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loans_Payments_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payments",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loans_CreditorPersonID",
                table: "Loans",
                column: "CreditorPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_DebtorPersonID",
                table: "Loans",
                column: "DebtorPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_PaymentID",
                table: "Loans",
                column: "PaymentID");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PersonCredentialCredentialID",
                table: "Persons",
                column: "PersonCredentialCredentialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loans");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Credentials");
        }
    }
}
