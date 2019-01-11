using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtyFinal.Migrations
{
    public partial class testmigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Persons_CreditorPersonID",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Persons_DebtorPersonID",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Payments_PaymentID",
                table: "Loans");

            migrationBuilder.AlterColumn<Guid>(
                name: "PaymentID",
                table: "Loans",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "DebtorPersonID",
                table: "Loans",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "CreditorPersonID",
                table: "Loans",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Persons_CreditorPersonID",
                table: "Loans",
                column: "CreditorPersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Persons_DebtorPersonID",
                table: "Loans",
                column: "DebtorPersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Payments_PaymentID",
                table: "Loans",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "PaymentID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Persons_CreditorPersonID",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Persons_DebtorPersonID",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Payments_PaymentID",
                table: "Loans");

            migrationBuilder.AlterColumn<Guid>(
                name: "PaymentID",
                table: "Loans",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DebtorPersonID",
                table: "Loans",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreditorPersonID",
                table: "Loans",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Persons_CreditorPersonID",
                table: "Loans",
                column: "CreditorPersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Persons_DebtorPersonID",
                table: "Loans",
                column: "DebtorPersonID",
                principalTable: "Persons",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Payments_PaymentID",
                table: "Loans",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "PaymentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
