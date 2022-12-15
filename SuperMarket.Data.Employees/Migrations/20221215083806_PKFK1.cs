using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperMarket.Data.Employees.Migrations
{
    /// <inheritdoc />
    public partial class PKFK1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalaryComponents_EmployeeSalary_employeeSalaryId",
                table: "SalaryComponents");

            migrationBuilder.DropIndex(
                name: "IX_SalaryComponents_employeeSalaryId",
                table: "SalaryComponents");

            migrationBuilder.DropColumn(
                name: "employeeSalaryId",
                table: "SalaryComponents");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "employeeSalaryId",
                table: "SalaryComponents",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalaryComponents_employeeSalaryId",
                table: "SalaryComponents",
                column: "employeeSalaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryComponents_EmployeeSalary_employeeSalaryId",
                table: "SalaryComponents",
                column: "employeeSalaryId",
                principalTable: "EmployeeSalary",
                principalColumn: "id");
        }
    }
}
