using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shop.Web.Migrations
{
    public partial class InicioProductos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastPurchase",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastSale",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "IsAvailabe",
                table: "Products",
                newName: "Presentacion");

            migrationBuilder.AddColumn<string>(
                name: "Contacto",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Direccion",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProSer",
                table: "Products",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contacto",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Direccion",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProSer",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Presentacion",
                table: "Products",
                newName: "IsAvailabe");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastPurchase",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastSale",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Products",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<double>(
                name: "Stock",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
