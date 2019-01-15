using Microsoft.EntityFrameworkCore.Migrations;

namespace DebtyFinal.DataAccess.Migrations
{
    public partial class AddLoanAmountInLoan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "LoanAmount",
                table: "Loans",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoanAmount",
                table: "Loans");
        }
    }
}
