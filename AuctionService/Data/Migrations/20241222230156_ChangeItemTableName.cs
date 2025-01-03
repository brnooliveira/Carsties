using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeItemTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_auctions_AuctionId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "items");

            migrationBuilder.RenameIndex(
                name: "IX_Items_AuctionId",
                table: "items",
                newName: "IX_items_AuctionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_items",
                table: "items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_items_auctions_AuctionId",
                table: "items",
                column: "AuctionId",
                principalTable: "auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_auctions_AuctionId",
                table: "items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_items",
                table: "items");

            migrationBuilder.RenameTable(
                name: "items",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_items_AuctionId",
                table: "Items",
                newName: "IX_Items_AuctionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_auctions_AuctionId",
                table: "Items",
                column: "AuctionId",
                principalTable: "auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
