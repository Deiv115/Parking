using System.ComponentModel.DataAnnotations;

namespace Parking.Models;

public class Cars
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime ReleaseDate { get; set; }
    public string? CarType { get; set; }
    public decimal Price { get; set; }
}