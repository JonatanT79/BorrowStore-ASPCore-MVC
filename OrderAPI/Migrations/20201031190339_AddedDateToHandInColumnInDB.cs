using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderAPI.Migrations
{
    public partial class AddedDateToHandInColumnInDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateToHandIn",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateToHandIn",
                table: "Order");
        }
    }
}
