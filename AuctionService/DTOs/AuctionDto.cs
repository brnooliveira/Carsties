using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AuctionService.Entities;

namespace AuctionService.DTOs;

public class AuctionDto
{
    [Column("id")] public Guid Id { get; set; }

    [Column("reserved_price")] public int ReservedPrice { get; set; }

    [Column("seller")] [MaxLength(50)] public string Seller { get; set; }

    [Column("winner")] [MaxLength(50)] public string Winner { get; set; }

    [Column("sold_amount")] public int SoldAmount { get; set; }

    [Column("current_high_bid")] public int CurrentHighBid { get; set; }

    [Column("created_at")] public DateTime CreatedAt { get; set; }

    [Column("updated_at")] public DateTime UpdateAt { get; set; }

    [Column("auction_end")] public DateTime AuctionEnd { get; set; }

    [Column("status")] public string Status { get; set; }

    [Column("make")] [StringLength(50)] public string Make { get; set; }

    [Column("model")] [StringLength(50)] public string Model { get; set; }

    [Column("year")] public int Year { get; set; }

    [Column("color")] [StringLength(30)] public string Color { get; set; }

    [Column("mileage")] public int Mileage { get; set; }

    [Column("image_url")]
    [StringLength(200)]
    public string ImageUrl { get; set; }
}