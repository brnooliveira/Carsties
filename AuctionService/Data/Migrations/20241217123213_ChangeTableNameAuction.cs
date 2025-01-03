using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTableNameAuction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Auctions_AuctionId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Auctions",
                table: "Auctions");

            migrationBuilder.RenameTable(
                name: "Auctions",
                newName: "auctions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_auctions",
                table: "auctions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_auctions_AuctionId",
                table: "Items",
                column: "AuctionId",
                principalTable: "auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_auctions_AuctionId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_auctions",
                table: "auctions");

            migrationBuilder.RenameTable(
                name: "auctions",
                newName: "Auctions");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Auctions",
                table: "Auctions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Auctions_AuctionId",
                table: "Items",
                column: "AuctionId",
                principalTable: "Auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
