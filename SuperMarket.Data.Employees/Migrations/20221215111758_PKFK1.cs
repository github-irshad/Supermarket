using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SuperMarket.Data.Employees.Migrations
{
    /// <inheritdoc />
    public partial class PKFK1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeSalary",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    employeeid = table.Column<int>(name: "employee_id", type: "integer", nullable: false),
                    salarycomponentid = table.Column<int>(name: "salary_component_id", type: "integer", nullable: false),
                    amount = table.Column<double>(type: "double precision", nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "timestamptz", nullable: true),
                    createdby = table.Column<int>(name: "created_by", type: "integer", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "timestamptz", nullable: true),
                    updatedby = table.Column<int>(name: "updated_by", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSalary", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    username = table.Column<string>(name: "user_name", type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    usertype = table.Column<string>(name: "user_type", type: "text", nullable: false),
                    createdat = table.Column<DateTime>(name: "created_at", type: "timestamptz", nullable: true),
                    createdby = table.Column<int>(name: "created_by", type: "integer", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "timestamptz", nullable: true),
                    updatedby = table.Column<int>(name: "updated_by", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    firstName = table.Column<string>(type: "text", nullable: false),
                    lastName = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    aadharnumber = table.Column<string>(name: "aadhar_number", type: "text", nullable: false),
                    aadhardocument = table.Column<string>(name: "aadhar_document", type: "text", nullable: false),
                    verification = table.Column<bool>(type: "boolean", nullable: false),
                    designation = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    phonenumber = table.Column<string>(name: "phone_number", type: "text", nullable: false),
                    department = table.Column<string>(type: "text", nullable: false),
                    profilepicture = table.Column<string>(name: "profile_picture", type: "text", nullable: false),
                    usertype = table.Column<string>(name: "user_type", type: "text", nullable: false),
                    employeeSalaryId = table.Column<int>(type: "integer", nullable: true),
                    createdat = table.Column<DateTime>(name: "created_at", type: "timestamptz", nullable: true),
                    createdby = table.Column<int>(name: "created_by", type: "integer", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "timestamptz", nullable: true),
                    updatedby = table.Column<int>(name: "updated_by", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.id);
                    table.ForeignKey(
                        name: "FK_Employee_EmployeeSalary_employeeSalaryId",
                        column: x => x.employeeSalaryId,
                        principalTable: "EmployeeSalary",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "SalaryComponents",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    componentname = table.Column<string>(name: "component_name", type: "text", nullable: false),
                    componenttype = table.Column<string>(name: "component_type", type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    employeeSalaryId = table.Column<int>(type: "integer", nullable: true),
                    createdat = table.Column<DateTime>(name: "created_at", type: "timestamptz", nullable: true),
                    createdby = table.Column<int>(name: "created_by", type: "integer", nullable: false),
                    updatedat = table.Column<DateTime>(name: "updated_at", type: "timestamptz", nullable: true),
                    updatedby = table.Column<int>(name: "updated_by", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryComponents", x => x.id);
                    table.ForeignKey(
                        name: "FK_SalaryComponents_EmployeeSalary_employeeSalaryId",
                        column: x => x.employeeSalaryId,
                        principalTable: "EmployeeSalary",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_employeeSalaryId",
                table: "Employee",
                column: "employeeSalaryId");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryComponents_employeeSalaryId",
                table: "SalaryComponents",
                column: "employeeSalaryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "SalaryComponents");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "EmployeeSalary");
        }
    }
}
