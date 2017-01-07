using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AlexWebApp.Data.Migrations
{
    public partial class clients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "clients");

            migrationBuilder.AddColumn<int>(
                name: "BillingAddressAddressId",
                table: "clients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClientType",
                table: "clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CompanyName",
                table: "clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "ContactDate",
                table: "clients",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MailingAddressAddressId",
                table: "clients",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "clients",
                maxLength: 25,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "clients",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "emailPromos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: true),
                    IsSubscribed = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emailPromos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_emailPromos_clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "clients",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.OrderId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_clients_BillingAddressAddressId",
                table: "clients",
                column: "BillingAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_clients_MailingAddressAddressId",
                table: "clients",
                column: "MailingAddressAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_emailPromos_ClientId",
                table: "emailPromos",
                column: "ClientId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clients_addresses_BillingAddressAddressId",
                table: "clients");

            migrationBuilder.DropForeignKey(
                name: "FK_clients_addresses_MailingAddressAddressId",
                table: "clients");

            migrationBuilder.DropTable(
                name: "addresses");

            migrationBuilder.DropTable(
                name: "emailPromos");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropIndex(
                name: "IX_clients_BillingAddressAddressId",
                table: "clients");

            migrationBuilder.DropIndex(
                name: "IX_clients_MailingAddressAddressId",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "BillingAddressAddressId",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "ClientType",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "CompanyName",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "ContactDate",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "MailingAddressAddressId",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "clients");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "clients");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "clients",
                nullable: true);
        }
    }
}
