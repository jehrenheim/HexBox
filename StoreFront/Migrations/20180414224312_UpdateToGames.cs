using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace StoreFront.Migrations
{
    public partial class UpdateToGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropIndex(
                name: "IX_Color_ProductID",
                table: "Color");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Color");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Product",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DefaultImage",
                table: "Product",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NumberOfPlayers",
                table: "Product",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PlayTime",
                table: "Product",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Product",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Image = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DefaultImage",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "NumberOfPlayers",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "PlayTime",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Product");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Product",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Color",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Color_ProductID",
                table: "Color",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_Color_Product_ProductID",
                table: "Color",
                column: "ProductID",
                principalTable: "Product",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
