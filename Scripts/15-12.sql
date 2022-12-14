CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
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
    created_at timestamptz NULL,
    created_by integer NOT NULL,
    updated_at timestamptz NULL,
    updated_by integer NOT NULL,
    CONSTRAINT "PK_EmployeeSalary" PRIMARY KEY (id)
);

CREATE TABLE "User" (
    id integer GENERATED BY DEFAULT AS IDENTITY,
    user_name text NOT NULL,
    password text NOT NULL,
    user_type text NOT NULL,
    created_at timestamptz NULL,
    created_by integer NOT NULL,
    updated_at timestamptz NULL,
    updated_by integer NOT NULL,
    CONSTRAINT "PK_User" PRIMARY KEY (id)
);

CREATE TABLE "Employee" (
    id integer GENERATED BY DEFAULT AS IDENTITY,
    "firstName" text NOT NULL,
    "lastName" text NOT NULL,
    address text NOT NULL,
    aadhar_number text NOT NULL,
    aadhar_document text NOT NULL,
    verification boolean NOT NULL,
    designation text NOT NULL,
    email text NOT NULL,
    phone_number text NOT NULL,
    department text NOT NULL,
    profile_picture text NOT NULL,
    user_type text NOT NULL,
    "employeeSalaryId" integer NULL,
    created_at timestamptz NULL,
    created_by integer NOT NULL,
    updated_at timestamptz NULL,
    updated_by integer NOT NULL,
    CONSTRAINT "PK_Employee" PRIMARY KEY (id),
    CONSTRAINT "FK_Employee_EmployeeSalary_employeeSalaryId" FOREIGN KEY ("employeeSalaryId") REFERENCES "EmployeeSalary" (id)
);

CREATE TABLE "SalaryComponents" (
    id integer GENERATED BY DEFAULT AS IDENTITY,
    component_name text NOT NULL,
    component_type text NOT NULL,
    description text NOT NULL,
    "employeeSalaryId" integer NULL,
    created_at timestamptz NULL,
    created_by integer NOT NULL,
    updated_at timestamptz NULL,
    updated_by integer NOT NULL,
    CONSTRAINT "PK_SalaryComponents" PRIMARY KEY (id),
    CONSTRAINT "FK_SalaryComponents_EmployeeSalary_employeeSalaryId" FOREIGN KEY ("employeeSalaryId") REFERENCES "EmployeeSalary" (id)
);

CREATE INDEX "IX_Employee_employeeSalaryId" ON "Employee" ("employeeSalaryId");

CREATE INDEX "IX_SalaryComponents_employeeSalaryId" ON "SalaryComponents" ("employeeSalaryId");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20221215111758_PKFK1', '7.0.0');

COMMIT;

