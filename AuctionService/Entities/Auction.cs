using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities;

[Table("auctions")]
public class Auction
{
    [Column("id")] public Guid Id { get; set; }

    [Column("reserved_price")] public int ReservedPrice { get; set; }

    [Column("seller")] [MaxLength(50)] public string Seller { get; set; }

    [Column("winner")] [MaxLength(50)] public string Winner { get; set; }

    [Column("sold_amount")] public int SoldAmount { get; set; }

    [Column("current_high_bid")] public int CurrentHighBid { get; set; }

    [Column("created_at")] public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    [Column("updated_at")] public DateTime UpdateAt { get; set; } = DateTime.UtcNow;

    [Column("auction_end")] public DateTime AuctionEnd { get; set; }

    [Column("status")] public Status Status { get; set; }

    [Column("item")] public Item Item { get; set; }
}