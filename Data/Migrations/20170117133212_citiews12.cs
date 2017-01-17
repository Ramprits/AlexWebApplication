using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AlexWebApp.Data.Migrations
{
    public partial class citiews12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citieses_PointsOfInterest_CityId",
                table: "Citieses");

            migrationBuilder.DropIndex(
                name: "IX_Citieses_CityId",
                table: "Citieses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Citieses");

            migrationBuilder.CreateIndex(
                name: "IX_PointsOfInterest_CityId",
                table: "PointsOfInterest",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_PointsOfInterest_Citieses_CityId",
                table: "PointsOfInterest",
                column: "CityId",
                principalTable: "Citieses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PointsOfInterest_Citieses_CityId",
                table: "PointsOfInterest");

            migrationBuilder.DropIndex(
                name: "IX_PointsOfInterest_CityId",
                table: "PointsOfInterest");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Citieses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Citieses_CityId",
                table: "Citieses",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Citieses_PointsOfInterest_CityId",
                table: "Citieses",
                column: "CityId",
                principalTable: "PointsOfInterest",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
