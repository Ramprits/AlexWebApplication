using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AlexWebApp.Data.Migrations
{
    public partial class Departments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clients_addresses_BillingAddressAddressId",
                table: "clients");

            migrationBuilder.DropForeignKey(
                name: "FK_clients_addresses_MailingAddressAddressId",
                table: "clients");

            migrationBuilder.DropForeignKey(
                name: "FK_emailPromos_clients_ClientId",
                table: "emailPromos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_orders",
                table: "orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_emailPromos",
                table: "emailPromos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_clients",
                table: "clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_addresses",
                table: "addresses");

            migrationBuilder.RenameTable(
                name: "orders",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "emailPromos",
                newName: "EmailPromos");

            migrationBuilder.RenameTable(
                name: "clients",
                newName: "Clients");

            migrationBuilder.RenameTable(
                name: "addresses",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_emailPromos_ClientId",
                table: "EmailPromos",
                newName: "IX_EmailPromos_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_clients_MailingAddressAddressId",
                table: "Clients",
                newName: "IX_Clients_MailingAddressAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_clients_BillingAddressAddressId",
                table: "Clients",
                newName: "IX_Clients_BillingAddressAddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmailPromos",
                table: "EmailPromos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "AddressId");

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: false),
                    EmployeesEmployeeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Employees_EmployeesEmployeeId",
                        column: x => x.EmployeesEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_EmployeesEmployeeId",
                table: "Departments",
                column: "EmployeesEmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Addresses_BillingAddressAddressId",
                table: "Clients",
                column: "BillingAddressAddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Addresses_MailingAddressAddressId",
                table: "Clients",
                column: "MailingAddressAddressId",
                principalTable: "Addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailPromos_Clients_ClientId",
                table: "EmailPromos",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_BillingAddressAddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Addresses_MailingAddressAddressId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailPromos_Clients_ClientId",
                table: "EmailPromos");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmailPromos",
                table: "EmailPromos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "orders");

            migrationBuilder.RenameTable(
                name: "EmailPromos",
                newName: "emailPromos");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "clients");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "addresses");

            migrationBuilder.RenameIndex(
                name: "IX_EmailPromos_ClientId",
                table: "emailPromos",
                newName: "IX_emailPromos_ClientId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_MailingAddressAddressId",
                table: "clients",
                newName: "IX_clients_MailingAddressAddressId");

            migrationBuilder.RenameIndex(
                name: "IX_Clients_BillingAddressAddressId",
                table: "clients",
                newName: "IX_clients_BillingAddressAddressId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_orders",
                table: "orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emailPromos",
                table: "emailPromos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_clients",
                table: "clients",
                column: "ClientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_addresses",
                table: "addresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_clients_addresses_BillingAddressAddressId",
                table: "clients",
                column: "BillingAddressAddressId",
                principalTable: "addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_clients_addresses_MailingAddressAddressId",
                table: "clients",
                column: "MailingAddressAddressId",
                principalTable: "addresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_emailPromos_clients_ClientId",
                table: "emailPromos",
                column: "ClientId",
                principalTable: "clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
