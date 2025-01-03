using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.Entities
{
    [Table("items")]
    public class Item
    {
        [Key] [Column("id")] public Guid Id { get; set; }

        [Column("make")] [StringLength(50)] public string Make { get; set; }

        [Column("model")] [StringLength(50)] public string Model { get; set; }

        [Column("year")] public int Year { get; set; }

        [Column("color")] [StringLength(30)] public string Color { get; set; }

        [Column("mileage")] public int Mileage { get; set; }

        [Column("image_url")]
        [StringLength(200)]
        public string ImageUrl { get; set; }

        [Column("auction_id")] public Guid AuctionId { get; set; }

        [ForeignKey(nameof(AuctionId))] public Auction Auction { get; set; }
    }
}