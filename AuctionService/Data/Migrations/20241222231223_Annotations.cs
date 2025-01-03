using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuctionService.Data.Migrations
{
    /// <inheritdoc />
    public partial class Annotations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_auctions_AuctionId",
                table: "items");

            migrationBuilder.RenameColumn(
                name: "Year",
                table: "items",
                newName: "year");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "items",
                newName: "model");

            migrationBuilder.RenameColumn(
                name: "Mileage",
                table: "items",
                newName: "mileage");

            migrationBuilder.RenameColumn(
                name: "Make",
                table: "items",
                newName: "make");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "items",
                newName: "color");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "items",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "items",
                newName: "image_url");

            migrationBuilder.RenameColumn(
                name: "AuctionId",
                table: "items",
                newName: "auction_id");

            migrationBuilder.RenameIndex(
                name: "IX_items_AuctionId",
                table: "items",
                newName: "IX_items_auction_id");

            migrationBuilder.RenameColumn(
                name: "Winner",
                table: "auctions",
                newName: "winner");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "auctions",
                newName: "status");

            migrationBuilder.RenameColumn(
                name: "Seller",
                table: "auctions",
                newName: "seller");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "auctions",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UpdateAt",
                table: "auctions",
                newName: "updated_at");

            migrationBuilder.RenameColumn(
                name: "SoldAmount",
                table: "auctions",
                newName: "sold_amount");

            migrationBuilder.RenameColumn(
                name: "ReservedPrice",
                table: "auctions",
                newName: "reserved_price");

            migrationBuilder.RenameColumn(
                name: "CurrentHighBid",
                table: "auctions",
                newName: "current_high_bid");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "auctions",
                newName: "created_at");

            migrationBuilder.RenameColumn(
                name: "AuctionEnd",
                table: "auctions",
                newName: "auction_end");

            migrationBuilder.AlterColumn<string>(
                name: "model",
                table: "items",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "make",
                table: "items",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "color",
                table: "items",
                type: "character varying(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "image_url",
                table: "items",
                type: "character varying(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "winner",
                table: "auctions",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "seller",
                table: "auctions",
                type: "character varying(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_items_auctions_auction_id",
                table: "items",
                column: "auction_id",
                principalTable: "auctions",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_items_auctions_auction_id",
                table: "items");

            migrationBuilder.RenameColumn(
                name: "year",
                table: "items",
                newName: "Year");

            migrationBuilder.RenameColumn(
                name: "model",
                table: "items",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "mileage",
                table: "items",
                newName: "Mileage");

            migrationBuilder.RenameColumn(
                name: "make",
                table: "items",
                newName: "Make");

            migrationBuilder.RenameColumn(
                name: "color",
                table: "items",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "items",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "image_url",
                table: "items",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "auction_id",
                table: "items",
                newName: "AuctionId");

            migrationBuilder.RenameIndex(
                name: "IX_items_auction_id",
                table: "items",
                newName: "IX_items_AuctionId");

            migrationBuilder.RenameColumn(
                name: "winner",
                table: "auctions",
                newName: "Winner");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "auctions",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "seller",
                table: "auctions",
                newName: "Seller");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "auctions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "updated_at",
                table: "auctions",
                newName: "UpdateAt");

            migrationBuilder.RenameColumn(
                name: "sold_amount",
                table: "auctions",
                newName: "SoldAmount");

            migrationBuilder.RenameColumn(
                name: "reserved_price",
                table: "auctions",
                newName: "ReservedPrice");

            migrationBuilder.RenameColumn(
                name: "current_high_bid",
                table: "auctions",
                newName: "CurrentHighBid");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "auctions",
                newName: "CreatedAt");

            migrationBuilder.RenameColumn(
                name: "auction_end",
                table: "auctions",
                newName: "AuctionEnd");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "items",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "items",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Color",
                table: "items",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "items",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Winner",
                table: "auctions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Seller",
                table: "auctions",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_items_auctions_AuctionId",
                table: "items",
                column: "AuctionId",
                principalTable: "auctions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
