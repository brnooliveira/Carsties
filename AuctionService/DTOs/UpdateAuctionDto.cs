using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.DTOs;

public class UpdateAuctionDto
{
    [Column("make")] [StringLength(50)] public string Make { get; set; }

    [Column("model")] [StringLength(50)] public string Model { get; set; }

    [Column("year")] public int? Year { get; set; }

    [Column("color")] [StringLength(30)] public string Color { get; set; }

    [Required] [Column("mileage")] public int? Mileage { get; set; }
}