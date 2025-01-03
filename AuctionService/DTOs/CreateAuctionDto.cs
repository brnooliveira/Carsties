using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService.DTOs;

public class CreateAuctionDto
{
    [Required]
    [Column("make")]
    [StringLength(50)]
    public string Make { get; set; }

    [Required]
    [Column("model")]
    [StringLength(50)]
    public string Model { get; set; }

    [Required] [Column("year")] public int Year { get; set; }

    [Required]
    [Column("color")]
    [StringLength(30)]
    public string Color { get; set; }

    [Required] 
    [Column("mileage")] 
    public int? Mileage { get; set; }

    [Required]
    [Column("image_url")]
    [StringLength(200)]
    public string ImageUrl { get; set; }
}