CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

ALTER TABLE "Employee" DROP CONSTRAINT "FK_Employee_EmployeeSalary_employeeSalaryId";

DROP INDEX "IX_Employee_employeeSalaryId";

ALTER TABLE "Employee" DROP COLUMN "employeeSalaryId";

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20221215052105_PKFK', '7.0.0');

COMMIT;

START TRANSACTION;

ALTER TABLE "SalaryComponents" DROP CONSTRAINT "FK_SalaryComponents_EmployeeSalary_employeeSalaryId";

DROP INDEX "IX_SalaryComponents_employeeSalaryId";

ALTER TABLE "SalaryComponents" DROP COLUMN "employeeSalaryId";

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20221215083806_PKFK1', '7.0.0');

COMMIT;

