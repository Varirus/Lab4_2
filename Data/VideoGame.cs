using System.ComponentModel.DataAnnotations;

namespace Lab4_2.Data;

public class VideoGame
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public float? Rating { get; set; }
    public int? RatingsAmount { get; set; }
    public string? Genre { get; set; }
    [DataType(DataType.Date)]
    public DateTime? RelaseDate { get; set; }
    public string? ImageUrl { get; set; }
}

