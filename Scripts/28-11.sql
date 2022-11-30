﻿CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" character varying(150) NOT NULL,
    "ProductVersion" character varying(32) NOT NULL,
    CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY ("MigrationId")
);

START TRANSACTION;

CREATE TABLE "EmployeeSalary" (
    id integer GENERATED BY DEFAULT AS IDENTITY,
    employee_id integer NOT NULL,
    salary_component_id integer NOT NULL,
    amount double precision NOT NULL,
    created_at timestamptz NOT NULL,
    created_by integer NOT NULL,
    updated_at timestamptz NOT NULL,
    updated_by integer NOT NULL,
    CONSTRAINT "PK_EmployeeSalary" PRIMARY KEY (id)
);

CREATE TABLE "User" (
    id integer GENERATED BY DEFAULT AS IDENTITY,
    "userName" text NOT NULL,
    password text NOT NULL,
    user_type integer NOT NULL,
    created_at timestamptz NOT NULL,
    created_by integer NOT NULL,
    updated_at timestamptz NOT NULL,
    updated_by integer NOT NULL,
    CONSTRAINT "PK_User" PRIMARY KEY (id)
);

CREATE TABLE "Employee" (
    id integer GENERATED BY DEFAULT AS IDENTITY,
    "firstName" text NULL,
    "lastName" text NULL,
    address text NULL,
    aadhar_number text NULL,
    aadhar_document text NULL,
    verification boolean NOT NULL,
    designation text NULL,
    "employeeSalaryId" integer NOT NULL,
    created_at timestamptz NOT NULL,
    created_by integer NOT NULL,
    updated_at timestamptz NOT NULL,
    updated_by integer NOT NULL,
    CONSTRAINT "PK_Employee" PRIMARY KEY (id),
    CONSTRAINT "FK_Employee_EmployeeSalary_employeeSalaryId" FOREIGN KEY ("employeeSalaryId") REFERENCES "EmployeeSalary" (id) ON DELETE CASCADE
);

CREATE TABLE "SalaryComponents" (
    id integer GENERATED BY DEFAULT AS IDENTITY,
    component_name text NOT NULL,
    component_type text NOT NULL,
    description text NOT NULL,
    "employeeSalaryId" integer NOT NULL,
    created_at timestamptz NOT NULL,
    created_by integer NOT NULL,
    updated_at timestamptz NOT NULL,
    updated_by integer NOT NULL,
    CONSTRAINT "PK_SalaryComponents" PRIMARY KEY (id),
    CONSTRAINT "FK_SalaryComponents_EmployeeSalary_employeeSalaryId" FOREIGN KEY ("employeeSalaryId") REFERENCES "EmployeeSalary" (id) ON DELETE CASCADE
);

CREATE INDEX "IX_Employee_employeeSalaryId" ON "Employee" ("employeeSalaryId");

CREATE INDEX "IX_SalaryComponents_employeeSalaryId" ON "SalaryComponents" ("employeeSalaryId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20221114053018_myMigration01', '7.0.0');

COMMIT;

START TRANSACTION;

ALTER TABLE "User" RENAME COLUMN "userName" TO user_name;

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20221114064314_SecongMigration', '7.0.0');

COMMIT;

START TRANSACTION;

ALTER TABLE "Employee" DROP CONSTRAINT "FK_Employee_EmployeeSalary_employeeSalaryId";

ALTER TABLE "SalaryComponents" DROP CONSTRAINT "FK_SalaryComponents_EmployeeSalary_employeeSalaryId";

ALTER TABLE "User" ALTER COLUMN user_name DROP NOT NULL;

ALTER TABLE "User" ALTER COLUMN updated_at DROP NOT NULL;

ALTER TABLE "User" ALTER COLUMN password DROP NOT NULL;

ALTER TABLE "User" ALTER COLUMN created_at DROP NOT NULL;

ALTER TABLE "SalaryComponents" ALTER COLUMN updated_at DROP NOT NULL;

ALTER TABLE "SalaryComponents" ALTER COLUMN "employeeSalaryId" DROP NOT NULL;

ALTER TABLE "SalaryComponents" ALTER COLUMN description DROP NOT NULL;

ALTER TABLE "SalaryComponents" ALTER COLUMN created_at DROP NOT NULL;

ALTER TABLE "SalaryComponents" ALTER COLUMN component_type DROP NOT NULL;

ALTER TABLE "SalaryComponents" ALTER COLUMN component_name DROP NOT NULL;

ALTER TABLE "EmployeeSalary" ALTER COLUMN updated_at DROP NOT NULL;

ALTER TABLE "EmployeeSalary" ALTER COLUMN salary_component_id DROP NOT NULL;

ALTER TABLE "EmployeeSalary" ALTER COLUMN employee_id DROP NOT NULL;

ALTER TABLE "EmployeeSalary" ALTER COLUMN created_at DROP NOT NULL;

ALTER TABLE "EmployeeSalary" ALTER COLUMN amount DROP NOT NULL;

ALTER TABLE "Employee" ALTER COLUMN updated_at DROP NOT NULL;

ALTER TABLE "Employee" ALTER COLUMN "employeeSalaryId" DROP NOT NULL;

ALTER TABLE "Employee" ALTER COLUMN created_at DROP NOT NULL;

ALTER TABLE "Employee" ADD CONSTRAINT "FK_Employee_EmployeeSalary_employeeSalaryId" FOREIGN KEY ("employeeSalaryId") REFERENCES "EmployeeSalary" (id);

ALTER TABLE "SalaryComponents" ADD CONSTRAINT "FK_SalaryComponents_EmployeeSalary_employeeSalaryId" FOREIGN KEY ("employeeSalaryId") REFERENCES "EmployeeSalary" (id);

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20221128115158_myMigration02', '7.0.0');

COMMIT;
