using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperMarket.Data.Employees.Migrations
{
    /// <inheritdoc />
    public partial class myMigration02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeSalary_employeeSalaryId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryComponents_EmployeeSalary_employeeSalaryId",
                table: "SalaryComponents");

            migrationBuilder.AlterColumn<string>(
                name: "user_name",
                table: "User",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "User",
                type: "timestamptz",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "User",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "User",
                type: "timestamptz",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "SalaryComponents",
                type: "timestamptz",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AlterColumn<int>(
                name: "employeeSalaryId",
                table: "SalaryComponents",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "SalaryComponents",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "SalaryComponents",
                type: "timestamptz",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AlterColumn<string>(
                name: "component_type",
                table: "SalaryComponents",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "component_name",
                table: "SalaryComponents",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "EmployeeSalary",
                type: "timestamptz",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AlterColumn<int>(
                name: "salary_component_id",
                table: "EmployeeSalary",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "employee_id",
                table: "EmployeeSalary",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "EmployeeSalary",
                type: "timestamptz",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AlterColumn<double>(
                name: "amount",
                table: "EmployeeSalary",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "Employee",
                type: "timestamptz",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AlterColumn<int>(
                name: "employeeSalaryId",
                table: "Employee",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Employee",
                type: "timestamptz",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamptz");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeSalary_employeeSalaryId",
                table: "Employee",
                column: "employeeSalaryId",
                principalTable: "EmployeeSalary",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryComponents_EmployeeSalary_employeeSalaryId",
                table: "SalaryComponents",
                column: "employeeSalaryId",
                principalTable: "EmployeeSalary",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_EmployeeSalary_employeeSalaryId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_SalaryComponents_EmployeeSalary_employeeSalaryId",
                table: "SalaryComponents");

            migrationBuilder.AlterColumn<string>(
                name: "user_name",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "User",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamptz",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "User",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamptz",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "SalaryComponents",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamptz",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "employeeSalaryId",
                table: "SalaryComponents",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "SalaryComponents",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "SalaryComponents",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamptz",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "component_type",
                table: "SalaryComponents",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "component_name",
                table: "SalaryComponents",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "EmployeeSalary",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamptz",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "salary_component_id",
                table: "EmployeeSalary",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "employee_id",
                table: "EmployeeSalary",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "EmployeeSalary",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamptz",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "amount",
                table: "EmployeeSalary",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "updated_at",
                table: "Employee",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamptz",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "employeeSalaryId",
                table: "Employee",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_at",
                table: "Employee",
                type: "timestamptz",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamptz",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_EmployeeSalary_employeeSalaryId",
                table: "Employee",
                column: "employeeSalaryId",
                principalTable: "EmployeeSalary",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalaryComponents_EmployeeSalary_employeeSalaryId",
                table: "SalaryComponents",
                column: "employeeSalaryId",
                principalTable: "EmployeeSalary",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
