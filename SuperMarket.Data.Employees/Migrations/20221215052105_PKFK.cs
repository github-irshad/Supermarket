using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperMarket.Data.Employees.Migrations
{
    /// <inheritdoc />
    public partial class PKFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeSalary_employeeSalaryId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_employeeSalaryId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "employeeSalaryId",
                table: "Employee");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "employeeSalaryId",
                table: "Employee",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_employeeSalaryId",
                table: "Employee",
                column: "employeeSalaryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeSalary_employeeSalaryId",
                table: "Employee",
                column: "employeeSalaryId",
                principalTable: "EmployeeSalary",
                principalColumn: "id");
        }
    }
}
