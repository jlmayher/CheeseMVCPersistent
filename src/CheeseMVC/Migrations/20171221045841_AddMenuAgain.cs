using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CheeseMVC.Migrations
{
    public partial class AddMenuAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheeseMenus_Categories_CheeseCategoryID",
                table: "CheeseMenus");

            migrationBuilder.DropIndex(
                name: "IX_CheeseMenus_CheeseCategoryID",
                table: "CheeseMenus");

            migrationBuilder.DropColumn(
                name: "CheeseCategoryID",
                table: "CheeseMenus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CheeseCategoryID",
                table: "CheeseMenus",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CheeseMenus_CheeseCategoryID",
                table: "CheeseMenus",
                column: "CheeseCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_CheeseMenus_Categories_CheeseCategoryID",
                table: "CheeseMenus",
                column: "CheeseCategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
