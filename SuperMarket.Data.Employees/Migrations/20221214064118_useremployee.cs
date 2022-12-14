using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperMarket.Data.Employees.Migrations
{
    /// <inheritdoc />
    public partial class useremployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "employee_id",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_employee_id",
                table: "User",
                column: "employee_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Employee_employee_id",
                table: "User",
                column: "employee_id",
                principalTable: "Employee",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Employee_employee_id",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_employee_id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "employee_id",
                table: "User");
        }
    }
}
